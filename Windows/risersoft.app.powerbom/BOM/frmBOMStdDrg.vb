Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.app.mxent
Imports risersoft.app.mxform.eto

Public Class frmBOMStdDrg
    Inherits frmMax
    Dim myViewDel As New clsWinView, fp As frmMax

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        myViewDel.SetGrid(Me.UltraGrid2)
        Me.Visible = True
        Me.TopLevel = False
        Me.Dock = DockStyle.Fill
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Item"))
            myViewDel.PrepEdit(Me.Model.GridViews("ItemDel"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmBOMStdDrgModel = Me.InitData("frmBOMStdDrgModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If (Not oview.fParentWin Is Nothing) AndAlso (Not oview.fParentWin.myRow Is Nothing) Then
                If prepMode = EnumfrmMode.acAddM Then Me.myRow = oview.fParentWin.myRow
                fp = oview.fParentWin
            End If

            If oview.fParentWin Is Nothing Then
                Dim str1 As String = "Parts list for " & myUtils.cStrTN(myRow("CompleteNum")) & " - " & myUtils.cStrTN(myRow("DrgName"))
                Me.btnPlace.Visible = True
            Else
                Me.btnPlace.Visible = False
            End If
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

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
        If frmMode = EnumfrmMode.acEditM Then
            Dim f As New frmDrgPartGen
            f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS STDDRGID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refresh", 0)
            End If
        End If
    End Sub

    Private Sub btnAddRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefStd.Click
        If frmMode = EnumfrmMode.acEditM Then
            Dim f As New frmDrgRefStd
            f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS STDDRGID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refresh", 0)
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim r As DataRow, f As frmMax
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            r = myUtils.DataRowFromGridRow(myView.ContextRow)
            f = myFuncs.GiveDrgItemForm(r)
            If TypeOf f Is frmDrgRefFile Then f = New frmDrgRefStd
            'f cannot be drg reference from file in a standard because its a standard!
            'ref 8-50000/D RTCC std drg hinge edit problem
            If (Not f Is Nothing) AndAlso f.GetRowLock(EnumfrmMode.acEditM, "drgitemid", r("DrgItemID"), True) Then
                If f.PrepForm(myView, EnumfrmMode.acEditM, r("drgitemid")) Then f.ShowDialog()
                Me.OperateBindModel("refreshall")
            End If
        End If
    End Sub

    Private Sub btnAddCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCollection.Click
        If frmMode = EnumfrmMode.acEditM Then
            Dim f As New frmDrgCollec
            f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS STDDRGID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refresh", 0)
            End If
        End If
    End Sub

    Private Sub btnAddPartItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPartItem.Click
        Dim f As New frmDrgPartItem
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS STDDRGID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refresh", 0)
            End If
        End If
    End Sub

    Private Sub btnAddHardware_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHardware.Click
        Dim f As New frmDrgHardware
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS STDDRGID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refresh", 0)
            End If
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                RefreshGrid(myView, "deletedrgitem", myUtils.cValTN(myView.ContextRow.CellValue("drgitemid")))
            End If
        End If
    End Sub

    Private Sub btnEditDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDel.Click
        myViewDel.ContextRow = myViewDel.mainGrid.ActiveRow
        If Not myViewDel.ContextRow Is Nothing Then
            If (Not myUtils.cBoolTN(myViewDel.ContextRow.CellValue("iscollection"))) AndAlso (Not myUtils.cValTN(myViewDel.ContextRow.CellValue("refdrgitemid")) > 0) Then
                Dim f As New frmDrgPart
                f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
                If f.PrepForm(myView, EnumfrmMode.acEditM, myViewDel.ContextRow.CellValue("drgitemid")) Then f.ShowDialog()
                Me.OperateBindModel("refreshall")
            End If
        End If
    End Sub

    Private Sub btnDelDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelDel.Click
        myViewDel.ContextRow = myViewDel.mainGrid.ActiveRow
        If Not myViewDel.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                RefreshGrid(myViewDel, "deletedrgitemdel", myUtils.cValTN(myViewDel.ContextRow.CellValue("drgitemid")))
            End If
        End If
    End Sub

    Private Sub btnAddItemCollec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItemCollec.Click
        Dim f As New frmItemCollec
        If frmMode = EnumfrmMode.acEditM Then
            f.TextDrgNum.Text = myUtils.cStrTN(myRow("completenum"))
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS STDDRGID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refresh", 0)
            End If
        End If
    End Sub

    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        Me.Panel1.Enabled = (value = EnumfrmMode.acEditM)
        Me.Panel9.Enabled = (value = EnumfrmMode.acEditM)
    End Sub

    Private Sub RefreshGrid(View As clsWinView, key As String, DrgItemID As Integer)
        Dim oRet As New clsProcOutput
        Dim Params1 As New List(Of clsSQLParam)
        Params1.Add(New clsSQLParam("@StdDrgId", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Params1.Add(New clsSQLParam("@DrgItemID", DrgItemID, GetType(Integer), False))
        oRet = Me.GenerateParamsOutput(key.Trim.ToLower, Params1)
        If oRet.Success Then
            Me.UpdateViewData(View, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnShiftUp_Click(sender As Object, e As EventArgs) Handles btnShiftUp.Click
        If MsgBox("Are you sure to continue ?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            RefreshGrid(myView, "shiftup", myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("drgitemid").Value))
        End If
    End Sub

    Private Sub btnMarkDel_Click(sender As Object, e As EventArgs) Handles btnMarkDel.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to mark as delete this item?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Me.Model.ClientParams.Clear()
                Me.Model.ClientParams.Add(New clsSQLParam("@DrgItemId", myUtils.cValTN(myView.ContextRow.CellValue("drgitemid")), GetType(Integer), False))
                Me.OperateBindModel("markasdelete")
            End If
        End If
    End Sub

    Private Sub btnMarkUnDel_Click(sender As Object, e As EventArgs) Handles btnMarkUnDel.Click
        myViewDel.ContextRow = myViewDel.mainGrid.ActiveRow
        If Not myViewDel.ContextRow Is Nothing Then
            If MsgBox("Are you sure you want to mark as un delete this item?", MsgBoxStyle.YesNoCancel, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Me.Model.ClientParams.Clear()
                Me.Model.ClientParams.Add(New clsSQLParam("@DrgItemId", myUtils.cValTN(myViewDel.ContextRow.CellValue("drgitemid")), GetType(Integer), False))
                Me.OperateBindModel("markasundelete")
            End If
        End If
    End Sub
End Class
