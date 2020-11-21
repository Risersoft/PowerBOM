Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmItemCollec
    Inherits frmMax
    Dim ColumnList As List(Of String)

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Items"))
            myView.mainGrid.HighlightRows()
            myWinSQL.AssignCmb(Me.dsCombo, "SubCat", "", Me.combosubcat)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmItemCollecModel = Me.InitData("frmItemCollecModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If Not myUtils.NullNot(myRow("StdDrgId")) Then
                Me.Panel1.Visible = False
                Me.chk_IsDeleted.Visible = True
            ElseIf Not myUtils.NullNot(myRow("ProDocuId")) Then
                Me.Panel1.Visible = True
                Me.chk_IsDeleted.Visible = False
            End If

            Me.combosubcat.Value = DBNull.Value
            myRow("haslegend") = myUtils.cBoolTN(myRow("haslegend"))
            Me.chk_HasLegend.Checked = myUtils.cBoolTN(myRow("haslegend"))

            If frmMode = EnumfrmMode.acEditM Then
                Dim dt As DataTable = myView.mainGrid.myDS.Tables(0)
                If dt.Select("subcatid>0").Length > 0 Then Me.combosubcat.Value = dt.Select("subcatid>0")(0)("subcatid")
            End If
            SetItemGrid(myUtils.cValTN(myRow("itemid")))

            FormPrepared = True

            myRow("itemcollectypecode") = 2
            If frmMode = EnumfrmMode.acAddM AndAlso Me.combosubcat.Rows.Count > 0 Then Me.combosubcat.Rows(0).Selected = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim sumarea As Decimal = 0
        Dim str1, strQty As String, indiQty As Boolean
        Dim laststr1row, str1Row As String

        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.Panel1.Visible AndAlso Me.txt_Qty.Text.Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Qty, "Please enter Qty")
            If myUtils.NullNot(Me.combosubcat.Value) Then WinFormUtils.AddError(Me.combosubcat, "Select Sub Category")
            If Me.CanSave Then
                cm.EndCurrentEdit()
                myRow("itemid") = DBNull.Value
                If (Not Me.Panel1.Visible) AndAlso myUtils.cValTN(myRow("Qty")) = 0 Then myRow("Qty") = 1 'for weight calculation
                str1 = ""
                If myUtils.MaxVal(myView.mainGrid.myDS.Tables(0).Select("sysincl=1"), "Qty") > 1 Then indiQty = True Else indiQty = False
                If indiQty Then strQty = "" Else strQty = " (Qty - 1 Each)"
                laststr1row = ""        'reference label drawing for RTCC s022008-61
                For Each gr As UltraGridRow In myView.mainGrid.myGrid.Rows
                    If myUtils.cBoolTN(myWinUtils.DataRowFromGridRow(gr)("sysincl")) Then
                        str1Row = ""
                        'currently only yvalue is required for labels. In future, if this is changed
                        'or another sub category is added, we may have to have selection for what is included and what not.
                        For i As Integer = 1 To ColumnList.Count - 1
                            Dim str2 As String = ColumnList(i)
                            str1Row = str1Row & IIf(myView.mainGrid.myGrid.DisplayLayout.Bands(0).Columns(str2).Hidden, "", IIf(IsNumeric(gr.Cells(str2).Text), Format(myUtils.cValTN(gr.Cells(str2).Text), "#.#"), gr.Cells(str2).Text))
                            Exit For
                        Next
                        myWinUtils.DataRowFromGridRow(gr)("specbom") = myUtils.cStrTN(Me.cmb_AttribValue.Text) & " - " & str1Row
                        If laststr1row.Trim.Length = 0 OrElse str1Row <> laststr1row Then str1 = str1 & IIf(str1 = "", " - ", " , ") & str1Row
                        laststr1row = str1Row
                        If indiQty Then strQty = strQty & IIf(strQty.Trim.Length > 0, " / ", "") & Format(gr.Cells("qty").Value, "0")
                    End If
                Next
                If indiQty Then strQty = " (Qty - " & strQty & ")"
                str1 = myUtils.cStrTN(Me.cmb_AttribValue.Text) & str1 & strQty
                myRow("specification") = str1
                If myUtils.cStrTN(Me.combosubcat.SelectedRow.Cells("drgbomname").Value).Trim.Length > 0 Then myRow("material") = Me.combosubcat.SelectedRow.Cells("drgbomname").Value Else myRow("material") = Me.combosubcat.SelectedRow.Cells("subcatname").Value
                If Me.SaveModel() Then
                    Me.DoRefresh = True
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub clearItems()
        myView.mainGrid.myDv.RowFilter = "0=1"
        Me.lblX.Visible = False
        Me.cmb_AttribValue.Visible = False
        Me.cmb_AttribValue.Items.Clear()
    End Sub

    Private Sub SetItemGrid(Optional ByVal itemid As Integer = 0)
        Dim str1 As String = "", str2 As String = "", r As DataRow
        Dim gRow As UltraGridRow, dt2 As DataTable

        If myUtils.cValTN(Me.combosubcat.Value) = 0 OrElse myUtils.NullNot(Me.combosubcat.SelectedRow) Then
            clearItems()
        Else
            myView.mainGrid.myDv.Sort = "itemcode"
            r = myWinUtils.DataRowFromGridRow(Me.combosubcat.SelectedRow)
            myUtils.ChangeAll(myView.mainGrid.myDS.Tables(0).Select("subcatid<>" & myUtils.cValTN(r("subcatid"))), "sysincl=0")
            If Not r Is Nothing Then ColumnList = myAttribBase.ColumnList(Me.Controller, myView.mainGrid.myDv.Table.DataSet.Tables("attrib"), "subcatid", r("subcatid"))

            If (Not r Is Nothing) AndAlso (Not ColumnList Is Nothing) AndAlso ColumnList.Count > 0 Then
                Dim attributeid As Integer = myView.mainGrid.myDv.Table.DataSet.Tables("attrib").Columns(ColumnList(0)).ExtendedProperties("attributeid")
                Dim rAtt As DataRow = myAttribBase.rAttrib(Me.Controller, attributeid)
                Me.lblX.Text = myUtils.cStrTN(rAtt("attribname"))
                Me.lblX.Visible = True
                Me.cmb_AttribValue.Visible = True
                Me.cmb_AttribValue.Items.Clear()
                If myUtils.cStrTN(rAtt("valuelistxml")).Trim.Length > 0 Then
                    dt2 = myXMLUtils.PrepValueListDT(rAtt("valuelistxml"), "VALUE1")
                    Me.cmb_AttribValue.ValueList = myWinSQL2.VListFromTable(dt2).ComboList
                End If
                If Me.cmb_AttribValue.Items.Count > 0 Then Me.cmb_AttribValue.Value = Me.cmb_AttribValue.Items(0).DataValue
                If frmMode = EnumfrmMode.acEditM AndAlso myView.mainGrid.myDS.Tables(0).Select("sysincl=1 and " & ColumnList(0) & ">0").Length > 0 Then Me.cmb_AttribValue.Value = myView.mainGrid.myDS.Tables(0).Select("sysincl=1 and " & ColumnList(0) & ">0")(0)(ColumnList(0))
            Else
                Me.lblX.Visible = False
                Me.cmb_AttribValue.Visible = False
                Me.cmb_AttribValue.Items.Clear()
            End If

            str1 = myAttribBase.ParamWidthString(Me.Controller, myView.mainGrid.myDv.Table.DataSet.Tables("attrib"), "subcatid", r("subcatid"))
            If Me.chk_HasLegend.Checked Then myView.mainGrid.MainConf("HIDECOLS") = "" Else myView.mainGrid.MainConf("HIDECOLS") = "legend"
            myView.mainGrid.MainConf("SORTCOLSASC") = myUtils.MakeCSV(ColumnList, ",")
            myView.mainGrid.QuickConf("", True, "1-0-4-1" & str1, True, , , myView.Model.MainGrid.dvTableIndex)
            myView.mainGrid.PrepEdit()

            If itemid > 0 Then gRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "itemid", itemid, True)
            If gRow Is Nothing Then gRow = myView.mainGrid.myGrid.GetRow(ChildRow.First)
            If Not gRow Is Nothing Then
                myView.mainGrid.myGrid.ActiveRow = gRow
                gRow.Selected = True
            End If
            SetFilters()
        End If
    End Sub

    Private Sub cmb_pValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_AttribValue.ValueChanged
        If Me.FormPrepared Then SetFilters()
    End Sub

    Private Sub SetFilters()
        If Not myView.mainGrid.myDv Is Nothing Then
            Dim str1 As String = "subcatid=" & myUtils.cValTN(Me.combosubcat.Value), str2 As String = ""
            If (Not ColumnList Is Nothing) AndAlso ColumnList.Count > 0 AndAlso Me.cmb_AttribValue.Items.Count > 0 AndAlso myUtils.cValTN(Me.cmb_AttribValue.Value) > 0 Then str2 = ColumnList(0) & "=" & Me.cmb_AttribValue.Value
            myView.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, str1, str2)
        End If
    End Sub

    Private Sub combosubcat_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combosubcat.ValueChanged
        If Me.FormPrepared Then SetItemGrid()
    End Sub

    Private Sub chk_HasLegend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_HasLegend.CheckedChanged
        If Me.FormPrepared Then SetItemGrid()
    End Sub
End Class

