Imports System.Threading.Tasks
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxengg
Imports risersoft.app.shared.mxengg

Public Class frmTFNest3
    Inherits frmMax
    Implements IfWizMax
    Friend f2, f3 As frmMax, myVueSheetBOM As New clsWinView, dvSheetBOM As DataView
    Dim strLastFileSheet, strNewFileSheet, strLastFileRem, strNewFileRem As String, myNester As INestProvider
    Public fTF As frmTFNest

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid3)
        myVueSheetBOM.SetGrid(Me.UltraGrid4)

        f2 = myWinApp.objAppExtender.fViewer2D
        f2.AddToPanel(Me.PanelSheet, True, DockStyle.Fill)

        f3 = myWinApp.objAppExtender.fViewer2D
        f3.AddtoTab(Me.UltraTabControl3, "rem", True)

        myNester = New clsSN(Me.Controller)          'later, has to be selected by user in options and instantiated from there 
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myView.PrepEdit(NewModel.GridViews("TFNestSheet"))
        Return True
    End Function

    Public Overrides Function PrepFormRow(r As System.Data.DataRow) As Boolean
        AddHandler myView.mainGrid.myGrid.AfterSelectChange, AddressOf UltraGrid3_AfterSelectChange

        Me.genSheetBOM()
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Private Async Sub UltraGrid3_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs)
        Dim gRow As UltraGridRow, newfileSheet As Boolean = False, newFileRem As Boolean = False, str1, str2 As String
        Dim ms As New System.IO.MemoryStream, sr As System.IO.StreamReader

        strLastFileSheet = strNewFileSheet
        strLastFileRem = strNewFileRem
        str2 = ""
        gRow = myView.mainGrid.myGrid.ActiveRow
        If gRow Is Nothing Then
            str1 = "0=1"
        Else
            str1 = "tfnestsheetid=" & myUtils.cValTN(gRow.Cells("tfnestsheetid").Value)
            If myUtils.cStrTN(gRow.Cells("cncdrg").Value).Trim.Length > 0 Then
                strNewFileSheet = Await fTF.oFiler.FileProvider.DownloadTempAsync(gRow.Cells("cncdrg").Value)
                CType(f2, IViewer).OpenFile(strNewFileSheet)
                'Me.AxEModelViewControl2.OpenDoc(strNewFileSheet, True, False, False, "")
                newfileSheet = True
            End If
            If myUtils.cStrTN(gRow.Cells("cncdrgrem").Value).Trim.Length > 0 Then
                strNewFileRem = Await fTF.oFiler.FileProvider.DownloadTempAsync(gRow.Cells("cncdrgrem").Value)
                'Me.AxEModelViewControl3.OpenDoc(strNewFileRem, True, False, False, "")
                CType(f3, IViewer).OpenFile(strNewFileRem)
                newFileRem = True
            End If
            If myUtils.cStrTN(gRow.Cells("ncfile").Value).Trim.Length > 0 Then
                ms = Await fTF.oFiler.FileProvider.DownloadToMemoryStream(gRow.Cells("ncfile").Value)
                sr = New System.IO.StreamReader(ms)
                str2 = sr.ReadToEnd
                sr.Close()
                ms.Close()
            End If

        End If
        dvSheetBOM.RowFilter = str1
        Me.UltraTextEditor1.Text = str2
        'If Not newfileSheet Then Me.AxEModelViewControl2.CloseActiveDoc("")
        If Not newfileSheet Then CType(f2, IViewer).OpenFile("")

        'If Not newFileRem Then Me.AxEModelViewControl3.CloseActiveDoc("")
        If Not newFileRem Then CType(f3, IViewer).OpenFile("")
        If myUtils.cStrTN(strLastFileSheet).Trim.Length > 0 Then myWinFtp.DeleteLocalFile(strLastFileSheet)
        If myUtils.cStrTN(strLastFileRem).Trim.Length > 0 Then myWinFtp.DeleteLocalFile(strLastFileRem)
    End Sub

    Friend Sub CloseRemView()
        If CType(f3, IViewer).DetachRequiredOnClose Then f3.RemoveTab(Me)
        CType(f3, IViewer).CloseFile()
        myWinFtp.DeleteLocalFile(strLastFileRem)
    End Sub

    Friend Sub CloseSheetView()
        If CType(f2, IViewer).DetachRequiredOnClose Then f2.RemovePanel(Me)
        CType(f2, IViewer).CloseFile()
        myWinFtp.DeleteLocalFile(strLastFileSheet)
    End Sub

    Private Sub genSheetBOM()
        Dim dt1, dt2, dt As DataTable

        If myUtils.cStrTN(fTF.myRow("sheetbomxml")).Trim.Length > 0 Then
            dt1 = myUtils.dataSetFromXML(fTF.myRow("sheetbomxml"), myFuncsPB.dtSheetBOM).Tables(0)
        Else
            dt1 = myFuncsPB.dtSheetBOM
        End If
        dt2 = fTF.fi.myView.mainGrid.myDS.Tables(0).Copy
        dt2.Columns.Remove("qty")
        dt2.Columns.Remove("qtynested")
        dt = Me.Controller.Data.InnerJoin(dt2, dt1, "tfnestitemid")

        dvSheetBOM = myVueSheetBOM.mainGrid.BindView(dt.DataSet, , True)
        myVueSheetBOM.mainGrid.QuickConf("", True, "1-2-2-2-2-1-1-0-1", True)
    End Sub

    Public Function btnActionText() As String Implements IfWizMax.btnActionText
        Return "Start Nesting"
    End Function

    Public Function LoseFocus(newTabKey As String) As Boolean Implements IfWizMax.LoseFocus
        Return True
    End Function

    Public Sub PrintOutput() Implements IfWizMax.PrintOutput
    End Sub

    Public Function SetFocus(oldTabKey As String) As Boolean Implements IfWizMax.SetFocus
        If Me.FormPrepared Then
            Return True
        Else
            Return Me.PrepFormRow(fTF.myRow.Row)
        End If
    End Function

    Public Function ShowTabKeys() As System.Collections.ArrayList Implements IfWizMax.ShowTabKeys
    End Function

    Public Async Sub StartAction() Implements IfWizMax.StartAction
        Await Me.recalc()
    End Sub

    Public Sub StopAction() Implements IfWizMax.StopAction
    End Sub

    Private Sub btnZoomExt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomExt.Click
        CType(f2, IViewer).zoom_extents()
    End Sub

    Private Async Sub btnSaveZip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveZip.Click
        Await myFuncsETO.SaveAsZipFile(Me.myView, Me.myVueSheetBOM, fTF.myRow.Row)
    End Sub

    Private Sub DoEnable(enable As Boolean)
        Me.btnSaveZip.Enabled = enable
        Me.btnZoomExt.Enabled = enable
    End Sub

    Private Async Function recalc() As Task
        If Me.VSave Then
            fTF.DisableButtons()
            Me.DoEnable(False)
            fTF.UltraProgressBar1.Value = 0
            fTF.UltraProgressBar1.Text = "[Formatted]"
            fTF.UltraProgressBar1.Visible = True
            Dim cb As New ProgressReporter(Of clsProgressReport)(AddressOf ProgressChanged)
            Await myNester.DoNest(New clsMultiWorker(cb), fTF.myRow.Row, fTF.fi.myView, myView, "Plasma")

        End If
    End Function
    Private Sub ProgressChanged(ByVal sender As Object, report As clsProgressReport)
        Select Case report.ReportType
            Case EnumReportType.Message
                Trace.WriteLine(report.Message)
                'myWinUtils.LogTextEvent(Me.RichTextBox1, report.TextColor, report.Message)
            Case EnumReportType.TaskProgress
                Me.ReportProgress(report.Percentage, report.Message)
            Case EnumReportType.TaskFinish
                Me.CompleteRun(report.Description, False)

        End Select
    End Sub

    Public Sub CompleteRun(ByVal result As String, ByVal cancelled As Boolean)
        Me.InvokeOnUiThreadIfRequired(Sub()
                                          fTF.UltraProgressBar1.Visible = False
                                          fTF.myRow("isnested") = True
                                          Me.VSave()      'SheetBOMXML and other things
                                          Me.genSheetBOM()
                                          fTF.RestoreButtons()
                                          Me.DoEnable(True)

                                      End Sub)

    End Sub

    Public Overloads Sub ReportProgress(ByVal ProgressPercentage As Decimal, ByVal msgProg As String)

        Me.InvokeOnUiThreadIfRequired(Sub()
                                          If ProgressPercentage < fTF.UltraProgressBar1.Maximum Then
                                              fTF.UltraProgressBar1.Value = ProgressPercentage
                                          Else
                                              fTF.UltraProgressBar1.Value = fTF.UltraProgressBar1.Maximum
                                          End If
                                          fTF.UltraProgressBar1.Text = myUtils.cStrTN(msgProg) & " ([Formatted])"
                                      End Sub)



    End Sub

    Public Overrides Function VSave() As Boolean
        Return fTF.VSave
    End Function
End Class
