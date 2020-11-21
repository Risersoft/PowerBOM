Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.win
Imports risersoft.shared
Imports risersoft.app.shared

Public Class frmTFNest2
    Inherits frmMax
    Implements IfWizMax
    Dim strLastFilePart, strNewFilePart As String
    Public fTF As frmTFNest, f1 As frmMax

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid2)
        f1 = myWinApp.objAppExtender.fViewer2D
        f1.AddtoTab(Me.UltraTabControl2, "img", True)
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myView.PrepEdit(NewModel.GridViews("TFNestItems"))
        Return True
    End Function

    Public Overrides Function PrepFormRow(r As System.Data.DataRow) As Boolean
        Me.FormPrepared = False
        AddHandler myView.mainGrid.myGrid.AfterSelectChange, AddressOf UltraGrid2_AfterSelectChange
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Friend Sub ClosePartView()
        If CType(f1, IViewer).DetachRequiredOnClose Then f1.RemoveTab(Me)
        CType(f1, IViewer).CloseFile()
        myWinFtp.DeleteLocalFile(strLastFilePart)
    End Sub

    Private Async Sub UltraGrid2_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs)
        Dim gRow As UltraGridRow, newfile As Boolean = False
        strLastFilePart = strNewFilePart
        gRow = myView.mainGrid.myGrid.ActiveRow
        If Not gRow Is Nothing Then
            If myUtils.cStrTN(gRow.Cells("cncdrg").Value).Trim.Length > 0 Then
                strNewFilePart = Await fTF.oFiler.FileProvider.DownloadTempAsync(gRow.Cells("cncdrg").Value)
                CType(f1, IViewer).OpenFile(strNewFilePart)
                'Me.AxEModelViewControl1.OpenDoc(strNewFilePart, True, False, False, "")
                newfile = True
            End If
        End If
        'If Not newfile Then Me.AxEModelViewControl1.CloseActiveDoc("")
        If Not newfile Then CType(f1, IViewer).CloseFile()
        If myUtils.cStrTN(strLastFilePart).Trim.Length > 0 Then myWinFtp.DeleteLocalFile(strLastFilePart)
    End Sub

    Public Function btnActionText() As String Implements IfWizMax.btnActionText
        Return "Update Items"
    End Function

    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Return True
    End Function

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput
    End Sub

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        If Me.FormPrepared Then
            Me.ShowItems()
            Return True
        Else
            Return Me.PrepFormRow(fTF.myRow.Row)
        End If
    End Function

    Public Function ShowTabKeys() As System.Collections.ArrayList Implements IfWizMax.ShowTabKeys
    End Function

    Public Sub StartAction() Implements IfWizMax.StartAction
        fTF.DisableButtons()
        Me.UpdateAndShowItems()
        fTF.RestoreButtons()
    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction
    End Sub

    Public Overrides Function ValidateData() As Boolean
        Return fTF.ValidateData
    End Function

    Private Sub ShowItems()
        myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Clear()
        myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("snum", False, False)
    End Sub

    Private Sub UpdateAndShowItems()
        Dim str1 As String, dt As DataTable
        Dim snum As Decimal = 0, lr As DataRow = Nothing

        If Me.Validate Then
            Me.HideError()
            str1 = ""
            For Each r As DataRow In fTF.fd.myView.mainGrid.myDS.Tables(0).Select("sysincl=1")
                str1 = str1 & IIf(str1 = "", "", ",") & r("tfnestreqid")
            Next
            If str1 = "" Then str1 = "0"

            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@Thk", myUtils.cValTN(fTF.cmb_Thk.Value), GetType(Decimal), False))
            Params.Add(New clsSQLParam("@TfNestReqIdCSV", str1, GetType(Integer), True))
            Dim oRet As clsProcOutput = fTF.GenerateParamsOutput("cncdrg", Params)
            If oRet.Success Then
                dt = oRet.Data.Tables(0)
                myUtils.DeleteRows(myView.mainGrid.myDS.Tables(0).Select)
                myUtils.CopyRows(dt.Select, myView.mainGrid.myDS.Tables(0))
                myUtils.CopyCol(myView.mainGrid.myDS.Tables(0), "qty", "qtyreq")
                For Each r As DataRow In myView.mainGrid.myDS.Tables(0).Select("", "reqdate,reference")
                    If (Not lr Is Nothing) AndAlso myUtils.MatchRowCols(r, lr, "PartNum", "Reference", "Description", "Specification", "Qty") Then
                        snum = snum + 0.1
                    Else
                        snum = Math.Floor(snum + 1)
                    End If
                    r("snum") = snum
                    lr = r
                Next
                Me.ShowItems()
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        Else
            Me.ShowError()
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Return fTF.VSave
    End Function
End Class
