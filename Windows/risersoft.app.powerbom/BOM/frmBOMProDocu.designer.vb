Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app2.shared

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmBOMProDocu
    Inherits frmMax2

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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnCopy As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPaste As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddCollection As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRefFile As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRefStd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPart As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_Document As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Drawing As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Public WithEvents btnPlace As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPartItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddHardware As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddItemCollec As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraProgressBar1 = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Document = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Drawing = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAddItemCollec = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddHardware = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPartItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddCollection = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddRefFile = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddRefStd = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPart = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShiftUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnProcess = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnPlace = New Infragistics.Win.Misc.UltraButton()
        Me.btnPaste = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bgw1 = New System.ComponentModel.BackgroundWorker()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.txt_Document, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Drawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraProgressBar1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(768, 513)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(768, 481)
        Me.UltraGrid1.TabIndex = 18
        Me.UltraGrid1.Text = "Bill Of Material"
        '
        'UltraProgressBar1
        '
        Appearance14.FontData.BoldAsString = "True"
        Me.UltraProgressBar1.Appearance = Appearance14
        Me.UltraProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraProgressBar1.Location = New System.Drawing.Point(0, 481)
        Me.UltraProgressBar1.Name = "UltraProgressBar1"
        Me.UltraProgressBar1.Size = New System.Drawing.Size(768, 32)
        Me.UltraProgressBar1.TabIndex = 583
        Me.UltraProgressBar1.Text = "Analyzing Item no. 1 ( [Formatted])"
        Me.UltraProgressBar1.Value = 50
        Me.UltraProgressBar1.Visible = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Document)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Drawing)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(768, 513)
        '
        'txt_Document
        '
        Appearance1.FontData.BoldAsString = "False"
        Appearance1.FontData.ItalicAsString = "False"
        Appearance1.FontData.Name = "Arial"
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.FontData.StrikeoutAsString = "False"
        Appearance1.FontData.UnderlineAsString = "False"
        Me.txt_Document.Appearance = Appearance1
        Me.txt_Document.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Document.Location = New System.Drawing.Point(136, 139)
        Me.txt_Document.Multiline = True
        Me.txt_Document.Name = "txt_Document"
        Me.txt_Document.ReadOnly = True
        Me.txt_Document.Size = New System.Drawing.Size(264, 72)
        Me.txt_Document.TabIndex = 194
        '
        'txt_Drawing
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_Drawing.Appearance = Appearance2
        Me.txt_Drawing.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Drawing.Location = New System.Drawing.Point(88, 32)
        Me.txt_Drawing.Name = "txt_Drawing"
        Me.txt_Drawing.ReadOnly = True
        Me.txt_Drawing.Size = New System.Drawing.Size(240, 21)
        Me.txt_Drawing.TabIndex = 193
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(768, 600)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(768, 513)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.UltraTabControl1.TabIndex = 193
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "tab2"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(768, 513)
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnAddItemCollec)
        Me.Panel9.Controls.Add(Me.btnAddHardware)
        Me.Panel9.Controls.Add(Me.btnAddPartItem)
        Me.Panel9.Controls.Add(Me.btnAddCollection)
        Me.Panel9.Controls.Add(Me.btnAddRefFile)
        Me.Panel9.Controls.Add(Me.btnAddRefStd)
        Me.Panel9.Controls.Add(Me.btnAddPart)
        Me.Panel9.Controls.Add(Me.Panel1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 513)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(768, 87)
        Me.Panel9.TabIndex = 16
        '
        'btnAddItemCollec
        '
        Me.btnAddItemCollec.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddItemCollec.Location = New System.Drawing.Point(176, 40)
        Me.btnAddItemCollec.Name = "btnAddItemCollec"
        Me.btnAddItemCollec.Size = New System.Drawing.Size(96, 47)
        Me.btnAddItemCollec.TabIndex = 13
        Me.btnAddItemCollec.Text = "Add Item Collection"
        '
        'btnAddHardware
        '
        Me.btnAddHardware.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddHardware.Location = New System.Drawing.Point(272, 40)
        Me.btnAddHardware.Name = "btnAddHardware"
        Me.btnAddHardware.Size = New System.Drawing.Size(88, 47)
        Me.btnAddHardware.TabIndex = 12
        Me.btnAddHardware.Text = "Add Hardware"
        '
        'btnAddPartItem
        '
        Me.btnAddPartItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPartItem.Location = New System.Drawing.Point(360, 40)
        Me.btnAddPartItem.Name = "btnAddPartItem"
        Me.btnAddPartItem.Size = New System.Drawing.Size(64, 47)
        Me.btnAddPartItem.TabIndex = 11
        Me.btnAddPartItem.Text = "Add New Part Item"
        '
        'btnAddCollection
        '
        Me.btnAddCollection.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddCollection.Location = New System.Drawing.Point(424, 40)
        Me.btnAddCollection.Name = "btnAddCollection"
        Me.btnAddCollection.Size = New System.Drawing.Size(96, 47)
        Me.btnAddCollection.TabIndex = 7
        Me.btnAddCollection.Text = "Add Drawing Item Collection"
        '
        'btnAddRefFile
        '
        Me.btnAddRefFile.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddRefFile.Location = New System.Drawing.Point(520, 40)
        Me.btnAddRefFile.Name = "btnAddRefFile"
        Me.btnAddRefFile.Size = New System.Drawing.Size(96, 47)
        Me.btnAddRefFile.TabIndex = 6
        Me.btnAddRefFile.Text = "Add File Reference"
        '
        'btnAddRefStd
        '
        Me.btnAddRefStd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddRefStd.Location = New System.Drawing.Point(616, 40)
        Me.btnAddRefStd.Name = "btnAddRefStd"
        Me.btnAddRefStd.Size = New System.Drawing.Size(88, 47)
        Me.btnAddRefStd.TabIndex = 5
        Me.btnAddRefStd.Text = "Add Standard Reference"
        '
        'btnAddPart
        '
        Me.btnAddPart.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPart.Location = New System.Drawing.Point(704, 40)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(64, 47)
        Me.btnAddPart.TabIndex = 2
        Me.btnAddPart.Text = "Add New Part"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnShiftUp)
        Me.Panel1.Controls.Add(Me.btnProcess)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnPlace)
        Me.Panel1.Controls.Add(Me.btnPaste)
        Me.Panel1.Controls.Add(Me.btnCopy)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 40)
        Me.Panel1.TabIndex = 14
        '
        'btnShiftUp
        '
        Me.btnShiftUp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnShiftUp.Location = New System.Drawing.Point(549, 0)
        Me.btnShiftUp.Name = "btnShiftUp"
        Me.btnShiftUp.Size = New System.Drawing.Size(93, 40)
        Me.btnShiftUp.TabIndex = 12
        Me.btnShiftUp.Text = "Shift Up"
        '
        'btnProcess
        '
        Me.btnProcess.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProcess.Location = New System.Drawing.Point(233, 0)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(93, 40)
        Me.btnProcess.TabIndex = 11
        Me.btnProcess.Text = "Process"
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDel.Location = New System.Drawing.Point(642, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 40)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(712, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(56, 40)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        '
        'btnPlace
        '
        Me.btnPlace.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPlace.Location = New System.Drawing.Point(140, 0)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(93, 40)
        Me.btnPlace.TabIndex = 10
        Me.btnPlace.Text = "Place in ACAD"
        '
        'btnPaste
        '
        Me.btnPaste.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPaste.Location = New System.Drawing.Point(70, 0)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(70, 40)
        Me.btnPaste.TabIndex = 8
        Me.btnPaste.Text = "Paste"
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCopy.Location = New System.Drawing.Point(0, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(70, 40)
        Me.btnCopy.TabIndex = 9
        Me.btnCopy.Text = "Copy"
        '
        'bgw1
        '
        Me.bgw1.WorkerReportsProgress = True
        '
        'frmBOMProDocu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.Caption = "Production File Document"
        Me.ClientSize = New System.Drawing.Size(768, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBOMProDocu"
        Me.Text = "Production File Document"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.txt_Document, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Drawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btnShiftUp As Infragistics.Win.Misc.UltraButton
    Public WithEvents btnProcess As Infragistics.Win.Misc.UltraButton
    Public WithEvents UltraProgressBar1 As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents bgw1 As System.ComponentModel.BackgroundWorker

#End Region
End Class

