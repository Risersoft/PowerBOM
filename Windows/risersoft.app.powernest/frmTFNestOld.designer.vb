Imports Infragistics.Win.UltraWinGrid
Imports risersoft.shared.win

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFNestOld
    Inherits frmMax

#Region " Windows Form Designer generated code "



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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnViewItems As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnUpdViewItems As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNextItems As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrevItems As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnNextParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrevParams As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrevNest As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.PanelSheet = New System.Windows.Forms.Panel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUpdViewItems = New Infragistics.Win.Misc.UltraButton()
        Me.btnViewItems = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnNextItems = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrevItems = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnNextParams = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrevParams = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPrevNest = New Infragistics.Win.Misc.UltraButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.LabelFK = New System.Windows.Forms.Label()
        Me.cmb_CNCTypeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_Thk = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dsForm,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dsCombo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl6.SuspendLayout
        CType(Me.UltraGrid4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl8.SuspendLayout
        CType(Me.UltraTextEditor1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl1.SuspendLayout
        CType(Me.UltraGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel5.SuspendLayout
        Me.UltraTabPageControl2.SuspendLayout
        CType(Me.UltraGrid2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraTabControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabControl2.SuspendLayout
        Me.Panel6.SuspendLayout
        Me.UltraTabPageControl3.SuspendLayout
        Me.Panel7.SuspendLayout
        Me.UltraTabPageControl4.SuspendLayout
        CType(Me.UltraTabControl3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabControl3.SuspendLayout
        CType(Me.UltraGrid3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel3.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.UltraTabControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabControl1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel4.SuspendLayout
        CType(Me.cmb_CNCTypeID,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cmb_Thk,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(268, 422)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGrid4)
        Me.UltraTabPageControl6.Controls.Add(Me.Splitter2)
        Me.UltraTabPageControl6.Controls.Add(Me.PanelSheet)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(608, 414)
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Location = New System.Drawing.Point(0, 205)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(608, 209)
        Me.UltraGrid4.TabIndex = 162
        Me.UltraGrid4.Text = "Delivery Schedule"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 197)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(608, 8)
        Me.Splitter2.TabIndex = 161
        Me.Splitter2.TabStop = false
        '
        'PanelSheet
        '
        Me.PanelSheet.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSheet.Location = New System.Drawing.Point(0, 0)
        Me.PanelSheet.Name = "PanelSheet"
        Me.PanelSheet.Size = New System.Drawing.Size(608, 197)
        Me.PanelSheet.TabIndex = 0
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(608, 414)
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraTextEditor1)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(608, 414)
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.AcceptsReturn = true
        Me.UltraTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTextEditor1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTextEditor1.Multiline = true
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.ReadOnly = true
        Me.UltraTextEditor1.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.UltraTextEditor1.Size = New System.Drawing.Size(608, 414)
        Me.UltraTextEditor1.TabIndex = 159
        Me.UltraTextEditor1.Text = "NC File"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(884, 488)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(884, 440)
        Me.UltraGrid1.TabIndex = 149
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnUpdViewItems)
        Me.Panel5.Controls.Add(Me.btnViewItems)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 440)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(884, 48)
        Me.Panel5.TabIndex = 148
        '
        'btnUpdViewItems
        '
        Me.btnUpdViewItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.Name = "Times New Roman"
        Appearance1.FontData.SizeInPoints = 10!
        Me.btnUpdViewItems.Appearance = Appearance1
        Me.btnUpdViewItems.Location = New System.Drawing.Point(760, 8)
        Me.btnUpdViewItems.Name = "btnUpdViewItems"
        Me.btnUpdViewItems.Size = New System.Drawing.Size(104, 40)
        Me.btnUpdViewItems.TabIndex = 1
        Me.btnUpdViewItems.Text = "Update and View Items >>"
        '
        'btnViewItems
        '
        Me.btnViewItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.Name = "Times New Roman"
        Appearance2.FontData.SizeInPoints = 10!
        Me.btnViewItems.Appearance = Appearance2
        Me.btnViewItems.Location = New System.Drawing.Point(640, 8)
        Me.btnViewItems.Name = "btnViewItems"
        Me.btnViewItems.Size = New System.Drawing.Size(104, 40)
        Me.btnViewItems.TabIndex = 0
        Me.btnViewItems.Text = "View Items >>"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Controls.Add(Me.Splitter1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(884, 488)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(604, 448)
        Me.UltraGrid2.TabIndex = 158
        Me.UltraGrid2.Text = "Delivery Schedule"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(604, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 448)
        Me.Splitter1.TabIndex = 157
        Me.Splitter1.TabStop = false
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraTabControl2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabControl2.Location = New System.Drawing.Point(612, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(272, 448)
        Me.UltraTabControl2.TabIndex = 156
        UltraTab1.Key = "img"
        UltraTab1.TabPage = Me.UltraTabPageControl5
        UltraTab1.Text = "DXF Image"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(268, 422)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnNextItems)
        Me.Panel6.Controls.Add(Me.btnPrevItems)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel6.Location = New System.Drawing.Point(0, 448)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(884, 40)
        Me.Panel6.TabIndex = 153
        '
        'btnNextItems
        '
        Me.btnNextItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.Name = "Times New Roman"
        Appearance3.FontData.SizeInPoints = 10!
        Me.btnNextItems.Appearance = Appearance3
        Me.btnNextItems.Location = New System.Drawing.Point(776, 2)
        Me.btnNextItems.Name = "btnNextItems"
        Me.btnNextItems.Size = New System.Drawing.Size(88, 36)
        Me.btnNextItems.TabIndex = 7
        Me.btnNextItems.Text = "Next >>"
        '
        'btnPrevItems
        '
        Me.btnPrevItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.Name = "Times New Roman"
        Appearance4.FontData.SizeInPoints = 10!
        Me.btnPrevItems.Appearance = Appearance4
        Me.btnPrevItems.Location = New System.Drawing.Point(680, 2)
        Me.btnPrevItems.Name = "btnPrevItems"
        Me.btnPrevItems.Size = New System.Drawing.Size(88, 36)
        Me.btnPrevItems.TabIndex = 6
        Me.btnPrevItems.Text = "<< Previous"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(884, 488)
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnNextParams)
        Me.Panel7.Controls.Add(Me.btnPrevParams)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel7.Location = New System.Drawing.Point(0, 448)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(884, 40)
        Me.Panel7.TabIndex = 157
        '
        'btnNextParams
        '
        Me.btnNextParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.Name = "Times New Roman"
        Appearance5.FontData.SizeInPoints = 10!
        Me.btnNextParams.Appearance = Appearance5
        Me.btnNextParams.Location = New System.Drawing.Point(776, 2)
        Me.btnNextParams.Name = "btnNextParams"
        Me.btnNextParams.Size = New System.Drawing.Size(88, 36)
        Me.btnNextParams.TabIndex = 7
        Me.btnNextParams.Text = "Next >>"
        '
        'btnPrevParams
        '
        Me.btnPrevParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance6.FontData.Name = "Times New Roman"
        Appearance6.FontData.SizeInPoints = 10!
        Me.btnPrevParams.Appearance = Appearance6
        Me.btnPrevParams.Location = New System.Drawing.Point(680, 2)
        Me.btnPrevParams.Name = "btnPrevParams"
        Me.btnPrevParams.Size = New System.Drawing.Size(88, 36)
        Me.btnPrevParams.TabIndex = 6
        Me.btnPrevParams.Text = "<< Previous"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraTabControl3)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl4.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(884, 488)
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(272, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(612, 440)
        Me.UltraTabControl3.TabIndex = 152
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
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(608, 414)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(272, 440)
        Me.UltraGrid3.TabIndex = 150
        Me.UltraGrid3.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnPrevNest)
        Me.Panel3.Controls.Add(Me.lblStatus)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 440)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(884, 48)
        Me.Panel3.TabIndex = 151
        '
        'btnPrevNest
        '
        Me.btnPrevNest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance8.FontData.Name = "Times New Roman"
        Appearance8.FontData.SizeInPoints = 10!
        Me.btnPrevNest.Appearance = Appearance8
        Me.btnPrevNest.Location = New System.Drawing.Point(688, 8)
        Me.btnPrevNest.Name = "btnPrevNest"
        Me.btnPrevNest.Size = New System.Drawing.Size(88, 36)
        Me.btnPrevNest.TabIndex = 158
        Me.btnPrevNest.Text = "<< Previous"
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.Location = New System.Drawing.Point(228, 11)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(400, 16)
        Me.lblStatus.TabIndex = 157
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 646)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 132)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(888, 514)
        Me.UltraTabControl1.TabIndex = 22
        UltraTab5.Key = "req"
        UltraTab5.TabPage = Me.UltraTabPageControl1
        UltraTab5.Text = "Requirements"
        UltraTab6.Key = "items"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Items"
        UltraTab7.Key = "params"
        UltraTab7.TabPage = Me.UltraTabPageControl3
        UltraTab7.Text = "Parameters"
        UltraTab8.Key = "nest"
        UltraTab8.TabPage = Me.UltraTabPageControl4
        UltraTab8.Text = "Nest"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6, UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(884, 488)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelFK)
        Me.Panel1.Controls.Add(Me.cmb_CNCTypeID)
        Me.Panel1.Controls.Add(Me.cmb_Thk)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 132)
        Me.Panel1.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 646)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(888, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance10.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance10
        Me.btnSave.Location = New System.Drawing.Point(632, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance11.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance11
        Me.btnCancel.Location = New System.Drawing.Point(728, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Appearance12.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance12
        Me.btnOK.Location = New System.Drawing.Point(808, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'LabelFK
        '
        Me.LabelFK.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelFK.Location = New System.Drawing.Point(208, 70)
        Me.LabelFK.Name = "LabelFK"
        Me.LabelFK.Size = New System.Drawing.Size(88, 16)
        Me.LabelFK.TabIndex = 178
        Me.LabelFK.Text = "CNC Type"
        Me.LabelFK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CNCTypeID
        '
        Me.cmb_CNCTypeID.DataMember = "Items"
        Me.cmb_CNCTypeID.DisplayMember = "CatName"
        Me.cmb_CNCTypeID.Location = New System.Drawing.Point(304, 70)
        Me.cmb_CNCTypeID.MaxDropDownItems = 15
        Me.cmb_CNCTypeID.Name = "cmb_CNCTypeID"
        Me.cmb_CNCTypeID.Size = New System.Drawing.Size(377, 22)
        Me.cmb_CNCTypeID.TabIndex = 179
        Me.cmb_CNCTypeID.Text = "UltraCombo1"
        Me.cmb_CNCTypeID.ValueMember = "ItemcatID"
        '
        'cmb_Thk
        '
        Me.cmb_Thk.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold)
        Me.cmb_Thk.Location = New System.Drawing.Point(304, 41)
        Me.cmb_Thk.Name = "cmb_Thk"
        Me.cmb_Thk.Size = New System.Drawing.Size(56, 23)
        Me.cmb_Thk.TabIndex = 177
        Me.cmb_Thk.Text = "UltraCombo4"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(216, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Thickness"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTFNestOld
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Nest"
        Me.ClientSize = New System.Drawing.Size(888, 694)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmTFNestOld"
        Me.Text = "Nest"
        CType(Me.dsForm,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dsCombo,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl6.ResumeLayout(false)
        CType(Me.UltraGrid4,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl8.ResumeLayout(false)
        Me.UltraTabPageControl8.PerformLayout
        CType(Me.UltraTextEditor1,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl1.ResumeLayout(false)
        CType(Me.UltraGrid1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel5.ResumeLayout(false)
        Me.UltraTabPageControl2.ResumeLayout(false)
        CType(Me.UltraGrid2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraTabControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabControl2.ResumeLayout(false)
        Me.Panel6.ResumeLayout(false)
        Me.UltraTabPageControl3.ResumeLayout(false)
        Me.Panel7.ResumeLayout(false)
        Me.UltraTabPageControl4.ResumeLayout(false)
        CType(Me.UltraTabControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabControl3.ResumeLayout(false)
        CType(Me.UltraGrid3,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.UltraTabControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabControl1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel4.ResumeLayout(false)
        CType(Me.cmb_CNCTypeID,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cmb_Thk,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PanelSheet As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents LabelFK As System.Windows.Forms.Label
    Friend WithEvents cmb_CNCTypeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_Thk As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label

#End Region
End Class

