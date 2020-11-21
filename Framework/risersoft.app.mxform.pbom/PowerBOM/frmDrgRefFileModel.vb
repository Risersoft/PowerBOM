Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgRefFileModel
    Inherits clsFormDataModel
    Dim myBOM As New clsBOM(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("drgitems")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from DrgItems where DrgItemId = " & prepIDX
        Me.InitData(Sql, "ProDocuId", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("ProDocuId")) Then
            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        End If

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myUtils.cStrTN(myRow("Qty")).Trim.Length = 0 Then Me.AddError("Qty", "Please enter Qty")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                If myBOM.List.SaveItem(myRow.Row) Then
                    frmIDX = myRow("DrgItemId")
                    frmMode = EnumfrmMode.acEditM

                    Dim r As DataRow = myFuncsPB.ProdocuInfo(myContext, myUtils.cValTN(myRow("ProDocuId")))
                    Dim oTree As clsTreeModel = myBOM.HandleCalc(myRow.Row, r, Nothing, myFuncsPB.BuildBOMTree, Me.sqlForm)
                    myView.MainTree = oTree
                    myContext.Provider.dbConn.CommitTransaction()
                    VSave = True
                End If
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "fileinfo"
                Dim r1 As DataRow = myFuncsPB.DrgItemFileInfo(myContext, frmIDX)
                If r1 Is Nothing Then oRet.Success = False Else oRet.Data = r1.Table.DataSet
            Case "prodocuinfo"
                Dim r1 As DataRow = myFuncsPB.ProdocuInfo(myContext, frmIDX)
                If r1 Is Nothing Then oRet.Success = False Else oRet.Data = r1.Table.DataSet
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim dic As New clsCollecString(Of String)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "loadpidu"
                    Dim sql1 As String = myContext.SQL.PopulateSQLParams("select * from deslistdrgitems() where RefDrgItemId is null and pidunitid = @PidUnitId", Params)
                    Dim sql2 As String = myContext.SQL.PopulateSQLParams("select hasbom,ProDocuId,Drawing from deslistprodocu() where ProDocuId<>@ProDocuId AND isnull(hasbom,0)=1 and pidunitid=@PidUnitId", Params)
                    dic.Add("drgitems", sql1)
                    dic.Add("prodocu", sql2)
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params), eConf As New clsBandConf(), Sql As String
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "pidunit"
                    Sql = "Select distinct pidinfo,pidunitid,Customer,WOInfo, FileNumComp, OrderDate from deslistpidunittot() where pidunitid in (select pidunitid from deslistdrgitems()) order by orderdate desc"
                    eConf.QuickConf2(Sql, True, "3-1-1-1")
                    eConf("selfirstrow") = True

                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""PIDUNITID""/>", False, eConf)
            End Select
        End If
        Return Model
    End Function
End Class
