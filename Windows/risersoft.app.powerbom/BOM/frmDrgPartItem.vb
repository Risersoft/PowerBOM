Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmDrgPartItem
    Inherits frmMax
    Dim strDirec As String, paramcmb() As UltraCombo
    Dim myViewParamReq, myViewParamUser As New clsWinView
    Dim showreduction As Boolean = False, myBOM As New clsBOM(Me.Controller)

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        myView.SetTree(Me.UltraTree1)
        myViewParamReq.SetGrid(Me.UltraGrid2)
        myViewParamUser.SetGrid(Me.UltraGrid3)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        paramcmb = New UltraCombo() {Me.cmb_InnerDiaParamID, Me.cmb_Length2ParamID, Me.cmb_LengthParamID, Me.cmb_OuterDiaParamID, Me.cmb_ThkParamID, Me.cmb_Width2ParamID, Me.cmb_WidthParamID}
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "SubCat", "", Me.combosubcat)
            Me.cmb_GasketTypeCode.ValueList = Me.Model.ValueLists("GasketTypeCode").ComboList
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String, dt As DataTable, rr() As DataRow
        Me.FormPrepared = False
        strDirec = ""
        Dim objModel As frmDrgPartItemModel = Me.InitData("frmDrgPartItemModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If Not myUtils.NullNot(myRow("stddrgid")) Then
                Me.Panel1.Visible = False
                Me.lblWeight.Text = "Weight Each"
                Me.chk_IsDeleted.Visible = True
                Me.UltraTabControl1.Tabs("param").Visible = True
            ElseIf Not myUtils.NullNot(myRow("prodocuid")) Then
                Me.Panel1.Visible = True
                Me.lblWeight.Text = "Weight"
                Me.chk_IsDeleted.Visible = False
                Me.UltraTabControl1.Tabs("param").Visible = False
            End If

            strDirec = myUtils.cStrTN(myWinSQL2.ParamValue("@strDirec", Me.Model.ModelParams))
            If strDirec.Trim.Length > 0 Then
                For Each cmb As UltraCombo In paramcmb
                    If myUtils.NullNot(myRow("stddrgid")) Then
                        cmb.Visible = False
                    Else
                        cmb.Visible = True
                        myWinSQL.AssignCmb(Me.dsCombo, "param", "", cmb)
                        cmb.Value = myRow(cmb.DataBindings(0).BindingMemberInfo.BindingField)
                        AddHandler cmb.ValueChanged, AddressOf cmb_ValueChanged
                    End If
                Next

                If frmMode = EnumfrmMode.acEditM AndAlso myUtils.cValTN(myRow("outerdia")) > 0 Then
                    Me.utcDimType.Tabs("od").Selected = True
                Else
                    Me.utcDimType.Tabs("len").Selected = True
                End If

                myView.PrepEdit(Me.Model.GridViews("Items"))
                myViewParamReq.PrepEdit(Me.Model.GridViews("ParamReq"))
                myViewParamUser.PrepEdit(Me.Model.GridViews("ParamUser"))
                myViewParamUser.mainGrid.HighlightRows()
                myWinData.TickIncludedCols(myViewParamUser.mainGrid.myDS.Tables("ParamUser"), myUtils.CloneAndCopyRows(dsForm.Tables("Req"), "isuser=1", ""), "StdDrgParamId")

                Me.combosubcat.Value = DBNull.Value
                Me.chk_ShowNonStd.Checked = False
                If frmMode = EnumfrmMode.acEditM Then
                    dt = myView.mainGrid.myDS.Tables(0)
                    rr = dt.Select("itemid=" & myUtils.cValTN(myRow("itemid")))
                    If rr.Length > 0 Then Me.combosubcat.Value = rr(0)("subcatid")
                    Me.btnOpen.Enabled = True
                    Me.chk_ShowNonStd.Checked = myUtils.cBoolTN(myRow("shownonstd"))
                Else
                    Me.btnOpen.Enabled = False
                End If

                If myUtils.NullNot(myRow("gaskettypecode")) Then myRow("gaskettypecode") = 0

                Me.chk_IsManualWt.Checked = myUtils.cBoolTN(myRow("ismanualwt"))
                SetWt(Me.chk_IsManualWt.Checked)
                SetItemGrid(myUtils.cValTN(myRow("itemid")))

                If myUtils.cStrTN(myRow("rectreducexml")).Trim.Length > 0 Then
                    Me.CtlXMLVList1.InitVList(myUtils.cStrTN(myRow("rectreducexml")), "", "", , IIf(myUtils.NullNot(myRow("stddrgid")), "3-3-1-3", "3-3-3-3-1-3-3"))
                Else
                    If myUtils.NullNot(myRow("stddrgid")) Then
                        Me.CtlXMLVList1.InitVList("<VALUE LENGTH=""1"" WIDTH=""1"" QTY=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-3-1-3")
                    Else
                        Me.CtlXMLVList1.InitVList("<VALUE LENGTH=""1"" LENGTHPARAMID=""1"" WIDTH=""1"" WIDTHPARAMID=""1"" QTY=""1"" QTYPARAMID=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-3-3-3-1-3-3")
                    End If
                End If


                If myUtils.cStrTN(myRow("roundreducexml")).Trim.Length > 0 Then
                    Me.CtlXMLVList2.InitVList(myUtils.cStrTN(myRow("roundreducexml")), "", "", , IIf(myUtils.NullNot(myRow("stddrgid")), "3-1-3", "3-3-1-3-3"))
                Else
                    If myUtils.NullNot(myRow("stddrgid")) Then
                        Me.CtlXMLVList2.InitVList("<VALUE DIA=""1"" QTY=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-1-3")
                    Else
                        Me.CtlXMLVList2.InitVList("<VALUE DIA=""1"" DIAPARAMID=""1"" QTY=""1"" QTYPARAMID=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-3-1-3-3")
                    End If
                End If

                If myUtils.cStrTN(myRow("trianglereducexml")).Trim.Length > 0 Then
                    Me.CtlXMLVList3.InitVList(myUtils.cStrTN(myRow("trianglereducexml")), "", "", , IIf(myUtils.NullNot(myRow("stddrgid")), "3-3-1-3", "3-3-3-3-1-3-3"))
                Else
                    If myUtils.NullNot(myRow("stddrgid")) Then
                        Me.CtlXMLVList3.InitVList("<VALUE LENGTH=""1"" WIDTH=""1"" QTY=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-3-1-3")
                    Else
                        Me.CtlXMLVList3.InitVList("<VALUE LENGTH=""1"" LENGTHPARAMID=""1"" WIDTH=""1"" WIDTHPARAMID=""1"" QTY=""1"" QTYPARAMID=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-3-3-3-1-3-3")
                    End If

                End If

                If myUtils.cStrTN(myRow("radiusreducexml")).Trim.Length > 0 Then
                    Me.CtlXMLVList4.InitVList(myUtils.cStrTN(myRow("radiusreducexml")), "", "", , IIf(myUtils.NullNot(myRow("stddrgid")), "3-1-3", "3-3-1-3-3"))
                Else
                    If myUtils.NullNot(myRow("stddrgid")) Then
                        Me.CtlXMLVList4.InitVList("<VALUE RADIUS=""1"" QTY=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-1-3")
                    Else
                        Me.CtlXMLVList4.InitVList("<VALUE RADIUS=""1"" RADIUSPARAMID=""1"" QTY=""1"" QTYPARAMID=""1"" AREA=""1""/>", "", "", EmptyGridEnum.acLast, "3-3-1-3-3")
                    End If
                End If

                str1 = "<BAND INDEX=""0"">"
                For Each str2 As String In New String() {"Length", "Width", "Radius", "Dia", "Qty"}
                    str1 = str1 & "<COL KEY=""" & str2.Trim.ToUpper & "PARAMID"" CAPTION=""Var " & str2 & """ LOOKUPSQL=""select StdDrgParamId, paramname from stddrgparam where stddrgid = " & myUtils.cValTN(myRow("stddrgid")) & """/>"
                Next
                str1 = str1 & "</BAND>"

                For Each ctl As ctlXMLVList In New ctlXMLVList() {Me.CtlXMLVList1, Me.CtlXMLVList2, Me.CtlXMLVList3, Me.CtlXMLVList4}
                    ctl.myView.mainGrid.myGrid.DisplayLayout.Bands(0).Columns("AREA").CellActivation = Activation.NoEdit
                    If myUtils.cValTN(myRow("stddrgid")) > 0 Then ctl.myView.mainGrid.PrepEdit(str1, , , , EnumEditType.acEditOnly)
                Next
                CalcWeight(False)
                InitUpLoad()
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Private Function InitUpLoad()
        Dim str1, str2 As String

        For Each ctl As ctlUpLoad In New ctlUpLoad() {Me.CtlUpLoad1, Me.CtlUpLoad2, Me.CtlUpLoad3, Me.CtlUpLoad4, Me.CtlUpLoad5, Me.CtlUpLoad6}
            str1 = myWinFtp.ReplaceSpecialChars(Me.TextDrgNum.Text) & "_" & myRow("itemnum")
            If myUtils.cValTN(ctl.Tag) > 1 Then str1 = str1 & "." & ctl.Tag
            str1 = str1 & ".dxf"
            If myUtils.cValTN(ctl.Tag) > 1 Then str2 = myUtils.cStrTN(myRow("CNCDRG" & ctl.Tag)) Else str2 = myUtils.cStrTN(myRow("CNCDRG"))
            ctl.InitExt(frmMode, str1, str2, "", strDirec, "dxf", "pbom")
        Next
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.Panel1.Visible AndAlso Me.txt_Qty.Text.Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Qty, "Please enter Qty")
            If myView.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Select Item")
            If Me.utcReductions.Visible Then
                If myUtils.NullNot(myRow("stddrgid")) Then
                    Me.CtlXMLVList1.myView.mainGrid.CheckValid("length,width,qty", , , , Me.eBag)
                    Me.CtlXMLVList2.myView.mainGrid.CheckValid("dia,qty", , , , Me.eBag)
                    Me.CtlXMLVList3.myView.mainGrid.CheckValid("length,width,qty", , , , Me.eBag)
                    Me.CtlXMLVList4.myView.mainGrid.CheckValid("radius,qty")
                Else
                    Me.CtlXMLVList1.myView.mainGrid.CheckValid("", , , "<CHECK COND=""length&gt;0 or lengthparamid&gt;0"" MSG=""Enter Length or Parameter""/><CHECK COND=""width&gt;0 or widthparamid&gt;0"" MSG=""Enter Width or Parameter""/><CHECK COND=""qty&gt;0 or qtyparamid&gt;0"" MSG=""Enter Qty or parameter""/>", Me.eBag)
                    Me.CtlXMLVList2.myView.mainGrid.CheckValid("", , , "<CHECK COND=""dia&gt;0 or diaparamid&gt;0"" MSG=""Enter Dia or Parameter""/><CHECK COND=""qty&gt;0 or qtyparamid&gt;0"" MSG=""Enter Qty or parameter""/>", Me.eBag)
                    Me.CtlXMLVList3.myView.mainGrid.CheckValid("", , , "<CHECK COND=""length&gt;0 or lengthparamid&gt;0"" MSG=""Enter Length or Parameter""/><CHECK COND=""width&gt;0 or widthparamid&gt;0"" MSG=""Enter Width or Parameter""/><CHECK COND=""qty&gt;0 or qtyparamid&gt;0"" MSG=""Enter Qty or parameter""/>", Me.eBag)
                    Me.CtlXMLVList4.myView.mainGrid.CheckValid("", , , "<CHECK COND=""radius&gt;0 or radiusparamid&gt;0"" MSG=""Enter Radius or Parameter""/><CHECK COND=""qty&gt;0 or qtyparamid&gt;0"" MSG=""Enter Qty or parameter""/>", Me.eBag)
                End If
            Else
                myUtils.DeleteRows(Me.CtlXMLVList1.myView.mainGrid.myDS.Tables(0).Select)
                myUtils.DeleteRows(Me.CtlXMLVList2.myView.mainGrid.myDS.Tables(0).Select)
                myUtils.DeleteRows(Me.CtlXMLVList3.myView.mainGrid.myDS.Tables(0).Select)
                myUtils.DeleteRows(Me.CtlXMLVList4.myView.mainGrid.myDS.Tables(0).Select)
            End If

            For Each cmb As UltraCombo In paramcmb
                If cmb.SelectedRow Is Nothing Then cmb.Value = DBNull.Value
            Next

            If Me.CanSave Then
                myRow("cncdrg") = Me.CtlUpLoad1.FilePath
                myRow("cncdrg2") = Me.CtlUpLoad2.FilePath
                myRow("cncdrg3") = Me.CtlUpLoad3.FilePath
                myRow("cncdrg4") = Me.CtlUpLoad4.FilePath
                myRow("cncdrg5") = Me.CtlUpLoad5.FilePath
                myRow("cncdrg6") = Me.CtlUpLoad6.FilePath
                myRow("itemid") = myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("itemid").Value)
                If (Not Me.Panel1.Visible) AndAlso myUtils.cValTN(myRow("qty")) = 0 Then myRow("qty") = 1 'for weight calculation
                Me.CalcWeight()

                Dim r As DataRow = myWinUtils.DataRowFromGridRow(Me.combosubcat.SelectedRow)
                Select Case myUtils.cValTN(r("bomsectiontypecode"))
                    Case 0, 1           'thickness
                        If myUtils.cValTN(myRow("outerdia")) > 0 OrElse myUtils.cValTN(myRow("outerdiaparamid")) > 0 Then
                            If myUtils.cValTN(myRow("innerdia")) > 0 OrElse myUtils.cValTN(myRow("innerdiaparamid")) > 0 Then
                                myRow("specification") = IIf(myUtils.cValTN(myRow("thkparamid")) > 0, Me.cmb_ThkParamID.Text, Format(myUtils.cValTN(myRow("thk")), "0.###")) & " Thk x " & IIf(myUtils.cValTN(myRow("innerdiaparamid")) > 0, Me.cmb_InnerDiaParamID.Text, Format(myUtils.cValTN(myRow("innerdia")), "0.###")) & " ID x " & IIf(myUtils.cValTN(myRow("outerdiaparamid")) > 0, Me.cmb_OuterDiaParamID.Text, Format(myUtils.cValTN(myRow("outerdia")), "0.###")) & " OD"
                            Else
                                myRow("specification") = IIf(myUtils.cValTN(myRow("thkparamid")) > 0, Me.cmb_ThkParamID.Text, Format(myUtils.cValTN(myRow("thk")), "0.###")) & " Thk x " & IIf(myUtils.cValTN(myRow("outerdiaparamid")) > 0, Me.cmb_OuterDiaParamID.Text, Format(myUtils.cValTN(myRow("outerdia")), "0.###")) & " OD"
                            End If
                        Else
                            myRow("specification") = IIf(myUtils.cValTN(myRow("thkparamid")) > 0, Me.cmb_ThkParamID.Text, Format(myUtils.cValTN(myRow("thk")), "0.###")) & " Thk x " & IIf(myUtils.cValTN(myRow("widthparamid")) > 0, Me.cmb_WidthParamID.Text, Format(myUtils.cValTN(myRow("width")), "0.###")) & " x "
                            If myUtils.cValTN(myRow("gaskettypecode")) = 1 Then
                                myRow("specification") += "2*" & IIf(myUtils.cValTN(myRow("lengthparamid")) > 0, Me.cmb_LengthParamID.Text, Format(myUtils.cValTN(myRow("length")), "0.###")) & " + 2*" & IIf(myUtils.cValTN(myRow("length2paramid")) > 0, Me.cmb_Length2ParamID.Text, Format(myUtils.cValTN(myRow("length2")), "0.###")) & " Lg."
                            Else
                                myRow("specification") += IIf(myUtils.cValTN(myRow("lengthparamid")) > 0, Me.cmb_LengthParamID.Text, Format(myUtils.cValTN(myRow("length")), "0.###")) & " Lg."
                            End If
                        End If

                    Case 2          'section
                        If myUtils.cValTN(myRow("length")) > 0 Then
                            myRow("specification") = myRow("matsection") & " x " & Format(myUtils.cValTN(myRow("length")), "0.###") & " Lg"
                        ElseIf myUtils.cValTN(myRow("lenGTHparamid")) > 0 Then
                            myRow("specification") = myRow("matsection") & " x " & Me.cmb_LengthParamID.Text & " Lg"
                        End If
                    Case Else
                        myRow("specification") = myUtils.cStrTN(myRow("matsection"))

                End Select

                myRow("rectreducexml") = Me.CtlXMLVList1.ValueListXML
                myRow("roundreducexml") = Me.CtlXMLVList2.ValueListXML
                myRow("trianglereducexml") = Me.CtlXMLVList3.ValueListXML
                myRow("radiusreducexml") = Me.CtlXMLVList4.ValueListXML
                myRow("material") = DBNull.Value
                cm.EndCurrentEdit()

                Dim cont As Boolean = True
                Dim oRet As clsProcOutput = myBOM.List.CheckItem(myRow.Row)
                If Not oRet.Success Then
                    cont = (MsgBox(oRet.Message, MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes)
                End If
                If cont Then
                    If Me.SaveModel() Then
                        myView.myTreeWin.BindModel(Me.Model.GridViews("Items").MainTree)
                        Me.btnOpen.Enabled = True
                        InitUpLoad()
                        Me.DoRefresh = True
                        Return True
                    End If
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub clearItems()
        myView.mainGrid.myDv.RowFilter = "0=1"
        Me.txt_Density.Text = ""
        Me.txt_Thk.Text = ""
        Me.txt_MatSection.Text = ""
        Me.txt_WtPerMtr.Text = ""
        Me.txt_AreaPerMtr.Text = ""
        Me.txt_TotAreaRemoved.Text = ""
        Me.txt_CalcWeightEach.Text = ""
        Me.PanelChart.Visible = False
        Me.utcDimLenWid.Tabs(0).Selected = True
    End Sub

    Private Sub SetItemGrid(Optional ByVal itemid As Integer = 0)
        Dim str1 As String = "", str2 As String = "", r As DataRow, strf As String
        Dim gRow As UltraGridRow = Nothing

        If myUtils.cValTN(Me.combosubcat.Value) = 0 OrElse myUtils.NullNot(Me.combosubcat.SelectedRow) Then
            clearItems()
        Else
            myView.mainGrid.myDv.Sort = "itemcode"
            r = myWinUtils.DataRowFromGridRow(Me.combosubcat.SelectedRow)

            If myUtils.cBoolTN(r("bomsepcharts")) Then Me.PanelChart.Visible = True Else Me.PanelChart.Visible = False
            str1 = myAttribBase.ParamWidthString(Me.Controller, myView.mainGrid.myDv.Table.DataSet.Tables("attrib"), "subcatid", r("subcatid"))
            myView.mainGrid.QuickConf("", True, "0-4" & str1, True)
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Clear()
            If Me.chk_ShowNonStd.Checked Then strf = "" Else strf = "isnull(bomnonstd,0)=0"
            strf = myUtils.CombineWhere(False, "subcatid=" & myUtils.cValTN(Me.combosubcat.Value), strf)
            Select Case myUtils.cValTN(r("bomsectiontypecode"))
                'Case 0 'item not defined

                Case 0, 1
                    Me.utcDimType.Visible = True
                    myView.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, "isnull(bomthk,0)>0", strf)
                    Me.utcDimType.Tabs("od").Visible = True
                    Me.LabelWidth.Visible = True
                    Me.txt_Width.Visible = True
                    myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("bomthk", False, False)
                    If myUtils.cBoolTN(r("isgasket")) Then
                        Me.utcDimLenWid.Tabs(1).Selected = True
                        showreduction = False     'area reductions not required
                    Else
                        Me.utcDimLenWid.Tabs(0).Selected = True
                        showreduction = True
                    End If
                    Me.utcSectionType.Tabs("thk").Visible = True
                    Me.utcSectionType.Tabs("section").Visible = False
                    Me.utcSectionType.Tabs("varthk").Visible = Not myUtils.NullNot(myRow("stddrgid"))
                    Me.chk_HasNoJoints.Visible = True
                    Me.chk_NoCommonCut.Visible = True
                Case 2
                    Me.utcDimType.Visible = True
                    myView.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, "isnull(wtpermtr,0)>0", strf)
                    Me.utcSectionType.Tabs("thk").Visible = False
                    Me.utcSectionType.Tabs("varthk").Visible = False
                    Me.utcSectionType.Tabs("section").Visible = True
                    Me.LabelSectionWt.Text = "Weight / Mtr"
                    showreduction = False
                    Me.utcDimType.Tabs("od").Visible = False
                    Me.utcDimLenWid.Tabs(0).Selected = True
                    Me.LabelWidth.Visible = False
                    Me.txt_Width.Visible = False
                    Me.cmb_WidthParamID.Visible = False
                    myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("wtpermtr", False, False)
                    Me.chk_HasNoJoints.Visible = False
                    Me.chk_NoCommonCut.Visible = False
                Case 3
                    myView.mainGrid.myDv.RowFilter = myUtils.CombineWhere(False, "isnull(wtperno,0)>0", strf)
                    Me.utcDimType.Visible = False
                    Me.utcSectionType.Tabs("thk").Visible = False
                    Me.utcSectionType.Tabs("varthk").Visible = False
                    Me.utcSectionType.Tabs("section").Visible = True
                    Me.LabelSectionWt.Text = "Weight / Piece"
                    myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("wtperno", False, False)
                    Me.chk_HasNoJoints.Visible = False
                    showreduction = False
                    Me.chk_NoCommonCut.Visible = False

            End Select

            If itemid > 0 Then gRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "itemid", itemid, True)
            'if itemid is not present, PowerBOM should warn user to select item.
            'If gRow Is Nothing Then gRow = myView.mainGrid.myGrid.GetRow(ug.ChildRow.First)
            If gRow Is Nothing Then
                myWinUtils.ClearActiveRow(myView.mainGrid.myGrid)
            Else
                myView.mainGrid.myGrid.ActiveRow = gRow
                gRow.Selected = True
            End If
            Me.utcReductions.Visible = showreduction
        End If
        SetWt(Me.chk_IsManualWt.Checked)
    End Sub

    Private Sub UltraGrid1_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGrid1.AfterSelectChange
        Dim r As DataRow
        If (Me.UltraGrid1.ActiveRow Is Nothing) OrElse (myUtils.NullNot(Me.combosubcat.SelectedRow)) Then
            'clear things up
        Else
            r = myWinUtils.DataRowFromGridRow(Me.combosubcat.SelectedRow)
            Me.txt_Density.Text = myUtils.cValTN(Me.UltraGrid1.ActiveRow.Cells("density").Value)
            Select Case myUtils.cValTN(r("bomsectiontypecode"))
                Case 1
                    Me.txt_Thk.Text = myUtils.cValTN(Me.UltraGrid1.ActiveRow.Cells("bomthk").Value)
                Case 2
                    Me.txt_MatSection.Text = myUtils.cStrTN(Me.UltraGrid1.ActiveRow.Cells("bommatsection").Value)
                    Me.txt_WtPerMtr.Text = myUtils.cValTN(Me.UltraGrid1.ActiveRow.Cells("wtpermtr").Value)
                    Me.txt_AreaPerMtr.Text = myUtils.cValTN(Me.UltraGrid1.ActiveRow.Cells("areapermtr").Value)
                Case 3
                    Me.txt_MatSection.Text = myUtils.cStrTN(Me.UltraGrid1.ActiveRow.Cells("bommatsection").Value)
                    Me.txt_WtPerMtr.Text = myUtils.cValTN(Me.UltraGrid1.ActiveRow.Cells("wtperno").Value)
            End Select
        End If
    End Sub

    Private Sub CalcWeight(Optional ByVal updatewt As Boolean = True)
        Dim r As DataRow, redarea As Decimal = 0, matarea As Decimal = 0
        If (myUtils.NullNot(Me.combosubcat.SelectedRow)) Then
            'clear things up
            clearItems()
        Else
            r = myWinUtils.DataRowFromGridRow(Me.combosubcat.SelectedRow)
            Select Case myUtils.cValTN(r("bomsectiontypecode"))
                Case 1
                    myRow("matsection") = DBNull.Value
                    If showreduction Then
                        Dim ctlv() As ctlXMLVList = New ctlXMLVList() {Me.CtlXMLVList1, Me.CtlXMLVList2, Me.CtlXMLVList3, Me.CtlXMLVList4}
                        For i As Integer = 1 To 4
                            Dim ctl As ctlXMLVList = ctlv(i - 1)
                            For Each r In ctl.myView.mainGrid.myDS.Tables(0).Select
                                r("areA") = myBOM.ReducArea(r, i)
                                redarea = redarea + r("area")
                            Next
                        Next
                        redarea = Math.Round(redarea, 3)
                    End If
                    Me.txt_TotAreaRemoved.Text = redarea

                    If Me.utcDimType.Tabs("od").Selected Then
                        myRow("length") = 0
                        myRow("width") = 0
                        myRow("length2") = 0
                        myRow("width2") = 0
                    Else
                        myRow("outerdia") = 0
                        myRow("innerdia") = 0
                    End If
                    matarea = myBOM.CalcMatArea(myRow.Row)
                    matarea = matarea - redarea
                    Me.txt_TotalArea.Text = matarea
                    myRow("totalarea") = matarea
                    Me.txt_CalcWeightEach.Text = Math.Round(matarea * myUtils.cValTN(myRow("thk")) * myUtils.cValTN(Me.txt_Density.Text) / (10 ^ 6), 2)
                Case 2
                    myRow("width") = 0
                    myRow("outerdia") = 0
                    myRow("innerdia") = 0
                    myRow("thk") = 0
                    Me.txt_CalcWeightEach.Text = Math.Round(myUtils.cValTN(Me.txt_WtPerMtr.Text) * myUtils.cValTN(myRow("length")) / 1000, 2)
                Case 3
                    myRow("width") = 0
                    myRow("outerdia") = 0
                    myRow("innerdia") = 0
                    myRow("thk") = 0
                    Me.txt_CalcWeightEach.Text = Math.Round(myUtils.cValTN(Me.txt_WtPerMtr.Text), 2)
            End Select
            If (Not Me.chk_IsManualWt.CheckState = CheckState.Checked) AndAlso (updatewt) Then
                If myUtils.NullNot(myRow("stddrgid")) Then
                    myRow("weight") = myUtils.cValTN(Me.txt_CalcWeightEach.Text) * myUtils.cValTN(myRow("qty"))
                Else
                    myRow("weight") = myUtils.cValTN(Me.txt_CalcWeightEach.Text)
                End If
            End If
            cm.Refresh()
        End If
    End Sub

    Private Sub combosubcat_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combosubcat.ValueChanged
        If Me.FormPrepared Then SetItemGrid()
    End Sub

    Private Sub SetWt(ByVal ismanual As Boolean)
        Me.txt_Weight.ReadOnly = Not ismanual
    End Sub

    Private Sub chk_IsManualWt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_IsManualWt.CheckedChanged
        SetWt(Me.chk_IsManualWt.CheckState = CheckState.Checked)
    End Sub

    Private Sub SetGasketType(ByVal gaskettypecode As Integer)
        If gaskettypecode = 1 Then
            Me.lbllen1.Text = "Length 1"
            Me.lbllen2.Text = "Length 2"
            Me.lblwid1.Text = "Width 1"
            Me.lblwid2.Text = "Width 2"
        Else
            Me.lbllen1.Text = "Length Outer"
            Me.lbllen2.Text = "Length Inner"
            Me.lblwid1.Text = "Width Outer"
            Me.lblwid2.Text = "Width Inner"
        End If
    End Sub

    Private Sub cmb_GasketTypeCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetGasketType(myUtils.cValTN(Me.cmb_GasketTypeCode.Value))
    End Sub

    Private Sub cmb_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.FormPrepared Then Me.SetFilters()
    End Sub

    Private Sub SetFilters()
        Dim dt As DataTable, r, nr As DataRow
        Dim str1 As String

        If Not myUtils.NullNot(myRow("stddrgid")) Then
            dt = New DataTable
            dt.Columns.Add("StdDrgParamId", GetType(Integer))
            For Each cmb As UltraCombo In paramcmb
                If myUtils.cValTN(cmb.Value) > 0 Then
                    nr = dt.NewRow
                    nr("StdDrgParamId") = cmb.Value
                    dt.Rows.Add(nr)
                    myUtils.CopyRows(myParams.GiveCalledVars(nr("StdDrgParamId"), Me.dsCombo.Tables("param").Copy, "paramname", "StdDrgParamId"), dt)
                End If
            Next
            For Each ctl As ctlXMLVList In New ctlXMLVList() {Me.CtlXMLVList1, Me.CtlXMLVList2, Me.CtlXMLVList3, Me.CtlXMLVList4}
                For Each r In ctl.myView.mainGrid.myDS.Tables(0).Select
                    For Each col As DataColumn In ctl.myView.mainGrid.myDS.Tables(0).Columns
                        If Microsoft.VisualBasic.Right(col.ColumnName, 7).Trim.ToLower = "paramid" Then
                            If myUtils.cValTN(r(col)) > 0 Then
                                nr = dt.NewRow
                                nr("StdDrgParamId") = r(col)
                                dt.Rows.Add(nr)
                                myUtils.CopyRows(myParams.GiveCalledVars(nr("StdDrgParamId"), Me.dsCombo.Tables("param").Copy, "paramname", "StdDrgParamId"), dt)
                            End If
                        End If
                    Next
                Next
            Next
            str1 = "(" & myUtils.MakeCSV(myWinData.SelectDistinct(dt, "StdDrgParamId", True).Select, "StdDrgParamId") & ")"
            myViewParamReq.mainGrid.myDv.RowFilter = "StdDrgParamId in " & str1
            myViewParamUser.mainGrid.myDv.RowFilter = "StdDrgParamId not in " & str1
            myViewParamUser.mainGrid.HighlightRows()
        End If
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim f As New frmDrgPartGen
        If f.PrepForm(pView, EnumfrmMode.acEditM, frmIDX) Then
            f.TextDrgNum.Text = Me.TextDrgNum.Text
            WinFormUtils.ButtonAction(Me.btnOK, True)
            WinFormUtils.ShowForm(f, Me.Modal, pView.fParent)
        End If
    End Sub

    Private Sub chk_ShowNonStd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_ShowNonStd.CheckedChanged
        If Me.FormPrepared Then SetItemGrid(myUtils.cValTN(myRow("itemid")))
    End Sub
End Class
