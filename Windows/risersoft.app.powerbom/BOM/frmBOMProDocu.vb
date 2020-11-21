Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinTree
Imports System.ComponentModel
Imports risersoft.app.mxent
Imports risersoft.app.mxform.eto
Imports risersoft.app2.shared

Public Class frmBOMProDocu
    Inherits frmMax2
    Dim fp As frmMax, strCap As String
    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        Me.Visible = True
        Me.TopLevel = False
        Me.Dock = DockStyle.Fill
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmBOMProDocuModel = Me.InitData("frmBOMProDocuModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If (Not oview.fParentWin Is Nothing) AndAlso (Not oview.fParentWin.myRow Is Nothing) Then
                If prepMode = EnumfrmMode.acAddM Then Me.myRow = oview.fParentWin.myRow
                fp = oview.fParentWin
            End If

            strCap = "Parts List"
            If oview.fParentWin Is Nothing Then
                strCap = strCap & " for " & myUtils.cStrTN(myRow("Drawing")) & " - " & myUtils.cStrTN(myRow("Document"))
                Me.btnPlace.Visible = True
            Else
                Me.btnPlace.Visible = False
            End If

            Me.btnAddCollection.Visible = True
            Me.UpdateView()
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub UpdateView()
        Dim oret As clsProcOutput = GenerateIDOutput("drgitems", frmIDX)
        If oret.Success Then
            Dim ds As DataSet = oret.Data
            myRow("HasCollec") = (ds.Tables(0).Select("IsCollection=1").Length > 0)
            myView.mainGrid.BindView(ds)
            If myUtils.cBoolTN(myRow("HasCollec")) Then
                myView.mainGrid.QuickConf("", True, "1-0-0-2-5-2-0-2-1", True, strCap)
            Else
                myView.mainGrid.QuickConf("", True, "1-0-0-2-5-2-1-2-1", True, strCap)
            End If
        Else
            MsgBox(oret.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAddPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPart.Click
        Dim f As New frmDrgPartGen
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnAddRefStd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefStd.Click
        Dim f As New frmDrgRefStd
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnAddCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCollection.Click
        Dim f As New frmDrgCollec
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim r As DataRow, f As frmMax
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            r = myUtils.DataRowFromGridRow(myView.ContextRow)
            f = myFuncs.GiveDrgItemForm(r)
            If (Not f Is Nothing) AndAlso f.GetRowLock(EnumfrmMode.acEditM, "drgitemid", r("DrgItemID"), True) Then
                If f.PrepForm(myView, EnumfrmMode.acEditM, r("drgitemid")) Then f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnAddRefFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefFile.Click
        Dim f As New frmDrgRefFile
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim Params1 As New List(Of clsSQLParam)
                Params1.Add(New clsSQLParam("@ProDocuid", myUtils.cValTN(myRow.Row("ProDocuid")), GetType(Integer), False))
                Params1.Add(New clsSQLParam("@DrgItemID", myUtils.cValTN(myView.ContextRow.CellValue("DrgItemId")), GetType(Integer), False))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("delete", Params1)
                If oRet.Success Then
                    Me.UpdateView()
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        myFuncsPB.BOMCopyPDocuID = frmIDX
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaste.Click
        If frmMode = EnumfrmMode.acEditM AndAlso MsgBox("Pasting operation would avoid any items with item nos. already entered. " & vbCrLf & " CNC Drawings and collections will not be copied." & vbCrLf & "Document will automatically be processed after pasting operation is complete." & vbCrLf & " Continue ?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@BOMCopyPDocuID", myUtils.cValTN(myFuncsPB.BOMCopyPDocuID), GetType(Integer), False))
            Params.Add(New clsSQLParam("@ProDocuid", myUtils.cValTN(frmIDX), GetType(Integer), False))
            Dim oRet As clsProcOutput = Me.GenerateParamsOutput("btnpaste", Params)
            If Not oRet.Success Then
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
            Me.ProcessBOM()
        End If
    End Sub

    Private Sub btnAddPartItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPartItem.Click
        Dim f As New frmDrgPartItem
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnAddHardware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHardware.Click
        Dim f As New frmDrgHardware
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub btnAddItemCollec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItemCollec.Click
        Dim f As New frmItemCollec
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = Me.txt_Drawing.Text
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.UpdateView()
            End If
        End If
    End Sub

    Private Sub DisableButtons(enable As Boolean)
        Me.Panel1.Enabled = enable
        Me.Panel9.Enabled = enable
    End Sub

    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        Me.DisableButtons((value = EnumfrmMode.acEditM))
    End Sub

    Private Sub btnShiftUp_Click(sender As System.Object, e As System.EventArgs) Handles btnShiftUp.Click
        If MsgBox("Are you sure to continue ?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            Dim oRet As New clsProcOutput
            Dim Params1 As New List(Of clsSQLParam)
            Params1.Add(New clsSQLParam("@ProDocuid", myUtils.cValTN(frmIDX), GetType(Integer), False))
            Params1.Add(New clsSQLParam("@DrgItemID", myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("drgitemid").Value), GetType(Integer), False))
            oRet = Me.GenerateParamsOutput("shiftup", Params1)
            If oRet.Success Then
                Me.UpdateView()
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btnProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnProcess.Click
        If myWinApp.CheckLicense2 Then
            Me.ProcessBOM()
        End If
    End Sub

    Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
        If report.Percentage < Me.UltraProgressBar1.Maximum Then
            Me.UltraProgressBar1.Value = report.Percentage
        Else
            Me.UltraProgressBar1.Value = Me.UltraProgressBar1.Maximum
        End If

        Me.UltraProgressBar1.Text = myUtils.cStrTN(report.Message) & " ([Formatted])"
    End Sub

    Private Async Sub ProcessBOM()
        Me.DisableButtons(False)
        Me.UltraProgressBar1.Value = 0
        Me.UltraProgressBar1.Text = "[Formatted]"
        Me.UltraProgressBar1.Visible = True
        Await Me.GenerateIDOutputAsync("process", myUtils.cValTN(frmIDX), AddressOf ProgressChanged)
        Me.UltraProgressBar1.Visible = False
        Me.DisableButtons(True)
        Me.UpdateView()
    End Sub
End Class
