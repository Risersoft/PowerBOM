
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports Infragistics.Win.UltraWinEditors
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmDrgHardware
    Inherits frmMax
    Dim paramcmb() As UltraCombo
    Dim objInfo As New clsMMInfo(Me.Controller, 1)
    Dim myViewSubCat, myViewItems, myViewParamReq As New clsWinView

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        myViewSubCat.SetGrid(Me.UltraGrid2)
        myViewItems.SetGrid(Me.UltraGrid3)
        myViewParamReq.SetGrid(Me.UltraGrid5)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        paramcmb = New UltraCombo() {Me.cmb_LengthParamID, Me.cmb_ThreadParamID}
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("DrgItemBOM"))
            myViewSubCat.PrepEdit(Me.Model.GridViews("SubCat"))
            myViewItems.PrepEdit(Me.Model.GridViews("Items"))
            myViewParamReq.PrepEdit(Me.Model.GridViews("ParamReq"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String, dt, dt2 As DataTable, rr() As DataRow
        Dim pcmb As Infragistics.Win.UltraWinEditors.UltraComboEditor, lbl As System.Windows.Forms.Label

        Me.FormPrepared = False
        Dim objModel As frmDrgHardwareModel = Me.InitData("frmDrgHardwareModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            If Not myUtils.NullNot(myRow("stddrgid")) Then
                Me.Panel1.Visible = False
                Me.lblWeight.Text = "Weight Each"
                Me.UltraTabControl1.Tabs("param").Visible = True
                Me.chk_IsDeleted.Visible = True
            ElseIf Not myUtils.NullNot(myRow("prodocuid")) Then
                Me.Panel1.Visible = True
                Me.lblWeight.Text = "Weight"
                Me.UltraTabControl1.Tabs("param").Visible = False
                Me.chk_IsDeleted.Visible = False
            End If

            If (Not objInfo.dicSelectorAttrib Is Nothing) AndAlso (objInfo.dicSelectorAttrib.Count > 0) Then
                For Each cmb As UltraCombo In paramcmb
                    If myUtils.NullNot(myRow("stddrgid")) Then
                        cmb.Visible = False
                        Me.lblDiaParam.Visible = False
                        Me.lblLenParam.Visible = False
                    Else
                        cmb.Visible = True
                        myWinSQL.AssignCmb(Me.dsCombo, "param", "", cmb)
                        cmb.Value = myRow(cmb.DataBindings(0).BindingMemberInfo.BindingField)
                        Me.lblDiaParam.Visible = True
                        Me.lblLenParam.Visible = True
                        AddHandler cmb.ValueChanged, AddressOf cmb_ValueChanged
                    End If
                Next

                If frmMode = EnumfrmMode.acEditM Then
                    dt = myViewItems.mainGrid.myDS.Tables("Items")
                    rr = dt.Select("itemid=" & myUtils.cValTN(myRow("itemid")))
                End If

                Dim i As Integer = 0
                For Each str1 In New String() {"A", "B", "C", "D", "E"}
                    pcmb = WinFormUtils.getControlFromName("cmb_pvalue" & str1, Me.PanelParam)
                    lbl = WinFormUtils.getControlFromName("lblpname" & str1, Me.PanelParam)
                    AddHandler pcmb.ValueChanged, AddressOf cmb_pValue_ValueChanged
                    If objInfo.dicSelectorAttrib.Count > i Then
                        lbl.Text = myUtils.cStrTN(objInfo.dicSelectorAttrib()(i)("attribname"))
                        lbl.Visible = True
                        pcmb.Visible = True
                        pcmb.Items.Clear()
                        If myUtils.cStrTN(objInfo.dicSelectorAttrib()(i)("valuelistxml")).Trim.Length > 0 Then
                            dt2 = myXMLUtils.PrepValueListDT(objInfo.dicSelectorAttrib()(i)("valuelistxml"), "VALUE1")
                            If str1 = "C" Then myUtils.DeleteRows(dt2.Select("value1>20")) 'only screw / nut can be filtered on.
                            pcmb.ValueList = myWinSQL2.VListFromTable(dt2).ComboList
                        End If
                        If pcmb.Items.Count > 0 Then pcmb.Value = pcmb.Items(0).DataValue
                        If frmMode = EnumfrmMode.acEditM AndAlso rr.Length > 0 Then pcmb.Value = objInfo.SubCatValue(rr(0)("subcatid"), objInfo.dicSelectorAttrib()(i)("attributeid"))
                    Else
                        pcmb.Visible = False
                        lbl.Visible = False
                    End If
                    i = i + 1
                Next

                If frmMode = EnumfrmMode.acEditM AndAlso rr.Length > 0 Then SetSubCatGrid(rr(0)("subcatid")) Else SetSubCatGrid()
                SetItemGrid(myUtils.cValTN(myRow("itemid")))

                myRow("itemcollectypecode") = 1
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.Panel1.Visible AndAlso Me.txt_Qty.Text.Trim.Length = 0 Then WinFormUtils.AddError(txt_Qty, "Please enter Qty")
        If Me.CanSave Then
            If Me.ValidateData() Then
                myRow("itemid") = myUtils.cValTN(myViewItems.mainGrid.myGrid.ActiveRow.Cells("itemid").Value)
                Dim r1 As DataRow = myWinUtils.DataRowFromGridRow(myViewSubCat.mainGrid.myGrid.ActiveRow)
                myRow("material") = objInfo.SubCatText(r1("subcatid"), objInfo.dicSelectorAttrib()("hwmaterial")("Attributeid"))

                For Each gr In myView.mainGrid.myGrid.Rows
                    If gr.Cells("hwType").Value >= 31 AndAlso gr.Cells("hwType").Value < 41 Then
                        Me.updateElement(myWinUtils.DataRowFromGridRow(gr))
                    End If
                Next

                If (Not Me.Panel1.Visible) AndAlso myUtils.cValTN(myRow("qty")) = 0 Then myRow("qty") = 1 'for weight calculation
                If Me.SaveModel() Then
                    Me.DoRefresh = True
                    Return True
                End If
            Else
                Me.SetError()
            End If
        End If
        Me.Refresh()
    End Function

    Private Sub clearItems()
        myViewItems.mainGrid.myDv.RowFilter = "0=1"
        If Not myView.mainGrid.myDv Is Nothing Then myView.mainGrid.myDv.RowFilter = "0=1"
    End Sub

    Private Sub SetSubCatGrid(Optional ByVal subcatid As Integer = 0)
        Dim gRow As UltraGridRow, pcmb As UltraComboEditor
        Dim i As Integer = 0, dic As New clsCollecString(Of String)

        For Each str1 In New String() {"A", "B", "C", "D", "E"}
            pcmb = WinFormUtils.getControlFromName("cmb_pvalue" & str1, Me.PanelParam)
            If myUtils.cValTN(pcmb.Value) > 0 AndAlso objInfo.dicSelectorAttrib.Count > i Then
                dic.Add(objInfo.dicSelectorAttrib()(i)("attribcode"), CInt(myUtils.cValTN(pcmb.Value)))
            End If
            i = i + 1
        Next
        Dim str2 As String = "Subcatid in (" & objInfo.SubCatIDCSV(myViewSubCat.mainGrid.myDv.Table, dic) & ")"

        myViewSubCat.mainGrid.myDv.RowFilter = str2

        If subcatid > 0 Then gRow = myWinUtils.FindRow(myViewSubCat.mainGrid.myGrid, "subcatid", subcatid, True)
        If gRow Is Nothing Then gRow = myViewSubCat.mainGrid.myGrid.GetRow(ChildRow.First)
        If Not gRow Is Nothing Then
            myViewSubCat.mainGrid.myGrid.ActiveRow = gRow
            gRow.Selected = True
        Else
            clearItems()
        End If
    End Sub

    Private Sub SetItemGrid(Optional ByVal itemid As Integer = 0)
        Dim str1 As String = "", str2 As String = "", r As DataRow
        Dim gRow As UltraGridRow

        If myViewSubCat.mainGrid.myGrid.ActiveRow Is Nothing Then
            clearItems()
        Else
            gRow = myViewSubCat.mainGrid.myGrid.ActiveRow
            r = myWinUtils.DataRowFromGridRow(gRow)
            myViewItems.mainGrid.myDv.Sort = "itemcode"
            myViewItems.mainGrid.myDv.RowFilter = "subcatid = " & r("subcatid")

            str1 = myAttribBase.ParamWidthString(Me.Controller, myViewItems.mainGrid.myDv.Table.DataSet.Tables("attrib"), "subcatid", r("subcatid"))
            myViewItems.mainGrid.QuickConf("", True, "0-4" & str1, True)
            myViewItems.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Clear()

            gRow = Nothing
            If itemid > 0 Then gRow = myWinUtils.FindRow(myViewItems.mainGrid.myGrid, "itemid", itemid, True)
            If gRow Is Nothing Then gRow = myViewItems.mainGrid.myGrid.GetRow(ChildRow.First)
            If Not gRow Is Nothing Then
                myViewItems.mainGrid.myGrid.ActiveRow = gRow
                gRow.Selected = True
            End If
        End If
        SetHardWareGrid()
    End Sub

    Private Function GiveElementCode(ByVal hwType As Integer) As Integer
        Return Math.Floor(hwType / 10.0) * 10 + 1
    End Function

    Private Sub SetHardWareGrid()
        Dim r, nr, rr2() As DataRow, mode As Integer = 0
        Dim elementCode As Decimal, str2 As String = ""
        Dim strXML As String, dt2 As DataTable, addcvlist As Boolean = False

        If myView.mainGrid.myDS.Tables.Count > 0 Then
            If myViewSubCat.mainGrid.myGrid.ActiveRow Is Nothing Then
                mode = 0    'none shown
                str2 = "0=1"
            Else
                Dim subcatid As Integer = myViewSubCat.mainGrid.myGrid.ActiveRow.Cells("subcatid").Value
                elementCode = GiveElementCode(myUtils.cValTN(objInfo.SubCatValue(subcatid, objInfo.dicSelectorAttrib()("hwtype")("attributeid"))))
                If elementCode = 1 Then
                    mode = 1 'all elements shown
                Else
                    mode = 2 'only concerned element shown
                End If
            End If

            For Each i As Integer In New Integer() {1, 11, 21, 31, 41}
                rr2 = myView.mainGrid.myDS.Tables("DrgItemBOM").Select("hwType>=" & i & " AND hwType<=" & i + 9)
                If rr2.Length = 0 Then
                    nr = myView.mainGrid.myDS.Tables("DrgItemBOM").NewRow
                    nr("hwType") = i
                    nr("sortkey") = i
                    If i < 31 AndAlso frmMode = EnumfrmMode.acAddM Then nr("qty") = 1
                    nr.Table.Rows.Add(nr)
                    r = nr
                    If i = 31 Then addcvlist = True
                Else
                    r = rr2(0)
                End If
                If mode = 2 AndAlso elementCode = i Then
                    str2 = "hwType=" & i
                    r("qty") = 1
                Else
                    'Qty updation removed ref 8-50000/F hardware set without screw etc because stud has been called
                    'If i < 11 Then r("qty") = 1
                End If
            Next i
            myView.mainGrid.myDv.RowFilter = str2

            If mode = 1 AndAlso (Not objInfo Is Nothing) AndAlso (objInfo.dicSelectorAttrib.ContainsKey("hwtype")) Then
                dt2 = myXMLUtils.PrepValueListDT(objInfo.dicSelectorAttrib()("hwtype")("valuelistxml"), "VALUE1")
                myUtils.DeleteRows(dt2.Select("value1<31 or value1>40")) ''only locking element remains
                strXML = ""
                For Each r In dt2.Select
                    strXML = strXML & "<VALUE VALUE1=""" & r("value1") & """ TEXT=""" & r("text") & """/>"
                Next
                For Each gr As UltraGridRow In myView.mainGrid.myGrid.Rows
                    If gr.Cells("hwtype").Value >= 31 AndAlso gr.Cells("hwtype").Value < 41 Then
                        myWinUtils.PerCellVlist(myView.mainGrid, gr.Cells("hwtype"), myUtils.ProperXML(strXML), , False)
                    Else
                        gr.Cells("hwtype").Activation = Activation.NoEdit
                    End If
                    Me.updateElement(myWinUtils.DataRowFromGridRow(gr))     'when setting up grid (adding elements for first time), update for currently selected row in item grid
                Next
                myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Clear()

                myView.mainGrid.myGrid.DisplayLayout.Bands(0).InitGroupBySortMerge(myView.mainGrid.Model, myView.mainGrid.MainConf)
            End If
        End If
    End Sub

    Private Sub UltraGrid3_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGrid3.AfterSelectChange
        Dim r1, r2, r3 As DataRow, dt As DataTable
        If (Me.UltraGrid2.ActiveRow Is Nothing) OrElse (Me.UltraGrid3.ActiveRow Is Nothing) OrElse (myView.mainGrid.myDS.Tables.Count = 0) Then
            'clear things up
        Else
            For Each r2 In myView.mainGrid.myDS.Tables("DrgItemBOM").Select
                updateElement(r2)
            Next
        End If
    End Sub

    Private Sub updateElement(ByVal rElem As DataRow)
        Dim rMHItem As DataRow, rItem As DataRow, dt As DataTable

        dt = myViewItems.mainGrid.myDS.Tables("Items").Copy
        rMHItem = myUtils.DataRowFromGridRow(myViewItems.mainGrid.ActiveRow)
        Dim hwtype As Integer = myUtils.cValTN(objInfo.SubCatValue(rMHItem("subcatid"), objInfo.dicSelectorAttrib()("hwtype")("attributeid")))
        If GiveElementCode(myUtils.cValTN(rElem("hwType"))) = GiveElementCode(hwtype) Then
            rElem("hwType") = hwtype   'change to screw / stud / bolt as necessary
            rItem = rMHItem
        Else
            rItem = Me.rItem(rElem, rMHItem, dt)
        End If

        If Not rItem Is Nothing Then
            rElem("itemid") = rItem("itemid")
            rElem("bommatsection") = rItem("bommatsection")
            If myUtils.cStrTN(rElem("bommatsection")).Trim.Length = 0 Then rElem("bommatsection") = rItem("itemname")
            rElem("wtperno") = rItem("Wtperno")
        Else
            rElem("itemid") = DBNull.Value
            rElem("bommatsection") = DBNull.Value
            rElem("wtperno") = DBNull.Value
        End If
    End Sub

    Private Function rItem(ByVal rElem As DataRow, ByVal rMHItem As DataRow, ByVal dtItems As DataTable) As DataRow
        Dim gc As UltraGridColumn, rr(), r3 As DataRow
        Dim gRow As UltraGridRow, pcmb As UltraComboEditor
        Dim i As Integer = 0, dic As New clsCollecString(Of String)

        For Each str1 In New String() {"A", "B", "C", "D", "E"}
            pcmb = WinFormUtils.getControlFromName("cmb_pvalue" & str1, Me.PanelParam)
            If myUtils.cValTN(pcmb.Value) > 0 AndAlso objInfo.dicSelectorAttrib.Count > i Then
                Dim str3 As String = objInfo.dicSelectorAttrib()(i)("attribcode")
                If myView.mainGrid.myDS.Tables("DrgItemBOM").Columns.Contains(str3) Then
                    dic.Add(str3, myUtils.cValTN(rElem(str3)))
                Else
                    dic.Add(str3, myUtils.cValTN(objInfo.SubCatValue(rMHItem("subcatid"), objInfo.dicSelectorAttrib()(i)("attributeid"))))
                End If
            End If
            i = i + 1
        Next
        Dim str2 As String = "Subcatid in (" & objInfo.SubCatIDCSV(myViewSubCat.mainGrid.myDv.Table, dic) & ")"
        For Each str1 In New String() {"hard_thread", "hard_prop"}      'do not want string svalue
            gc = myViewItems.mainGrid.myGrid.DisplayLayout.Bands(0).Columns(str1)
            If (Not gc Is Nothing) AndAlso (Not gc.Hidden) Then
                str2 = myUtils.CombineWhere(False, str2, str1 & IIf(str1 = "hard_prop", " >= ", "=") & myUtils.cValTN(myViewItems.mainGrid.myGrid.ActiveRow.Cells(str1).Value))
                rr = dtItems.Select(str2)
                If rr.Length = 1 Then Exit For 'good for plain washer and spring washer where property class may not be required to filter in required washer
            End If
        Next
        If Not rr Is Nothing AndAlso rr.Length > 0 Then r3 = rr(0)
        Return r3
    End Function

    Private Sub UltraGrid2_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGrid2.AfterSelectChange
        If Me.FormPrepared Then SetItemGrid()
    End Sub

    Private Sub cmb_pValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.FormPrepared Then SetSubCatGrid()
    End Sub

    Private Sub cmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.FormPrepared Then Me.SetFilters()
    End Sub

    Private Sub SetFilters()
        Dim dt As DataTable, r, nr As DataRow
        Dim str1 As String

        If Not myUtils.NullNot(myRow("stddrgid")) Then
            dt = New DataTable
            dt.Columns.Add("stddrgparamid", GetType(Integer))
            For Each cmb As UltraCombo In paramcmb
                If myUtils.cValTN(cmb.Value) > 0 Then
                    nr = dt.NewRow
                    nr("stddrgparamid") = cmb.Value
                    dt.Rows.Add(nr)
                    myUtils.CopyRows(myParams.GiveCalledVars(nr("stddrgparamid"), Me.dsCombo.Tables("param").Copy, "paramname", "stddrgparamid"), dt)
                End If
            Next
            str1 = "(" & myUtils.MakeCSV(myWinData.SelectDistinct(dt, "stddrgparamid", True).Select, "stddrgparamid") & ")"
            myViewParamReq.mainGrid.myDv.RowFilter = "stddrgparamid in " & str1
        End If
    End Sub
End Class
