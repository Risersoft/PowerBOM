Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmBOMStdDrg
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnEditDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddHardware As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPartItem As Infragistics.Win.Misc.UltraButton
    Public WithEvents btnPlace As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddCollection As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRefStd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPart As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddItemCollec As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAddItemCollec = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddHardware = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPartItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddCollection = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddRefStd = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPart = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShiftUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnMarkDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnPlace = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMarkUnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelDel = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(20, 1)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(747, 564)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(747, 476)
        Me.UltraGrid1.TabIndex = 15
        Me.UltraGrid1.Text = "Bill Of Material"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnAddItemCollec)
        Me.Panel9.Controls.Add(Me.btnAddHardware)
        Me.Panel9.Controls.Add(Me.btnAddPartItem)
        Me.Panel9.Controls.Add(Me.btnAddCollection)
        Me.Panel9.Controls.Add(Me.btnAddRefStd)
        Me.Panel9.Controls.Add(Me.btnAddPart)
        Me.Panel9.Controls.Add(Me.Panel1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 476)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(747, 88)
        Me.Panel9.TabIndex = 14
        '
        'btnAddItemCollec
        '
        Me.btnAddItemCollec.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddItemCollec.Location = New System.Drawing.Point(283, 42)
        Me.btnAddItemCollec.Name = "btnAddItemCollec"
        Me.btnAddItemCollec.Size = New System.Drawing.Size(80, 46)
        Me.btnAddItemCollec.TabIndex = 22
        Me.btnAddItemCollec.Text = "Add Item Collection"
        '
        'btnAddHardware
        '
        Me.btnAddHardware.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddHardware.Location = New System.Drawing.Point(363, 42)
        Me.btnAddHardware.Name = "btnAddHardware"
        Me.btnAddHardware.Size = New System.Drawing.Size(88, 46)
        Me.btnAddHardware.TabIndex = 21
        Me.btnAddHardware.Text = "Add Hardware"
        '
        'btnAddPartItem
        '
        Me.btnAddPartItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPartItem.Location = New System.Drawing.Point(451, 42)
        Me.btnAddPartItem.Name = "btnAddPartItem"
        Me.btnAddPartItem.Size = New System.Drawing.Size(64, 46)
        Me.btnAddPartItem.TabIndex = 20
        Me.btnAddPartItem.Text = "Add New Part Item"
        '
        'btnAddCollection
        '
        Me.btnAddCollection.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddCollection.Location = New System.Drawing.Point(515, 42)
        Me.btnAddCollection.Name = "btnAddCollection"
        Me.btnAddCollection.Size = New System.Drawing.Size(80, 46)
        Me.btnAddCollection.TabIndex = 18
        Me.btnAddCollection.Text = "Add Collection"
        '
        'btnAddRefStd
        '
        Me.btnAddRefStd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddRefStd.Location = New System.Drawing.Point(595, 42)
        Me.btnAddRefStd.Name = "btnAddRefStd"
        Me.btnAddRefStd.Size = New System.Drawing.Size(88, 46)
        Me.btnAddRefStd.TabIndex = 16
        Me.btnAddRefStd.Text = "Add Standard Reference"
        '
        'btnAddPart
        '
        Me.btnAddPart.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPart.Location = New System.Drawing.Point(683, 42)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(64, 46)
        Me.btnAddPart.TabIndex = 13
        Me.btnAddPart.Text = "Add New Part"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnShiftUp)
        Me.Panel1.Controls.Add(Me.btnMarkDel)
        Me.Panel1.Controls.Add(Me.btnPlace)
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 42)
        Me.Panel1.TabIndex = 23
        '
        'btnShiftUp
        '
        Me.btnShiftUp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnShiftUp.Location = New System.Drawing.Point(407, 0)
        Me.btnShiftUp.Name = "btnShiftUp"
        Me.btnShiftUp.Size = New System.Drawing.Size(85, 42)
        Me.btnShiftUp.TabIndex = 22
        Me.btnShiftUp.Text = "Shift Up"
        '
        'btnMarkDel
        '
        Me.btnMarkDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMarkDel.Location = New System.Drawing.Point(492, 0)
        Me.btnMarkDel.Name = "btnMarkDel"
        Me.btnMarkDel.Size = New System.Drawing.Size(85, 42)
        Me.btnMarkDel.TabIndex = 21
        Me.btnMarkDel.Text = "Mark As Delete"
        '
        'btnPlace
        '
        Me.btnPlace.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPlace.Location = New System.Drawing.Point(0, 0)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(96, 42)
        Me.btnPlace.TabIndex = 19
        Me.btnPlace.Text = "Place in ACAD"
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDel.Location = New System.Drawing.Point(577, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(85, 42)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(662, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 42)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(747, 564)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(747, 524)
        Me.UltraGrid2.TabIndex = 17
        Me.UltraGrid2.Text = "Bill Of Material"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMarkUnDel)
        Me.Panel3.Controls.Add(Me.btnEditDel)
        Me.Panel3.Controls.Add(Me.btnDelDel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 524)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(747, 40)
        Me.Panel3.TabIndex = 16
        '
        'btnMarkUnDel
        '
        Me.btnMarkUnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMarkUnDel.Location = New System.Drawing.Point(516, 0)
        Me.btnMarkUnDel.Name = "btnMarkUnDel"
        Me.btnMarkUnDel.Size = New System.Drawing.Size(91, 40)
        Me.btnMarkUnDel.TabIndex = 5
        Me.btnMarkUnDel.Text = "Mark As Un Delete"
        '
        'btnEditDel
        '
        Me.btnEditDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditDel.Location = New System.Drawing.Point(607, 0)
        Me.btnEditDel.Name = "btnEditDel"
        Me.btnEditDel.Size = New System.Drawing.Size(70, 40)
        Me.btnEditDel.TabIndex = 4
        Me.btnEditDel.Text = "Edit"
        '
        'btnDelDel
        '
        Me.btnDelDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelDel.Location = New System.Drawing.Point(677, 0)
        Me.btnDelDel.Name = "btnDelDel"
        Me.btnDelDel.Size = New System.Drawing.Size(70, 40)
        Me.btnDelDel.TabIndex = 3
        Me.btnDelDel.Text = "Delete"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(768, 566)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance1
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(768, 566)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.UltraTabControl1.TabIndex = 193
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Current Items"
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "Deleted Items"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(747, 564)
        '
        'frmBOMStdDrg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Production File Document"
        Me.ClientSize = New System.Drawing.Size(768, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBOMStdDrg"
        Me.Text = "Production File Document"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMarkDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMarkUnDel As Infragistics.Win.Misc.UltraButton
    Public WithEvents btnShiftUp As Infragistics.Win.Misc.UltraButton

#End Region
End Class

