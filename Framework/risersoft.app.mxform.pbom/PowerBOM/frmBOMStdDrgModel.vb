Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmBOMStdDrgModel
    Inherits clsFormDataModel
    Dim myViewDel As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Item")
        myViewDel = Me.GetViewModel("ItemDel")
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
        Dim Sql As String = "Select * from StdDrg where StdDrgId = " & prepIDX
        Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

        BindDrgItem()
        BindDrgItemDel()
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Private Sub BindDrgItem()
        myView.MainGrid.BindGridData(GenerateData("drgitem", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-2-5-2-2-1", True, "")
    End Sub

    Private Sub BindDrgItemDel()
        myViewDel.MainGrid.BindGridData(GenerateData("drgitemdel", frmIDX), 0)
        myViewDel.MainGrid.QuickConf("", True, "1-2-5-2-2-1", True, "")
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            VSave = True
        End If
    End Function

    Public Overrides Sub OperateProcess(processKey As String)
        Select Case processKey.Trim.ToLower
            Case "refreshall"
                BindDrgItem()
                BindDrgItemDel()
            Case "markasdelete"
                Dim DrgItemId As Integer = myContext.SQL.ParamValue("@DrgItemId", Me.ClientParams)
                Dim sql As String = "Update DrgItems set IsDeleted = 1 where DrgItemId =" & myUtils.cValTN(DrgItemId)
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                BindDrgItem()
                BindDrgItemDel()
            Case "markasundelete"
                Dim DrgItemId As Integer = myContext.SQL.ParamValue("@DrgItemId", Me.ClientParams)
                Dim sql As String = "Update DrgItems set IsDeleted = 0 where DrgItemId =" & myUtils.cValTN(DrgItemId)
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                BindDrgItem()
                BindDrgItemDel()
        End Select
    End Sub

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim StdDrgId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@StdDrgId", Params))
            Dim DrgItemID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@DrgItemID", Params))
            Select Case dataKey.Trim.ToLower
                Case "deletedrgitem"
                    Dim sql As String = "Delete from DrgItems where DrgItemId =" & myUtils.cValTN(DrgItemID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("drgitem", StdDrgId)
                Case "deletedrgitemdel"
                    Dim sql As String = "Delete from DrgItems where DrgItemId =" & myUtils.cValTN(DrgItemID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateData("drgitemdel", StdDrgId)
                Case "refresh"
                    oRet.Data = GenerateData("drgitem", StdDrgId)
                Case "shiftup"
                    Dim myBOM As New clsBOM(myContext)
                    myBOM.List.ShiftUpSaveItem(DrgItemID, StdDrgId, True)
                    oRet.Data = GenerateData("drgitem", StdDrgId)
            End Select
        End If
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "drgitem"
                Dim Sql As String = "select DrgItemID, STDDRGID, STDDRG, DRAWING, ISCOLLECTION, REFDRGITEMID, REFSTDDRGID, ITEMID, ITEMCOLLECTYPECODE, ItemNum, Description, Specification, Material, Remark, Weight from deslistdrgitems() where isnull(isdeleted,0)=0 and stddrgid=" & ID & " order by itemnum1,itemnum2"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "drgitemdel"
                Dim Sql As String = "select DrgItemID, STDDRGID, STDDRG, DRAWING, ISCOLLECTION, REFDRGITEMID, REFSTDDRGID, ITEMID, ITEMCOLLECTYPECODE, ItemNum, Description, Specification, Material, Remark, Weight from deslistdrgitems() where isnull(isdeleted,0)=1 and stddrgid=" & ID & " order by itemnum1,itemnum2"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        End Select
        Return oRet.Data
    End Function
End Class
