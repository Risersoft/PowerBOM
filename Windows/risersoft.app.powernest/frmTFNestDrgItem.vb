Imports Infragistics.Win.UltraWinGrid

Public Class frmTFNestDrgItem
    Inherits frmMax

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim StdDrgId As Integer
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            Me.lblStdDrg.Text = ""
            If frmMode = EnumfrmMode.acEditM Then
                StdDrgId = myFuncs.DrgItemStdDrgID(myUtils.cValTN(myRow("DrgItemId")))
                Me.lblStdDrg.Text = myFuncs.StdDrgInfo(StdDrgId, "")
            Else
                StdDrgId = 0
            End If

            GenerateModel(myUtils.cValTN(StdDrgId))
            If frmMode = EnumfrmMode.acEditM Then
                Dim gRow As UltraGridRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "DrgItemId", myRow("DrgItemId"))
                If Not gRow Is Nothing Then
                    myView.mainGrid.myGrid.ActiveRow = gRow
                    gRow.Selected = True
                End If
            End If
            PrepForm = True
        End If
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError()
        If Me.txt_Qty.Text.Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Qty, "Please enter Qty")
        If myView.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Select Item")
        If Me.CanSave Then
            myRow("DrgItemId") = myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("DrgItemId").Value)
            Me.SaveSoftData()
            VSave = True
        End If
    End Function

    Private Sub btnMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMac.Click
        Dim fO As frmMax = pView.fParentWin
        Dim Params As New List(Of clsSQLParam)
        Dim rr() As DataRow = fO.AdvancedSelect("stddrg", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Me.lblStdDrg.Text = myUtils.cStrTN(rr(0)("CompleteNum")) & " - " & myUtils.cStrTN(rr(0)("DrgName"))
            GenerateModel(myUtils.cValTN(rr(0)("StdDrgId")))
        End If
    End Sub

    Private Sub GenerateModel(StdDrgId As Integer)
        Dim fO As frmMax = pView.fParentWin
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@StdDrgId", StdDrgId, GetType(Integer), False))
        Dim Model1 As clsViewModel = fO.GenerateParamsModel("drgitems", Params)
        myView.PrepEdit(Model1)
    End Sub
End Class
