Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgCollecModel
    Inherits clsFormDataModel
    Dim myViewParam, myViewSpecCNC As clsViewModel
    Dim dic As New clsCollecString(Of String), myBOM As New clsBOM(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
        myViewParam = Me.GetViewModel("Param")
        myViewSpecCNC = Me.GetViewModel("SpecCNC")
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
        Dim sql, str1 As String, rr() As DataRow

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from drgitems where drgitemid = " & prepIDX
        Me.InitData(sql, "stddrgid,prodocuid", oView, prepMode, prepIDX, strXML)

        myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
        str1 = "<BAND INDEX=""0"" TABLE=""DrgItemBOM"" IDFIELD=""DrgItemBOMID""><COL KEY=""childDrgItemid,drgitemid,qty""/>"
        If myUtils.cValTN(myRow("stddrgid")) > 0 Then
            myView.MainGrid.QuickConf("select * from deslistdrgitemBOM() where childdrgitemid is not null and drgitemid=" & frmIDX, True, "1-2-5-2-1-2-2-1", True, "Parts List")
            sql = "select *,drgitemid as childdrgitemid from deslistdrgitems() where isnull(iscollection,0)=0 and stddrgid=" & myRow("stddrgid")
            str1 = str1 & "<COL KEY=""QtyParamID"" CAPTION=""Qty Param"" LOOKUPSQL=""select stddrgparamid, paramname from stddrgparam where stddrgid = " & myUtils.cValTN(myRow("stddrgid")) & """/></BAND>"""

            dic.Add("Param", "select stddrgparamid, paramname,formula from stddrgparam where stddrgid = " & myUtils.cValTN(myRow("stddrgid")))
            dic.Add("Req", "select drgitemparam.drgitemparamid, drgitemparam.isuser, drgitemparam.paramvalue, drgitemparam.drgitemid, stddrgparamid,stddrgparamid2 from drgitemparam inner join drgitems on drgitemparam.drgitemid = drgitems.drgitemid where stddrgid = " & myUtils.cValTN(myRow("stddrgid")))
            Me.AddDataSet("ParamReq", dic)
        ElseIf myUtils.cValTN(myRow("prodocuid")) > 0 Then
            myView.MainGrid.QuickConf("select * from deslistdrgitemBOM() where childdrgitemid is not null and drgitemid=" & frmIDX, True, "1-2-5-2-1-0-2-1", True, "Parts List")
            sql = "select *,drgitemid as childdrgitemid from deslistdrgitems() where isnull(iscollection,0)=0 and prodocuid=" & myRow("prodocuid")
            str1 = str1 & "</BAND>"""

            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        Else
            sql = ""
        End If

        If sql <> "" Then
            myRow("iscollection") = True
            myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), sql, "childdrgitemid")
            myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            If myUtils.cValTN(myRow("stddrgid")) > 0 Then
                myViewParam.MainGrid.myDS = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select stddrgparamid, stddrgid, ParamName, Descrip, 0.0 as ParamValue from stddrgparam where isnull(formula,'')='' and stddrgid =" & myUtils.cValTN(myRow("stddrgid")))
                For Each nr As DataRow In myViewParam.MainGrid.myDS.Tables(0).Select
                    nr("paramvalue") = DBNull.Value
                Next

                myViewParam.MainGrid.BindGridData(myViewParam.MainGrid.myDS, 0)
                myViewParam.MainGrid.QuickConf("", True, "1-4-1", True)
                myViewParam.MainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""ParamValue"" CAPTION=""Value"" FORMAT=""0.0;-0.0;0.0""/></BAND>", EnumEditType.acEditOnly)
                For Each r As DataRow In Me.DatasetCollection("ParamReq").Tables("Req").Select("drgitemid=" & frmIDX)
                    rr = myViewParam.MainGrid.myDS.Tables(0).Select("stddrgparamid=" & r("stddrgparamid"))
                    If rr.Length > 0 Then rr(0)("paramvalue") = r("paramValue")
                Next
            Else
                sql = "Select * from deslistdrgitemcalc() where len(cncdrgneW)>0 and drgitemid=" & frmIDX
                myViewSpecCNC.MainGrid.QuickConf(sql, True, "3-1-5-2-1-2-1", True)
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")
        If myView.MainGrid.myDS.Tables(0).Select("sysincl=1").Length = 0 Then Me.AddError("", "Select Items")
        myView.MainGrid.CheckValid("", "sysincl=1", , "<CHECK COND=""isnull(specification,'')='' or isnull(specification,'')='-' or Qty&gt;0 or qtyparamid&gt;0"" MSG=""Enter Qty or parameter""/>")
        If myUtils.cValTN(myRow("prodocuid")) > 0 AndAlso myUtils.cValTN(myRow("Qty")) = 0 Then Me.AddError("Qty", "Please enter Quantity")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            myRow("specification") = "[Collection]"
            myRow("refdrgitemid") = DBNull.Value
            Dim dt As DataTable = myView.MainGrid.myDS.Tables(0).Copy
            dt.Columns.Add("wt", GetType(Decimal), "qty*weight/wtqty")
            myRow("weight") = dt.Compute("sum(wt)", "sysincl=1")
            If myUtils.cValTN(myRow("stddrgid")) > 0 Then
                myRow("qty") = DBNull.Value     'always defined by referencing item for standard drawings. useful in list crosstab
            Else
                myRow("weight") = myUtils.cValTN(myRow("weight")) * myUtils.cValTN(myRow("qty"))
            End If
            dt = New DataTable
            dt.Columns.Add("stddrgparamid", GetType(Integer))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)

                If myBOM.List.SaveItem(myRow.Row) Then
                    frmIDX = myRow("drgitemid")
                    frmMode = EnumfrmMode.acEditM

                    If myUtils.cValTN(myRow("stddrgid")) > 0 Then
                        dt = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from drgitemparam where drgitemid = " & frmIDX).Tables(0)
                        myUtils.DeleteRows(dt.Select)
                        myUtils.CopyRows(myViewParam.MainGrid.myDS.Tables(0).Select(myViewParam.MainGrid.myDV.RowFilter), dt)
                        myUtils.ChangeAll(dt.Select, "drgitemid=" & frmIDX)
                        myContext.Provider.objSQLHelper.SaveResults(dt, "select * from drgitemparam where drgitemparamid = 0")
                    End If
                    myView.MainGrid.SaveChanges(, "drgitemid=" & frmIDX)
                    myViewSpecCNC.RefreshGrid()

                    Dim rDocu As DataRow = Nothing
                    If Not myUtils.NullNot(myRow("ProDocuId")) Then
                        Dim oret As clsProcOutput = Me.GenerateIDOutput("prodocuinfo", myUtils.cValTN(myRow("ProDocuId")))
                        If oret.Success Then
                            rDocu = oret.Data.Tables(0).Rows(0)
                        End If
                    End If
                    Dim oTree As clsTreeModel = myBOM.HandleCalc(myRow.Row, rDocu, myViewSpecCNC.MainGrid.myDS, myFuncsPB.BuildBOMTree, Me.sqlForm)
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

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "prodocuinfo"
                Dim r1 As DataRow = myFuncsPB.ProdocuInfo(myContext, frmIDX)
                If r1 Is Nothing Then oRet.Success = False Else oRet.Data = r1.Table.DataSet
        End Select
        Return oRet
    End Function
End Class
