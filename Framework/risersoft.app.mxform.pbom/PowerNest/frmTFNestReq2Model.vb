Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFNestReq2Model
    Inherits clsFormDataModel
    Dim myViewPart As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("TFNestReq")
        myViewPart = Me.GetViewModel("Part")
    End Sub
    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim sql, str1 As String

        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "PidUnitId", prepIDX)
        If prepMode = EnumfrmMode.acEditM AndAlso oRet.Success Then
            sql = "select * from desListPidUnittot() where PidUnitId = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

            sql = "select distinct DesDocGrpName from deslistprodocu() where PidUnitId=" & frmIDX
            Me.ValueLists.Add("DesDocGrp", myContext.SQL.VListFromTable(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)))
            Me.AddLookupField("DesDocGrp", "DesDocGrp")

            sql = "select distinct cnctypeid,cnctypename from deslistdrgitemcalc() where isnull(cnctypeid,0)>0 and isnull(thk,0)>0 and PidUnitId=" & frmIDX
            Me.ValueLists.Add("CNCType", myContext.SQL.VListFromTable(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)))
            Me.AddLookupField("CNCTypeID", "CNCType")

            sql = "select tfnestreqid, PidUnitId,CNCTypeID, DesDocGrp, ReqDate, WorkGroup, IsCompleted, Qty, Remark from TFNestReq where drgitemid is null and PidUnitId = " & prepIDX
            myView.MainGrid.QuickConf(sql, True, "1-1-1-1-1-1-2", True)
            str1 = "<BAND INDEX=""0"" TABLE=""TFNestReq"" IDFIELD=""TFNestReqID""><COL KEY=""PidUnitId,Remark,qty""/><COL NOEDIT=""True"" KEY=""desdocgrp"" CAPTION=""Document Group""/><COL KEY=""reqdate"" CAPTION=""Required Date""/><COL KEY=""Workgroup"" CAPTION=""WorkGroup""/><COL KEY=""IsCompleted"" CAPTION=""Status"" VLIST=""False;Incomplete|True;Completed""/><COL NOEDIT=""True"" KEY=""cnctypeid"" LOOKUPSQL=""Select cnctypeid,cnctypename from cnctypes"" CAPTION=""CNC Type""/></BAND>"
            myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            sql = "select tfnestreqid, PidUnitId, Drgitemid, Qty, ReqDate, WorkGroup, IsCompleted, Remark from TFNestReq where desdocgrp is null and PidUnitId = " & prepIDX
            myViewPart.MainGrid.QuickConf(sql, True, "2-1-1-1-1-2", True)
            str1 = "<BAND INDEX=""0"" TABLE=""TFNestReq"" IDFIELD=""TFNestReqID""><COL KEY=""PidUnitId,Remark,Qty""/><COL NOEDIT=""True"" KEY=""drgitemid"" LOOKUPSQL=""Select drgitemid, item from deslistdrgitems()"" CAPTION=""Item""/><COL KEY=""reqdate"" CAPTION=""Required Date""/><COL KEY=""Workgroup"" CAPTION=""WorkGroup""/><COL KEY=""IsCompleted"" CAPTION=""Status"" VLIST=""False;Incomplete|True;Completed""/></BAND>"
            myViewPart.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            sql = "Select * from TfNestItems where TfNestReqId in (select TfNestReqId from TfNestReq where PidUnitId = " & frmIDX & ")"
            Me.AddDataSet("TfNestItems", sql)
            Me.FormPrepared = True
        Else
            Me.AddError("", Nothing, 0, "", "", oRet.Message)
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        myView.MainGrid.CheckValid("ReqDate,WorkGroup,Qty,IsCompleted")
        myViewPart.MainGrid.CheckValid("ReqDate,WorkGroup,Qty,IsCompleted")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myView.MainGrid.SaveChanges(, "PidUnitId=" & frmIDX)
                myViewPart.MainGrid.SaveChanges(, "PidUnitId=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "drgitems"
                    Model.Mode = EnumViewMode.acSelectM
                    Dim sql As String = myContext.SQL.PopulateSQLParams("select * from desListDrgItems() where refDrgItemId is null and StdDrgId=@StdDrgId", Params)
                    Model.MainGrid.QuickConf(sql, True, "1-0-0-2-5-2-0-2-1", True, "Parts List")
                Case "stddrg"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""STDDRGID""/>", False)
            End Select
        End If
        Return Model
    End Function
End Class
