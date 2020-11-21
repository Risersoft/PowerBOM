Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgHardwareModel
    Inherits clsFormDataModel
    Dim objInfo As New clsMMInfo(myContext, 1), myBOM As New clsBOM(myContext)
    Dim myViewSubCat, myViewItems, myViewParamReq As clsViewModel, dtReq As DataTable, rDocu As DataRow
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("DrgItemBOM")
        myViewSubCat = Me.GetViewModel("SubCat")
        myViewItems = Me.GetViewModel("Items")
        myViewParamReq = Me.GetViewModel("ParamReq")
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
        Me.InitData(Sql, "StdDrgId,ProDocuId", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("ProDocuId")) Then
            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        End If

        If (Not objInfo.dicSelectorAttrib Is Nothing) AndAlso (objInfo.dicSelectorAttrib.Count > 0) Then
            Sql = "Select StdDrgParamId, ParamName,Formula from StdDrgParam where StdDrgId = " & myUtils.cValTN(myRow("StdDrgId"))
            Me.AddLookupField("LengthParamID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Param").TableName)
            Me.AddLookupField("ThreadParamID", "Param")

            If Not myUtils.NullNot(myRow("prodocuid")) Then
                rDocu = myFuncsPB.ProdocuInfo(myContext, myUtils.cValTN(myRow("ProDocuId")))
            End If

            Sql = "select * from drgitemparam where drgitemid = " & frmIDX
            dtReq = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql).Tables(0)

            BindDataTable(myUtils.cValTN(myRow("stddrgid")), frmIDX, objInfo.ItemSchedIDCSV)

            myViewParamReq.MainGrid.BindGridData(dsForm, 1)
            myViewParamReq.MainGrid.QuickConf("", True, "1-4", True)
            myViewParamReq.MainGrid.myDV.RowFilter = "stddrgparamid in (" & myUtils.MakeCSV(dtReq.Select("isnull(isuser, 0) = 0"), "stddrgparamid") & ")"

            myViewSubCat.MainGrid.BindGridData(dsForm, 2)
            myViewSubCat.Mode = EnumViewMode.acSelectM
            myViewSubCat.MainGrid.QuickConf("", True, "1", True, "Select Type")

            Sql = "select distinct itemid,subcatid,bommatsection,wtperno,ItemCode,ItemName from invlistitems() where isnull(intankdrawings,0)=1 and itemschedid in ( " & objInfo.ItemSchedIDCSV & ")"
            myViewItems.MainGrid.BindGridData(myFuncsBase.AttributedItemsTable(myContext, Sql, myViewSubCat.MainGrid.myDV.Table, False), 0)
            myViewItems.MainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(myContext, myViewItems.MainGrid.myDV.Table.DataSet.Tables("attrib"))
            myViewItems.MainGrid.MainConf("autorowht") = True
            myViewItems.Mode = EnumViewMode.acSelectM
            myViewItems.MainGrid.QuickConf("", True, "0-4-0-0-0-0-0", True, "Select Size")


            myUtils.AddTable(Me.dsCombo, myXMLUtils.PrepValueListDT(objInfo.dicSelectorAttrib()("hwtype")("valuelistxml")), "HWType")
            myView.MainGrid.BindGridData(dsForm, 3)
            myView.Mode = EnumViewMode.acSelectM
            myView.MainGrid.MainConf("bansort") = True
            myView.MainGrid.MainConf("sortcolsasc") = "sortkey"
            myView.MainGrid.QuickConf("", True, "2-5-1-1", True, "Select Elements")
            Dim strv As String = clsGrid.GenVList(Me.dsCombo.Tables("HWType"))
            Dim str1 As String = "<BAND INDEX=""0"" TABLE=""DrgItemBOM"" IDFIELD=""DrgItemBOMID""><COL KEY=""descripbom,drgitemid,itemid, qty,weight""/><COL KEY=""hwtype"" VLIST=""" & strv & """ NOCMD=""1"" CAPTION=""Element""/><COL KEY=""bommatsection"" CAPTION=""Section"" SKIP=""True""/></BAND>"""
            myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
            For Each r1 As DataRow In myView.MainGrid.myDV.Table.Select
                r1("hwtype") = myUtils.cValTN(objInfo.SubCatValue(r1("subcatid"), objInfo.dicSelectorAttrib()("hwtype")("attributeid")))
                r1("sortkey") = r1("hwtype")
            Next
            CalcWeight()
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(StdDrgId As Integer, DrgItemId As Integer, ItemSchedId As String)
        Dim dic As New clsCollecString(Of String)
        dic.Add("ParamReq", "select stddrgparamid, stddrgid, ParamName, Descrip from stddrgparam where isnull(formula,'')='' and stddrgid =" & myUtils.cValTN(StdDrgId))
        dic.Add("SubCat", "select distinct subcatid, SubCatName from invlistitems() where isnull(intankdrawings,0)=1 and itemschedid in ( " & ItemSchedId & ")")
        dic.Add("DrgItemBOM", "select drgitemid,subcatid,weight,descripbom, itemid, 0 as sortkey, 0 as hwType, bomMatSection, WtPerNo, Qty  from deslistdrgitembom() where drgitemid = " & DrgItemId)
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        For Each dt1 As DataTable In ds.Tables
            myUtils.AddTable(Me.dsForm, dt1, dt1.TableName)
        Next
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myView.MainGrid.myDS.Tables("DrgItemBOM").Select("qty>0").Length = 0 Then Me.AddError("", "Qty of all elements are 0")
        myView.MainGrid.CheckValid("bommatsection", "qty>0", , "<CHECK COND=""qty&lt;=3"" MSG=""Quantity should be 0,1,2 or 3""/>")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim sql, str2, str1, arr() As String, dt As DataTable
        Dim r2 As DataRow = Nothing

        str1 = ""
        VSave = False
        If Me.Validate Then
            For Each r As DataRow In myView.MainGrid.myDS.Tables("DrgItemBOM").Rows
                str2 = ""
                Dim HwTyText As String = GetColText(myUtils.cStrTN(r("HwType")), Me.dsCombo.Tables("HWType"), "Value1", "Text")
                If myUtils.cValTN(r("qty")) > 1 Then
                    str2 = Format(r("qty"), "#") & " " & myUtils.cStrTN(HwTyText)
                ElseIf myUtils.cValTN(r("qty")) > 0 Then
                    str2 = myUtils.cStrTN(HwTyText)
                End If
                If str2.Trim.Length > 0 Then
                    If r2 Is Nothing Then r2 = r
                    str1 = str1 & IIf(str1 = "", "", " / ") & str2
                    r("descripbom") = myUtils.cStrTN(HwTyText)
                End If
            Next
            myRow("description") = str1

            str1 = myUtils.cStrTN(r2("bommatsection"))
            Dim strTPID As String = GetColText(CInt(myUtils.cValTN(Me.myRow("ThreadParamID"))), Me.dsCombo.Tables("Param"), "StdDrgParamId", "ParamName")
            Dim strLPID As String = GetColText(CInt(myUtils.cValTN(Me.myRow("LengthParamID"))), Me.dsCombo.Tables("Param"), "StdDrgParamId", "ParamName")
            If myUtils.cValTN(myRow("LengthParamID")) > 0 AndAlso myUtils.cValTN(myRow("ThreadParamID")) > 0 Then
                str1 = strTPID & " x " & strLPID
            ElseIf myUtils.cValTN(myRow("LengthParamID")) > 0 OrElse myUtils.cValTN(myRow("ThreadParamID")) > 0 Then
                If str1.IndexOf("x") > 0 Then
                    arr = Split(str1, "x")
                    If myUtils.cValTN(myRow("LengthParamID")) > 0 Then str1 = arr(0).Trim & " x " & strLPID Else str1 = strTPID & " x " & arr(1).Trim
                ElseIf str1.IndexOf("X") > 0 Then
                    arr = Split(str1, "X")
                    If myUtils.cValTN(myRow("LengthParamID")) > 0 Then str1 = arr(0).Trim & " x " & strLPID Else str1 = strTPID & " x " & arr(1).Trim
                Else
                    If myUtils.cValTN(myRow("ThreadParamID")) > 0 Then str1 = strTPID
                End If
            End If
            myRow("specification") = str1

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                Me.CalcWeight()
                If myBOM.List.SaveItem(myRow.Row) Then
                    frmIDX = myRow("drgitemid")
                    frmMode = EnumfrmMode.acEditM

                    sql = "select * from drgitembom where drgitemid = " & frmIDX
                    dt = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                    myUtils.DeleteRows(dt.Select)
                    For Each drv As DataRowView In myView.MainGrid.myDV
                        If myUtils.cValTN(drv.Row("qty")) > 0 Then
                            Dim r1 As DataRow = myUtils.CopyOneRow(drv.Row, dt)
                            r1("drgitemid") = frmIDX
                        End If
                    Next
                    myContext.Provider.objSQLHelper.SaveResults(dt, sql)

                    myUtils.DeleteRows(dtReq.Select)
                    myUtils.CopyRows(myViewParamReq.MainGrid.myDS.Tables("ParamReq").Select(myViewParamReq.MainGrid.myDV.RowFilter), dtReq)
                    myUtils.ChangeAll(dtReq.Select, "drgitemid=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dtReq, "select * from drgitemparam where drgitemparamid = 0")

                    Dim oTree As clsTreeModel = myBOM.HandleCalc(myRow.Row, rDocu, Nothing, myFuncsPB.BuildBOMTree, Me.sqlForm)
                    VSave = True
                    myContext.Provider.dbConn.CommitTransaction()
                End If

            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function

    Private Function GetColText(Value As String, dt As DataTable, LookUpCol As String, RetCol As String) As String
        Dim rr() As DataRow = dt.Select("" & LookUpCol & " = '" & Value & "'")
        If rr.Length > 0 Then
            Return rr(0)(RetCol)
        Else
            Return ""
        End If
    End Function

    Private Sub CalcWeight()
        Dim r As DataRow, wt As Decimal = 0
        For Each r In myView.MainGrid.myDS.Tables("DrgItemBOM").Select
            r("weight") = myUtils.cValTN(r("wtperno"))
            wt = wt + myUtils.cValTN(r("wtperno")) * myUtils.cValTN(r("qty"))
        Next
        If myUtils.NullNot(myRow("stddrgid")) Then
            myRow("weight") = wt * myUtils.cValTN(myRow("qty"))
        Else
            myRow("weight") = wt
        End If
    End Sub
End Class
