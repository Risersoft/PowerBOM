Imports Infragistics.Win.UltraWinGrid

Public Class frmTFNest1
    Inherits frmMax
    Implements IfWizMax
    Implements ITFSetup
    Public fTF As frmTFNest

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
    End Sub

    Public Overrides Function PrepFormRow(r As System.Data.DataRow) As Boolean
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myView.PrepEdit(NewModel.GridViews("TFNestReq"))
        myView.mainGrid.myGrid.UpdateMode = UpdateMode.OnCellChangeOrLostFocus
        myView.mainGrid.HighlightRows()
        myWinData.TickIncludedCols(myView.mainGrid.myDS.Tables(0), "select tfnestreqid from tfnestitems where tfnestid = " & fTF.frmIDX, "tfnestreqid")
        Return True
    End Function

    Public Overrides Function VSave() As Boolean
        myView.mainGrid.myGrid.UpdateData()
        If myUtils.cValTN(fTF.myRow("sheetwidth")) = 0 Then fTF.myRow("sheetwidth") = 2500
        If myUtils.cValTN(fTF.myRow("sheetlength")) = 0 Then fTF.myRow("sheetlength") = 6300
        If myUtils.cValTN(fTF.myRow("sheetqty")) = 0 Then fTF.myRow("sheetqty") = 5
        Return fTF.VSave
    End Function

    Public Function btnActionText() As String Implements IfWizMax.btnActionText
        If Not fTF.Panel1.Enabled Then Return "Make Changes" Else Return ""
    End Function

    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Return Me.VSave
    End Function

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput
    End Sub

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        Return True
    End Function

    Public Function ShowTabKeys() As System.Collections.ArrayList Implements IfWizMax.ShowTabKeys
    End Function

    Public Sub StartAction() Implements IfWizMax.StartAction
        fTF.DisableButtons()
        fTF.DoEnable(True)
        fTF.RestoreButtons()
    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction
    End Sub

    Public Function DoSetup() As Boolean Implements ITFSetup.DoSetup
        Return Me.PrepFormRow(fTF.myRow.Row)
    End Function
End Class
