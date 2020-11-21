Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFNestModel
    Inherits clsFormDataModel
    Dim TFN1MyView, TFN2MyView, TFN3MyView As clsViewModel
    Protected Overrides Sub InitViews()
        TFN1MyView = Me.GetViewModel("TFNestReq")
        TFN2MyView = Me.GetViewModel("TFNestItems")
        TFN3MyView = Me.GetViewModel("TFNestSheet")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "Select CNCTypeId,CNCTypeName from CNCTypes Order by CNCTypeName"
        Me.AddLookupField("CNCTypeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "CNCType").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "TFNestId", prepIDX)
        If oRet.Success Then
            Dim Sql As String = "select * from TFNest where TFNestId =" & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            'strw is required by frmTFNest1 also
            Dim strw As String = "(isnull(iscompleted,0)=0 or (tfnestreqid in (select tfnestreqid from tfnestitems where TFNestId = " & frmIDX & ")))"

            Sql = "select distinct thk, thk as thk1 from camlistreqitems() where " & strw & " and thk is not null order by thk"
            Me.AddLookupField("Thk", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Thk").TableName)

            TFN1MyView.Mode = EnumViewMode.acSelectM : TFN1MyView.MultiSelect = True
            TFN1MyView.MainGrid.MainConf("autorowht") = True
            TFN1MyView.MainGrid.MainConf("formatxml") = "<COL KEY=""reqinfo"" CAPTION=""Serial No.""/><COL KEY=""DesDocGrp"" CAPTION=""Group""/>"
            'TFN1MyView.MainGrid.myCMain("hidecols") = "reqinfo,rating"
            TFN1MyView.MainGrid.BindGridData(myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from camlistreq() where " & strw & " order by reqdate"), 0)
            TFN1MyView.MainGrid.QuickConf("", True, "1-1-2-1-0.5-1-0.5-1-0.5-1-2", True)
            TFN1MyView.MainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""sysIncl""/></BAND>", EnumEditType.acEditOnly)


            TFN2MyView.MainGrid.MainConf("rhfactor") = 1 : TFN2MyView.MainGrid.MainConf("bansort") = True
            TFN2MyView.MainGrid.MainConf("sortcolsasc") = "Reference" : TFN2MyView.MainGrid.MainConf("showrownumber") = True
            Sql = "select tfnestitemid,cncdrg, nocommoncut,tfnestid,reqdate, thk, tfnestreqid,Snum, ReqInfo, PartNum, Reference, Description, Specification, QtyReq,Qty,QtyNested from camlistnestitems() where tfnestid = " & frmIDX & " order by reqdate,reference"
            TFN2MyView.MainGrid.QuickConf(Sql, True, "1-2-2-2-2-1-1-1-1", True)
            TFN2MyView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""TFNestItems"" IDFIELD=""TFNestItemID""><COL NOEDIT=""True"" KEY=""tfnestreqid,tfnestid,snum,PartNum,cncdrg, Reference, Description, Specification, Qtyreq,QtyNested,NoCommonCut""/><COL KEY=""Qty""/></BAND>", EnumEditType.acCommandAndEdit)


            TFN3MyView.MainGrid.MainConf("showrownumber") = True
            TFN3MyView.MainGrid.QuickConf("select tfnestsheetid,cncdrg,cncdrgrem,ncfile, layoutnum,tfnestid, perUtil from TFNestSheet where tfnestid = " & myUtils.cValTN(myRow("tfnestid")), True, "1", True, "Sheets")
            TFN3MyView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""TFNestSheet"" IDFIELD=""TFNestSheetID""><COL KEY=""tfnestid,partxml,cncdrg,cncdrgrem,layoutnum,ncfile""/><COL KEY=""perutil"" CAPTION=""% Util"" NOEDIT=""True""/></BAND>", EnumEditType.acCommandAndEdit)


            myRow("Dated") = Today
            Me.FormPrepared = True
        Else
            Me.AddError("", Nothing, 0, "", "", oRet.Message)
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("THK") Is Nothing Then Me.AddError("Thk", "Select thickness")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                If frmMode = EnumfrmMode.acAddM Then
                    Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select top 1 NestNum from tfnest order by NestNum desc").Tables(0)
                    myRow("NestNum") = myUtils.MaxVal(dt.Select, "NestNum") + 1
                End If
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                Me.ChangeModeGetLock("TFNestId")
                TFN2MyView.MainGrid.SaveChanges(, "TFNestId=" & frmIDX)
                TFN3MyView.MainGrid.SaveChanges(, "TFNestId=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim str2, sql As String
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "cncdrg"
                    Dim Thk As Decimal = myUtils.cValTN(myContext.SQL.ParamValue("@Thk", Params))
                    Dim TfNestReqIdCSV As String = myContext.SQL.ParamValue("@TfNestReqIdCSV", Params)

                    TfNestReqIdCSV = myUtils.CombineWhere(False, "thk = " & Thk, "tfnestreqid in (" & TfNestReqIdCSV & ")", "isnull(excludecnc,0)=0")
                    str2 = ", reqdate, thk,nocommoncut, tfnestreqid, ReqInfo, PartNum, Reference, Description, Specification, Qty from camlistreqitems() where " & TfNestReqIdCSV

                    sql = "select cncdrg " & str2 & " union all " & _
                        "select cncdrg2 " & str2 & "and isnull(cncdrg2,'')<>'' union all " & _
                        "select cncdrg3 " & str2 & "and isnull(cncdrg3,'')<>'' union all " & _
                        "select cncdrg4 " & str2 & "and isnull(cncdrg4,'')<>'' union all " & _
                        "select cncdrg5 " & str2 & "and isnull(cncdrg5,'')<>'' union all " & _
                        "select cncdrg6 " & str2 & "and isnull(cncdrg6,'')<>'' " & _
                        "order by reqdate,reference"
                    oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            End Select
        End If
        Return oRet
    End Function
End Class
