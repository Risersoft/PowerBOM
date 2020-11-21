Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto

Public Class frmDrgRefStd
    Inherits frmMax
    Dim drgnum As String, myViewSpecCNC, myViewParam As New clsWinView, rDocu As DataRow, dirtyBOM As Boolean
    Dim dtParam, dtReqDrg, dtMyParams As DataTable, RefStdDrgId As Integer

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        myView.SetTree(Me.UltraTree1)
        myViewSpecCNC.SetGrid(Me.UltraGrid2)
        myViewParam.SetGrid(Me.UltraGrid3)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControl1.Tabs("bom").Visible = False
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("DrgItems"))
            myViewSpecCNC.PrepEdit(Me.Model.GridViews("SpecCNC"))
            myViewParam.PrepEdit(Me.Model.GridViews("Param"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim cont As Boolean = True
        dirtyBOM = False
        Me.FormPrepared = False
        Dim objModel As frmDrgRefStdModel = Me.InitData("frmDrgRefStdModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If Not myUtils.NullNot(myRow("StdDrgId")) Then
                Me.Panel3.Visible = False
                Me.UltraTabControl1.Tabs("cnc").Visible = False
            ElseIf Not myUtils.NullNot(myRow("ProDocuId")) Then
                Me.Panel3.Visible = True
                Dim oret As clsProcOutput = Me.GenerateIDOutput("prodocuinfo", myUtils.cValTN(myRow("ProDocuId")))
                If oret.Success Then
                    rDocu = oret.Data.Tables(0).Rows(0)
                End If
                Me.UltraTabControl1.Tabs("cnc").Visible = True
            Else
                cont = False
            End If

            If cont Then
                Me.lblStdDrg.Text = ""
                If frmMode = EnumfrmMode.acEditM Then
                    Dim oret1 As clsProcOutput = Me.GenerateIDOutput("stddrgrow", myRow("refdrgitemid"))
                    If oret1.Success Then
                        Dim r1 As DataRow = oret1.Data.Tables(0).Rows(0)
                        Me.lblStdDrg.Text = r1("completenum") & " - " & r1("drgname")
                        drgnum = r1("completenum")
                        RefStdDrgId = myUtils.cValTN(r1("stddrgid"))
                        ReCalc()
                    End If

                    If RefStdDrgId > 0 Then 'required for frmdrgreffile to be called
                        Dim gRow As UltraGridRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "drgitemid", myRow("refdrgitemid"))
                        If Not gRow Is Nothing Then
                            myView.mainGrid.myGrid.ActiveRow = gRow
                            gRow.Selected = True
                        End If
                    End If
                    dirtyBOM = True
                    Me.OnFrmModeChanged(frmMode)
                    Me.UltraTabControl1.Tabs(0).Selected = True
                End If
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim str3 As String, r, rr() As DataRow
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If myView.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Select Item")
            If Me.CanSave Then
                cm.EndCurrentEdit()
                myRow("refdrgitemid") = myView.mainGrid.myGrid.ActiveRow.Cells("drgitemid").Value
                If Not myUtils.NullNot(myRow("prodocuid")) Then
                    myRow("weight") = myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("weight").Value) * myRow("qty")
                Else
                    myRow("weight") = myView.mainGrid.myGrid.ActiveRow.Cells("weight").Value
                End If

                str3 = ""
                myViewParam.mainGrid.myGrid.UpdateData()

                For Each dvr As DataRowView In myViewParam.mainGrid.myDv
                    r = dvr.Row
                    If Not myUtils.NullNot(r("paramvalue")) Then str3 = str3 & IIf(str3 = "", "", " , ") & r("paramname") & "=" & Format(r("paramvalue"), "0.###")
                    If Not myUtils.NullNot(r("stddrgparamid2")) Then
                        rr = dtMyParams.Select("stddrgparamid=" & r("stddrgparamid2"))
                        If rr.Length > 0 Then str3 = str3 & IIf(str3 = "", "", " , ") & r("paramname") & "=" & rr(0)("paramname")
                    End If

                Next
                If str3.Trim.Length > 0 Then str3 = " , " & str3

                If myUtils.cStrTN(myView.mainGrid.myGrid.ActiveRow.Cells("itemnum").Value).Trim = "901" Then
                    myRow("specification") = drgnum
                Else
                    myRow("specification") = drgnum & " - " & myView.mainGrid.myGrid.ActiveRow.Cells("itemnum").Value
                End If
                myRow("specification") = myRow("specification") & " " & str3 & " " & myRow("addlspec")
                If Me.SaveModel() Then
                    myView.myTreeWin.BindModel(Me.Model.GridViews("DrgItems").MainTree)
                    dirtyBOM = False
                    Me.DoRefresh = True
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMac.Click
        Dim Params As New List(Of clsSQLParam)
        Dim rr() As DataRow = Me.AdvancedSelect("stddrg", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            If rr(0)("stddrgid") = myUtils.cValTN(myRow("stddrgid")) Then
                MsgBox("Drawing cannot have reference to itself. Select another drawing", MsgBoxStyle.Exclamation, myWinApp.Vars("appname"))
            Else
                SetStdDrg(rr(0))
            End If
        End If
    End Sub

    Private Sub SetStdDrg(ByVal r As DataRow)
        Dim nr, rr(), r1 As DataRow, str1, str2 As String
        If (Not r Is Nothing) AndAlso (r.Table.Columns.Contains("stddrgid")) AndAlso (myUtils.cValTN(r("stddrgid"))) > 0 Then
            RefStdDrgId = myUtils.cValTN(r("stddrgid"))

            Me.lblStdDrg.Text = r("completenum") & " - " & r("drgname")
            drgnum = r("completenum")

            Dim params As New List(Of clsSQLParam)
            params.Add(New clsSQLParam("@DrgItemId", myUtils.cValTN(frmIDX), GetType(Integer), False))
            params.Add(New clsSQLParam("@RefStdDrgId", myUtils.cValTN(RefStdDrgId), GetType(Integer), False))
            params.Add(New clsSQLParam("@StdDrgId", myUtils.cValTN(myRow("stddrgid")), GetType(Integer), False))
            Dim Model As clsViewModel = Me.GenerateParamsModel("stddrgparam", params)
            Me.Model.GridViews.AddUpd("Param", Model)
            myViewParam.PrepEdit(Model)

            If (Not myView.mainGrid.myDS Is Nothing) AndAlso (myView.mainGrid.myDS.Tables.Count > 0) Then
                Dim params1 As New List(Of clsSQLParam)
                params1.Add(New clsSQLParam("@StdDrgId", myUtils.cValTN(RefStdDrgId), GetType(Integer), False))
                Dim Model1 As clsViewModel = Me.GenerateParamsModel("drgitems", params1)
                Me.Model.GridViews.AddUpd("DrgItems", Model1)
                myView.PrepEdit(Model1)
            End If
            ReCalc()
        End If
    End Sub

    Private Sub ReCalc()
        If Not myUtils.NullNot(myRow("stddrgid")) Then dtMyParams = CType(CType(myViewParam.mainGrid.myGrid.DisplayLayout.Bands(0).Columns("stddrgparamid2").ValueList, UltraDropDown).DataSource, DataView).Table
        Dim oret As clsProcOutput = Me.GenerateIDOutput("paramreqdrg", myUtils.cValTN(RefStdDrgId))
        If oret.Success Then
            dtParam = oret.Data.Tables("Param")
            dtReqDrg = oret.Data.Tables("ReqDrg")
        Else
            MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        If myView.mainGrid.myGrid.Selected.Rows.Count = 0 AndAlso myView.mainGrid.myGrid.Rows.Count > 0 Then myView.mainGrid.myGrid.Rows(0).Selected = True
    End Sub

    Private Sub UltraGrid1_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGrid1.AfterSelectChange
        Dim r, rr() As DataRow, str1 As String
        If myView.mainGrid.myGrid.Selected.Rows.Count > 0 Then
            myView.ContextRow = myView.mainGrid.SelectedRow
            Dim dt = dtParam.Clone
            myUtils.CopyRows(dtReqDrg.Select("paramvalue is null and drgitemid=" & myUtils.cValTN(myView.ContextRow.CellValue("drgitemid"))), dt)
            myViewParam.mainGrid.myDv.RowFilter = "stddrgparamid in (" & myUtils.MakeCSV(myWinData.SelectDistinct(dt, "stddrgparamid", True).Select, "stddrgparamid") & ")"
            dirtyBOM = True
        End If
    End Sub

    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        Me.UltraTabControl1.Tabs("bom").Visible = (value = EnumfrmMode.acEditM AndAlso (Not rDocu Is Nothing))
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanging(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangingEventArgs) Handles UltraTabControl1.SelectedTabChanging
        If Me.FormPrepared AndAlso frmMode = EnumfrmMode.acEditM AndAlso e.Tab.Key.ToLower = "bom" AndAlso dirtyBOM Then
            If Me.VSave Then
                'OK To change tab
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class
