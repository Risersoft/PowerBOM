Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgPartItemModel
    Inherits clsFormDataModel
    Dim myViewParamReq, myViewParamUser As clsViewModel, rDocu As DataRow, myBOM As New clsBOM(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
        myViewParamReq = Me.GetViewModel("ParamReq")
        myViewParamUser = Me.GetViewModel("ParamUser")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "Select Distinct SubCatId, DrgBomName, isGasket, BomSepcharts, BomSectionTypeCode from invListItems() where isnull(inTankDrawings,0)=1 and isnull(isHardware,0)=0 and isnull(inItemCollec,0)=0 order by DrgBomName"
        Me.AddLookupField("SubCat", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "SubCat").TableName)


        Dim vlist1 As New clsValueList
        vlist1.Add(0, "Lo/Li, Bo/Bi")
        vlist1.Add(1, "2 strips")
        Me.ValueLists.Add("GasketTypeCode", vlist1)
        Me.AddLookupField("GasketTypeCode", "GasketTypeCode")

        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim StrDirec As String = ""
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from drgitems where drgitemid = " & prepIDX
        Me.InitData(Sql, "stddrgid,prodocuid", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("stddrgid")) Then
            Sql = "Select StdDrgParamId, ParamName,Formula from StdDrgParam where StdDrgId = " & myUtils.cValTN(myRow("StdDrgId"))
            Me.AddLookupField("cmb", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Param").TableName)
            StrDirec = "/CNC/STD"
        ElseIf Not myUtils.NullNot(myRow("prodocuid")) Then
            rDocu = myFuncsPB.ProdocuInfo(myContext, myUtils.cValTN(myRow("prodocuid")))
            If (Not rDocu Is Nothing) Then StrDirec = "/CNC/FILE/" & myContext.FTP.ReplaceSpecialChars(rDocu("woinfo")) Else StrDirec = ""

            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        End If

        If StrDirec.Trim.Length > 0 Then
            Me.ModelParams.Add(New clsSQLParam("@strDirec", "'" & StrDirec & "'", GetType(String), False))

            myView.MainGrid.MainConf("autorowht") = True
            Sql = "select distinct itemid,bomnonstd,subcatid,density,wtpermtr,wtperno,areapermtr,bommatsection,bomthk,ItemCode,ItemName from invlistitems() where isnull(intankdrawings,0)=1"
            myView.MainGrid.BindGridData(myFuncsBase.AttributedItemsTable(myContext, Sql, Nothing, False), 0)
            myView.MainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(myContext, myView.MainGrid.myDV.Table.DataSet.Tables("attrib"))
            myView.Mode = EnumViewMode.acSelectM
            myView.MainGrid.QuickConf("", True, "0-4-0-0-0-0-0", True)

            BindDataTable(myUtils.cValTN(myRow("stddrgid")))

            myViewParamReq.MainGrid.BindGridData(dsForm, 1)
            myViewParamReq.MainGrid.QuickConf("", True, "1-4", True, "Parameters used in Drawing Item")
            myViewParamReq.MainGrid.myDV.RowFilter = "stddrgparamid in (" & myUtils.MakeCSV(dsForm.Tables("Req").Select("isnull(isuser, 0) = 0"), "stddrgparamid") & ")"

            myViewParamUser.MainGrid.BindGridData(dsForm, 2)
            myViewParamUser.Mode = EnumViewMode.acSelectM : myViewParamUser.MultiSelect = True
            myViewParamUser.MainGrid.QuickConf("", True, "1-4", True, "Manually Force Parameter to be specified")
            myViewParamUser.MainGrid.myDV.RowFilter = "stddrgparamid not in (" & myUtils.MakeCSV(dsForm.Tables("Req").Select("isnull(isuser, 0) = 0"), "stddrgparamid") & ")"


            FormPrepared = True
        Else
            Me.AddError("ItemNum", "Document Not found")
        End If
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(StdDrgId As Integer)
        Dim dic As New clsCollecString(Of String)
        dic.Add("ParamReq", "select stddrgparamid, stddrgid, ParamName, Descrip from stddrgparam where isnull(formula,'')='' and stddrgid =" & myUtils.cValTN(StdDrgId))
        dic.Add("ParamUser", "select stddrgparamid, 0 as isuser, stddrgid, ParamName, Descrip from stddrgparam where isnull(formula,'')='' and stddrgid =" & myUtils.cValTN(StdDrgId))
        dic.Add("Req", "select * from drgitemparam where drgitemid = " & frmIDX)
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        For Each dt1 As DataTable In ds.Tables
            myUtils.AddTable(Me.dsForm, dt1, dt1.TableName)
        Next
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            myContext.Provider.dbConn.BeginTransaction(myContext)
            Try
                If myBOM.List.SaveItem(myRow.Row) Then
                    frmIDX = myRow("drgitemid")
                    frmMode = EnumfrmMode.acEditM


                    myUtils.DeleteRows(dsForm.Tables("Req").Select)
                    myUtils.ChangeAll(myViewParamUser.MainGrid.myDS.Tables("ParamUser").Select, "isuser=1")
                    myUtils.CopyRows(myViewParamReq.MainGrid.myDS.Tables("ParamReq").Select(myViewParamReq.MainGrid.myDV.RowFilter), dsForm.Tables("Req"))
                    myUtils.CopyRows(myViewParamUser.MainGrid.myDS.Tables("ParamUser").Select(myViewParamUser.MainGrid.myDV.RowFilter & IIf(myViewParamUser.MainGrid.myDV.RowFilter = "", "", " AND ") & " (sysincl=1)"), dsForm.Tables("Req"), , False)
                    myUtils.ChangeAll(dsForm.Tables("Req").Select, "drgitemid=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("Req"), "select * from drgitemparam where drgitemparamid = 0")

                    Dim oTree As clsTreeModel = myBOM.HandleCalc(myRow.Row, rDocu, Nothing, myFuncsPB.BuildBOMTree, Me.sqlForm)
                    myView.MainTree = oTree

                    VSave = True
                    myContext.Provider.dbConn.CommitTransaction()
                End If
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
