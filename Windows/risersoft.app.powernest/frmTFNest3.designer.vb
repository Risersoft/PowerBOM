Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.win

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFNest3
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.initForm()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.PanelSheet = New System.Windows.Forms.Panel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSaveZip = New Infragistics.Win.Misc.UltraButton()
        Me.btnZoomExt = New Infragistics.Win.Misc.UltraButton()
        Me.bgw1 = New System.ComponentModel.BackgroundWorker()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGrid4)
        Me.UltraTabPageControl6.Controls.Add(Me.Splitter2)
        Me.UltraTabPageControl6.Controls.Add(Me.PanelSheet)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(531, 524)
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Location = New System.Drawing.Point(0, 205)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(531, 319)
        Me.UltraGrid4.TabIndex = 162
        Me.UltraGrid4.Text = "Delivery Schedule"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 197)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(531, 8)
        Me.Splitter2.TabIndex = 161
        Me.Splitter2.TabStop = False
        '
        'PanelSheet
        '
        Me.PanelSheet.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSheet.Location = New System.Drawing.Point(0, 0)
        Me.PanelSheet.Name = "PanelSheet"
        Me.PanelSheet.Size = New System.Drawing.Size(531, 197)
        Me.PanelSheet.TabIndex = 0
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(531, 524)
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraTextEditor1)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(531, 524)
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.AcceptsReturn = True
        Me.UltraTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTextEditor1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTextEditor1.Multiline = True
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.ReadOnly = True
        Me.UltraTextEditor1.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.UltraTextEditor1.Size = New System.Drawing.Size(531, 524)
        Me.UltraTextEditor1.TabIndex = 159
        Me.UltraTextEditor1.Text = "NC File"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 550)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(209, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(535, 550)
        Me.UltraTabControl3.TabIndex = 153
        UltraTab2.TabPage = Me.UltraTabPageControl6
        UltraTab2.Text = "Sheet"
        UltraTab3.Key = "rem"
        UltraTab3.TabPage = Me.UltraTabPageControl7
        UltraTab3.Text = "Remnant"
        UltraTab4.TabPage = Me.UltraTabPageControl8
        UltraTab4.Text = "NC file"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(531, 524)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraGrid3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 550)
        Me.Panel1.TabIndex = 152
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(209, 493)
        Me.UltraGrid3.TabIndex = 152
        Me.UltraGrid3.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSaveZip)
        Me.Panel3.Controls.Add(Me.btnZoomExt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 493)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 57)
        Me.Panel3.TabIndex = 0
        '
        'btnSaveZip
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnSaveZip.Appearance = Appearance7
        Me.btnSaveZip.Location = New System.Drawing.Point(108, 12)
        Me.btnSaveZip.Name = "btnSaveZip"
        Me.btnSaveZip.Size = New System.Drawing.Size(88, 32)
        Me.btnSaveZip.TabIndex = 161
        Me.btnSaveZip.Text = "Save as Zip File"
        '
        'btnZoomExt
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnZoomExt.Appearance = Appearance9
        Me.btnZoomExt.Location = New System.Drawing.Point(12, 12)
        Me.btnZoomExt.Name = "btnZoomExt"
        Me.btnZoomExt.Size = New System.Drawing.Size(88, 32)
        Me.btnZoomExt.TabIndex = 160
        Me.btnZoomExt.Text = "&Zoom Extents"
        '
        'bgw1
        '
        Me.bgw1.WorkerReportsProgress = True
        '
        'frmTFNest3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Standard Drawing Reference"
        Me.ClientSize = New System.Drawing.Size(744, 550)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmTFNest3"
        Me.Text = "Standard Drawing Reference"
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl8.PerformLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSaveZip As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnZoomExt As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents PanelSheet As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents bgw1 As System.ComponentModel.BackgroundWorker

#End Region
End Class

