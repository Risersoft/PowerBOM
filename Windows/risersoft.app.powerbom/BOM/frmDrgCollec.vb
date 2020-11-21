Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto
Public Class frmDrgCollec
    Inherits frmMax
    Dim rDocu As DataRow, dirtyBOM As Boolean, myViewParam, myViewSpecCNC As New clsWinView

    Public Sub initForm()
        myView.SetTree(Me.UltraTree1)
        myView.SetGrid(Me.UltraGrid1)
        myViewParam.SetGrid(Me.UltraGrid2)
        myViewSpecCNC.SetGrid(Me.UltraGrid3)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControl1.Tabs("bom").Visible = False
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Items"))
            myView.mainGrid.HighlightRows()
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Clear()
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("sysincl", True, False)
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("itemnum", False, False)

            myViewParam.PrepEdit(Me.Model.GridViews("Param"))
            myViewSpecCNC.PrepEdit(Me.Model.GridViews("SpecCNC"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmDrgCollecModel = Me.InitData("frmDrgCollecModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            dirtyBOM = False
            If myUtils.cValTN(myRow("stddrgid")) > 0 Then
                Me.PanelQty.Visible = False
                Me.UltraTabControl1.Tabs("params").Visible = True
                Me.UltraTabControl1.Tabs("cnc").Visible = False
                FilterParams()
            ElseIf myUtils.cValTN(myRow("prodocuid")) > 0 Then
                Dim oret As clsProcOutput = Me.GenerateIDOutput("prodocuinfo", myUtils.cValTN(myRow("prodocuid")))
                If oret.Success Then
                    rDocu = oret.Data.Tables(0).Rows(0)
                End If

                Me.PanelQty.Visible = True
                Me.UltraTabControl1.Tabs("params").Visible = False
                Me.UltraTabControl1.Tabs("cnc").Visible = True
            End If
            If frmMode = EnumfrmMode.acEditM Then dirtyBOM = True
            Me.OnFrmModeChanged(frmMode)
            Me.UltraTabControl1.Tabs(0).Selected = True
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub FilterParams()
        Dim dt1 As DataTable, r As DataRow, str1, str2 As String
        dt1 = Me.Model.DatasetCollection("ParamReq").Tables("Param").Clone
        myView.mainGrid.myGrid.UpdateData()
        str2 = ""
        For Each r In myView.mainGrid.myDS.Tables(0).Select("sysincl=1")
            For Each r2 As DataRow In Me.Model.DatasetCollection("ParamReq").Tables("Req").Select("drgitemid=" & myUtils.cValTN(r("childdrgitemid")))
                myUtils.CopyOneRow(r2, dt1)
                If myUtils.cValTN(r2("stddrgparamid2")) > 0 Then str2 = str2 & "," & myUtils.cValTN(r2("stddrgparamid2"))
            Next
            If myUtils.cValTN(r("qtyparamid")) > 0 Then myUtils.CopyRows(myParams.GiveCalledVars(myUtils.cValTN(r("qtyparamid")), Me.Model.DatasetCollection("ParamReq").Tables("Param"), "paramname", "stddrgparamid"), dt1, , False)
        Next
        str1 = myUtils.MakeCSV(myWinData.SelectDistinct(dt1, "stddrgparamid", True).Select, "stddrgparamid")
        myViewParam.mainGrid.myDv.RowFilter = "stddrgparamid in (" & str1 & str2 & ")"
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                myView.myTreeWin.BindModel(Me.Model.GridViews("Items").MainTree)
                dirtyBOM = False
                Me.DoRefresh = True
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraGrid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGrid1.AfterCellUpdate
        If myUtils.cValTN(myRow("stddrgid")) > 0 Then FilterParams()
    End Sub

    Private Sub btnSelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelAll.Click
        myUtils.ChangeAll(myView.mainGrid.myDS.Tables(0).Select, "sysincl=1")
        myView.mainGrid.HighlightRows()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        myUtils.ChangeAll(myView.mainGrid.myDS.Tables(0).Select, "sysincl=0")
        myView.mainGrid.HighlightRows()
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

    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        Me.UltraTabControl1.Tabs("bom").Visible = (value = EnumfrmMode.acEditM AndAlso (Not rDocu Is Nothing))
    End Sub
End Class
