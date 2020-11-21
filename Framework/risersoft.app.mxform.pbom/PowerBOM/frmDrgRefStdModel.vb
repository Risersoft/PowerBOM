Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgRefStdModel
    Inherits clsFormDataModel
    Dim myViewSpecCNC, myViewParam As clsViewModel, myBOM As New clsBOM(myContext), RefStdDrgId As Integer
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("DrgItems")
        myViewSpecCNC = Me.GetViewModel("SpecCNC")
        myViewParam = Me.GetViewModel("Param")
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
        Dim cont As Boolean = True
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from DrgItems where DrgItemId = " & prepIDX
        Me.InitData(Sql, "StdDrgId,ProDocuId", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("ProDocuId")) Then
            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        ElseIf myUtils.NullNot(myRow("StdDrgId")) AndAlso myUtils.NullNot(myRow("ProDocuId")) Then
            cont = False
        End If

        If cont Then
            If frmMode = EnumfrmMode.acEditM Then
                Dim oret1 As clsProcOutput = Me.GenerateIDOutput("stddrgrow", myRow("RefDrgItemId"))
                If oret1.Success Then
                    SetStdDrg(oret1.Data.Tables(0).Rows(0))
                End If
            Else
                RefStdDrgId = 0
            End If

            Dim params As New List(Of clsSQLParam)
            params.Add(New clsSQLParam("@StdDrgId", myUtils.cValTN(RefStdDrgId), GetType(Integer), False))
            myView = Me.GenerateParamsModel(myView.ViewState, "drgitems", params)
            Me.GridViews.AddUpd("DrgItems", myView)

            Sql = "Select * from deslistdrgitemcalc() where len(cncdrgnew)>0 and drgitemid=" & frmIDX
            myViewSpecCNC.MainGrid.QuickConf(Sql, True, "1-2-5-2-1-2-1", True)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub SetStdDrg(ByVal r As DataRow)
        If (Not r Is Nothing) AndAlso (r.Table.Columns.Contains("stddrgid")) AndAlso (myUtils.cValTN(r("stddrgid"))) > 0 Then
            RefStdDrgId = myUtils.cValTN(r("stddrgid"))

            Dim params As New List(Of clsSQLParam)
            params.Add(New clsSQLParam("@DrgItemId", myUtils.cValTN(frmIDX), GetType(Integer), False))
            params.Add(New clsSQLParam("@RefStdDrgId", myUtils.cValTN(RefStdDrgId), GetType(Integer), False))
            params.Add(New clsSQLParam("@StdDrgId", myUtils.cValTN(myRow("stddrgid")), GetType(Integer), False))
            myViewParam = Me.GenerateParamsModel(myViewParam.ViewState, "stddrgparam", params)
            Me.GridViews.AddUpd("Param", myViewParam)
        End If
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("itemnum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If (Not myUtils.NullNot(myRow("prodocuid"))) AndAlso myUtils.cStrTN(myRow("qty")).Trim.Length = 0 Then Me.AddError("Qty", "Please enter Qty")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")

        myViewParam = Me.GridViews("param")
        myView = Me.GridViews("DrgItems")
        If myUtils.NullNot(myRow("prodocuid")) Then
            myViewParam.MainGrid.CheckValid("", "", "", "<CHECK COND=""(paramvalue is not null) or (stddrgparamid2 is not null)"" MSG=""Parameter Value or Link Required""/>")
        Else
            myViewParam.MainGrid.CheckValid("paramvalue")
        End If
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

                    Dim dtMyReq As DataTable = Me.GenerateData("drgitemparam", myUtils.cValTN(frmIDX)).Tables(0)
                    myUtils.DeleteRows(dtMyReq.Select)
                    myUtils.CopyRows(myViewParam.MainGrid.myDS.Tables(0).Select(myViewParam.MainGrid.myDV.RowFilter), dtMyReq)
                    myUtils.ChangeAll(dtMyReq.Select, "DrgItemId=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dtMyReq, "select * from drgitemparam where drgitemparamid = 0")

                    Dim rDocu As DataRow = Nothing
                    If Not myUtils.NullNot(myRow("ProDocuId")) Then
                        Dim oret As clsProcOutput = Me.GenerateIDOutput("prodocuinfo", myUtils.cValTN(myRow("ProDocuId")))
                        If oret.Success Then
                            rDocu = oret.Data.Tables(0).Rows(0)
                        End If
                    End If

                    Dim oTree As clsTreeModel = myBOM.HandleCalc(myRow.Row, rDocu, myViewSpecCNC.MainGrid.myDS, myFuncsPB.BuildBOMTree, Me.sqlForm)
                    myView.MainTree = oTree
                    myViewSpecCNC.RefreshGrid()

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
            Case "prodocuinfo"
                Dim r1 As DataRow = myFuncsPB.ProdocuInfo(myContext, frmIDX)
                If r1 Is Nothing Then oRet.Success = False Else oRet.Data = r1.Table.DataSet
            Case "stddrgrow"
                Dim r1 As DataRow = myFuncsPB.DrgItemStdDrgRow(myContext, frmIDX)
                If r1 Is Nothing Then oRet.Success = False Else oRet.Data = r1.Table.DataSet
            Case "paramreqdrg"
                Dim dic As New clsCollecString(Of String)
                dic.Add("Param", "select stddrgparamid, paramname,formula from stddrgparam where stddrgid = " & frmIDX)
                dic.Add("ReqDrg", "select drgitemparam.drgitemparamid, drgitemparam.isuser, drgitemparam.paramvalue, drgitemparam.drgitemid, stddrgparamid from drgitemparam inner join drgitems on drgitemparam.drgitemid = drgitems.drgitemid where stddrgid = " & frmIDX)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "stddrgparam"
                    Dim sql1 As String = myContext.SQL.PopulateSQLParams("select stddrgparamid, stddrgid, ParamName, Descrip, 0.0 as ParamValue, 0 as StdDrgParamID2 from stddrgparam where isnull(formula,'')='' and stddrgid =@RefStdDrgId", Params)
                    Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1)
                    For Each nr In ds.Tables(0).Select
                        nr("paramvalue") = DBNull.Value
                        nr("stddrgparamid2") = DBNull.Value
                    Next

                    Dim Str1 As String
                    Dim str2 As String = "<COL KEY=""ParamValue"" CAPTION=""Value"" FORMAT=""0.0##;-0.0##;0.0##""/>"
                    Dim StdDrgId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@StdDrgId", Params))
                    If myUtils.NullNot(StdDrgId) Then
                        Str1 = "1-4-1-0"
                    Else
                        Str1 = "1-4-1-1"
                        Dim sql2 As String = "select stddrgparamid,paramname from stddrgparam where stddrgid=" & StdDrgId
                        str2 = str2 & "<COL KEY=""stddrgparamid2"" CAPTION=""Link Parameter"" LOOKUPSQL=""" & sql2 & """/>"
                    End If

                    Model.MainGrid.BindGridData(ds, 0)
                    Model.MainGrid.QuickConf("", True, Str1, True)
                    Model.MainGrid.PrepEdit("<BAND INDEX=""0"">" & str2 & "</BAND>", EnumEditType.acEditOnly)

                    Dim DrgItemId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@DrgItemId", Params))
                    Dim dtMyReq As DataTable = Me.GenerateData("drgitemparam", myUtils.cValTN(DrgItemId)).Tables(0)
                    For Each r1 In dtMyReq.Select
                        Dim rr() As DataRow = Model.MainGrid.myDS.Tables(0).Select("stddrgparamid = " & r1("stddrgparamid"))
                        If rr.Length > 0 Then
                            rr(0)("paramvalue") = r1("paramvalue")
                            rr(0)("stddrgparamid2") = r1("stddrgparamid2")
                        End If
                    Next
                Case "drgitems"
                    Model.Mode = EnumViewMode.acSelectM
                    Dim sql1 As String = myContext.SQL.PopulateSQLParams("select * from deslistdrgitems() where refdrgitemid is null and stddrgid=@stddrgid", Params)
                    Model.MainGrid.QuickConf(sql1, True, "1-0-0-2-5-2-0-2-1", True, "Parts List")
                Case "stddrg"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""STDDRGID""/>", False)
            End Select
        End If
        Return Model
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "drgitemparam"
                Dim sql As String = "Select * from drgitemparam where drgitemid = " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function
End Class
