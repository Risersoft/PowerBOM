Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmDrgHardware
    Inherits frmMax
    Dim dv, dv1, dv2 As DataView, myVueSubCat As New clsWinView, myVueItems As New clsWinView
    Dim dvParam As DataView, myVueParamReq As New clsWinView, dtReq As DataTable

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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_Weight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Description As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ItemNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_DescripChart As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmb_pValueD As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_pValueC As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_pValueB As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_pValueA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblpNameD As System.Windows.Forms.Label
    Friend WithEvents lblpNameC As System.Windows.Forms.Label
    Friend WithEvents lblpNameB As System.Windows.Forms.Label
    Friend WithEvents lblpNameA As System.Windows.Forms.Label
    Friend WithEvents PanelItem As System.Windows.Forms.Panel
    Friend WithEvents PanelParam As System.Windows.Forms.Panel
    Friend WithEvents cmb_pValueE As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblpNameE As System.Windows.Forms.Label
    Friend WithEvents lblLenParam As System.Windows.Forms.Label
    Friend WithEvents cmb_LengthParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblDiaParam As System.Windows.Forms.Label
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmb_ThreadParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chk_IsDeleted As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.PanelParam = New System.Windows.Forms.Panel()
        Me.chk_IsWelded = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsDeleted = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lblLenParam = New System.Windows.Forms.Label()
        Me.cmb_LengthParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ThreadParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblDiaParam = New System.Windows.Forms.Label()
        Me.cmb_pValueE = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblpNameE = New System.Windows.Forms.Label()
        Me.cmb_pValueD = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_pValueC = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_pValueB = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_pValueA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblpNameD = New System.Windows.Forms.Label()
        Me.lblpNameC = New System.Windows.Forms.Label()
        Me.lblpNameB = New System.Windows.Forms.Label()
        Me.lblpNameA = New System.Windows.Forms.Label()
        Me.txt_DescripChart = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Weight = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Description = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ItemNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextDrgNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.PanelItem = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PanelParam.SuspendLayout()
        CType(Me.chk_IsWelded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_LengthParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ThreadParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pValueE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pValueD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pValueC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pValueB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DescripChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ItemNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDrgNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelItem.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(888, 288)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 96)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(388, 192)
        Me.UltraGrid3.TabIndex = 251
        Me.UltraGrid3.Text = "Select Items"
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(388, 96)
        Me.UltraGrid2.TabIndex = 250
        Me.UltraGrid2.Text = "Select Sub Category"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGrid1.Location = New System.Drawing.Point(388, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(500, 288)
        Me.UltraGrid1.TabIndex = 249
        Me.UltraGrid1.Text = "Select Elements"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(888, 288)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(888, 240)
        Me.UltraGrid5.TabIndex = 7
        Me.UltraGrid5.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(888, 48)
        Me.Panel3.TabIndex = 6
        Me.Panel3.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 618)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(892, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(604, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(700, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(796, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'PanelParam
        '
        Me.PanelParam.Controls.Add(Me.chk_IsWelded)
        Me.PanelParam.Controls.Add(Me.chk_IsDeleted)
        Me.PanelParam.Controls.Add(Me.lblLenParam)
        Me.PanelParam.Controls.Add(Me.cmb_LengthParamID)
        Me.PanelParam.Controls.Add(Me.cmb_ThreadParamID)
        Me.PanelParam.Controls.Add(Me.lblDiaParam)
        Me.PanelParam.Controls.Add(Me.cmb_pValueE)
        Me.PanelParam.Controls.Add(Me.lblpNameE)
        Me.PanelParam.Controls.Add(Me.cmb_pValueD)
        Me.PanelParam.Controls.Add(Me.cmb_pValueC)
        Me.PanelParam.Controls.Add(Me.cmb_pValueB)
        Me.PanelParam.Controls.Add(Me.cmb_pValueA)
        Me.PanelParam.Controls.Add(Me.lblpNameD)
        Me.PanelParam.Controls.Add(Me.lblpNameC)
        Me.PanelParam.Controls.Add(Me.lblpNameB)
        Me.PanelParam.Controls.Add(Me.lblpNameA)
        Me.PanelParam.Controls.Add(Me.txt_DescripChart)
        Me.PanelParam.Controls.Add(Me.Label17)
        Me.PanelParam.Controls.Add(Me.Label10)
        Me.PanelParam.Controls.Add(Me.txt_Remark)
        Me.PanelParam.Controls.Add(Me.txt_Weight)
        Me.PanelParam.Controls.Add(Me.lblWeight)
        Me.PanelParam.Controls.Add(Me.Panel1)
        Me.PanelParam.Controls.Add(Me.txt_Description)
        Me.PanelParam.Controls.Add(Me.Label1)
        Me.PanelParam.Controls.Add(Me.txt_ItemNum)
        Me.PanelParam.Controls.Add(Me.Label9)
        Me.PanelParam.Controls.Add(Me.Label8)
        Me.PanelParam.Controls.Add(Me.TextDrgNum)
        Me.PanelParam.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelParam.Location = New System.Drawing.Point(0, 0)
        Me.PanelParam.Name = "PanelParam"
        Me.PanelParam.Size = New System.Drawing.Size(892, 304)
        Me.PanelParam.TabIndex = 222
        '
        'chk_IsWelded
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.chk_IsWelded.Appearance = Appearance4
        Me.chk_IsWelded.Location = New System.Drawing.Point(496, 119)
        Me.chk_IsWelded.Name = "chk_IsWelded"
        Me.chk_IsWelded.Size = New System.Drawing.Size(104, 24)
        Me.chk_IsWelded.TabIndex = 321
        Me.chk_IsWelded.Text = "Part is Welded"
        '
        'chk_IsDeleted
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.SizeInPoints = 8.0!
        Me.chk_IsDeleted.Appearance = Appearance6
        Me.chk_IsDeleted.Location = New System.Drawing.Point(288, 48)
        Me.chk_IsDeleted.Name = "chk_IsDeleted"
        Me.chk_IsDeleted.Size = New System.Drawing.Size(104, 24)
        Me.chk_IsDeleted.TabIndex = 320
        Me.chk_IsDeleted.Text = "Part is Deleted"
        '
        'lblLenParam
        '
        Me.lblLenParam.Location = New System.Drawing.Point(512, 272)
        Me.lblLenParam.Name = "lblLenParam"
        Me.lblLenParam.Size = New System.Drawing.Size(88, 16)
        Me.lblLenParam.TabIndex = 318
        Me.lblLenParam.Text = "Variable Length"
        Me.lblLenParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_LengthParamID
        '
        Me.cmb_LengthParamID.DataMember = "Items"
        Me.cmb_LengthParamID.DisplayMember = "SubCatName"
        Me.cmb_LengthParamID.Location = New System.Drawing.Point(608, 272)
        Me.cmb_LengthParamID.MaxDropDownItems = 15
        Me.cmb_LengthParamID.Name = "cmb_LengthParamID"
        Me.cmb_LengthParamID.Size = New System.Drawing.Size(120, 22)
        Me.cmb_LengthParamID.TabIndex = 319
        Me.cmb_LengthParamID.Text = "UltraCombo1"
        Me.cmb_LengthParamID.ValueMember = "SubcatID"
        '
        'cmb_ThreadParamID
        '
        Me.cmb_ThreadParamID.DataMember = "Items"
        Me.cmb_ThreadParamID.DisplayMember = "SubCatName"
        Me.cmb_ThreadParamID.Location = New System.Drawing.Point(608, 248)
        Me.cmb_ThreadParamID.MaxDropDownItems = 15
        Me.cmb_ThreadParamID.Name = "cmb_ThreadParamID"
        Me.cmb_ThreadParamID.Size = New System.Drawing.Size(120, 22)
        Me.cmb_ThreadParamID.TabIndex = 317
        Me.cmb_ThreadParamID.Text = "UltraCombo6"
        Me.cmb_ThreadParamID.ValueMember = "SubcatID"
        '
        'lblDiaParam
        '
        Me.lblDiaParam.Location = New System.Drawing.Point(496, 248)
        Me.lblDiaParam.Name = "lblDiaParam"
        Me.lblDiaParam.Size = New System.Drawing.Size(104, 16)
        Me.lblDiaParam.TabIndex = 316
        Me.lblDiaParam.Text = "Variable Thread"
        Me.lblDiaParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_pValueE
        '
        Me.cmb_pValueE.Location = New System.Drawing.Point(216, 280)
        Me.cmb_pValueE.Name = "cmb_pValueE"
        Me.cmb_pValueE.Size = New System.Drawing.Size(272, 21)
        Me.cmb_pValueE.TabIndex = 257
        Me.cmb_pValueE.Text = "UltraComboEditor1"
        '
        'lblpNameE
        '
        Me.lblpNameE.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblpNameE.Location = New System.Drawing.Point(32, 280)
        Me.lblpNameE.Name = "lblpNameE"
        Me.lblpNameE.Size = New System.Drawing.Size(176, 16)
        Me.lblpNameE.TabIndex = 256
        Me.lblpNameE.Text = "Item Code"
        Me.lblpNameE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_pValueD
        '
        Me.cmb_pValueD.Location = New System.Drawing.Point(216, 256)
        Me.cmb_pValueD.Name = "cmb_pValueD"
        Me.cmb_pValueD.Size = New System.Drawing.Size(272, 21)
        Me.cmb_pValueD.TabIndex = 255
        Me.cmb_pValueD.Text = "UltraComboEditor1"
        '
        'cmb_pValueC
        '
        Me.cmb_pValueC.Location = New System.Drawing.Point(216, 232)
        Me.cmb_pValueC.Name = "cmb_pValueC"
        Me.cmb_pValueC.Size = New System.Drawing.Size(272, 21)
        Me.cmb_pValueC.TabIndex = 254
        Me.cmb_pValueC.Text = "UltraComboEditor1"
        '
        'cmb_pValueB
        '
        Me.cmb_pValueB.Location = New System.Drawing.Point(216, 208)
        Me.cmb_pValueB.Name = "cmb_pValueB"
        Me.cmb_pValueB.Size = New System.Drawing.Size(272, 21)
        Me.cmb_pValueB.TabIndex = 253
        Me.cmb_pValueB.Text = "UltraComboEditor1"
        '
        'cmb_pValueA
        '
        Me.cmb_pValueA.Location = New System.Drawing.Point(216, 184)
        Me.cmb_pValueA.Name = "cmb_pValueA"
        Me.cmb_pValueA.Size = New System.Drawing.Size(272, 21)
        Me.cmb_pValueA.TabIndex = 252
        Me.cmb_pValueA.Text = "UltraComboEditor1"
        '
        'lblpNameD
        '
        Me.lblpNameD.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblpNameD.Location = New System.Drawing.Point(32, 256)
        Me.lblpNameD.Name = "lblpNameD"
        Me.lblpNameD.Size = New System.Drawing.Size(176, 16)
        Me.lblpNameD.TabIndex = 251
        Me.lblpNameD.Text = "Item Code"
        Me.lblpNameD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblpNameC
        '
        Me.lblpNameC.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblpNameC.Location = New System.Drawing.Point(32, 232)
        Me.lblpNameC.Name = "lblpNameC"
        Me.lblpNameC.Size = New System.Drawing.Size(176, 16)
        Me.lblpNameC.TabIndex = 250
        Me.lblpNameC.Text = "Item Code"
        Me.lblpNameC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblpNameB
        '
        Me.lblpNameB.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblpNameB.Location = New System.Drawing.Point(32, 208)
        Me.lblpNameB.Name = "lblpNameB"
        Me.lblpNameB.Size = New System.Drawing.Size(176, 16)
        Me.lblpNameB.TabIndex = 249
        Me.lblpNameB.Text = "Item Code"
        Me.lblpNameB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblpNameA
        '
        Me.lblpNameA.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblpNameA.Location = New System.Drawing.Point(32, 184)
        Me.lblpNameA.Name = "lblpNameA"
        Me.lblpNameA.Size = New System.Drawing.Size(176, 16)
        Me.lblpNameA.TabIndex = 248
        Me.lblpNameA.Text = "Item Code"
        Me.lblpNameA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DescripChart
        '
        Me.txt_DescripChart.Location = New System.Drawing.Point(216, 152)
        Me.txt_DescripChart.Name = "txt_DescripChart"
        Me.txt_DescripChart.Size = New System.Drawing.Size(320, 21)
        Me.txt_DescripChart.TabIndex = 246
        Me.txt_DescripChart.Text = "UltraTextEditor8"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(112, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 24)
        Me.Label17.TabIndex = 247
        Me.Label17.Text = "Chart Description"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(552, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 229
        Me.Label10.Text = "Remark"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(552, 175)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(328, 65)
        Me.txt_Remark.TabIndex = 4
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(408, 120)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.ReadOnly = True
        Me.txt_Weight.Size = New System.Drawing.Size(72, 21)
        Me.txt_Weight.TabIndex = 3
        Me.txt_Weight.Text = "UltraTextEditor8"
        '
        'lblWeight
        '
        Me.lblWeight.Location = New System.Drawing.Point(352, 120)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(48, 16)
        Me.lblWeight.TabIndex = 222
        Me.lblWeight.Text = "Weight"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Qty)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(104, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 32)
        Me.Panel1.TabIndex = 221
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(190, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Nos."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(112, 6)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(72, 21)
        Me.txt_Qty.TabIndex = 0
        Me.txt_Qty.Text = "UltraTextEditor8"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Qty"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Description
        '
        Me.txt_Description.Location = New System.Drawing.Point(216, 80)
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.ReadOnly = True
        Me.txt_Description.Size = New System.Drawing.Size(568, 21)
        Me.txt_Description.TabIndex = 1
        Me.txt_Description.Text = "UltraTextEditor8"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "BOM Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ItemNum
        '
        Me.txt_ItemNum.Location = New System.Drawing.Point(216, 48)
        Me.txt_ItemNum.Name = "txt_ItemNum"
        Me.txt_ItemNum.Size = New System.Drawing.Size(56, 21)
        Me.txt_ItemNum.TabIndex = 0
        Me.txt_ItemNum.Text = "UltraTextEditor8"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(72, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 16)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "Item Number"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(72, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Drawing Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextDrgNum
        '
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.SizeInPoints = 10.0!
        Me.TextDrgNum.Appearance = Appearance5
        Me.TextDrgNum.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.TextDrgNum.Location = New System.Drawing.Point(216, 16)
        Me.TextDrgNum.Name = "TextDrgNum"
        Me.TextDrgNum.ReadOnly = True
        Me.TextDrgNum.Size = New System.Drawing.Size(384, 20)
        Me.TextDrgNum.TabIndex = 215
        Me.TextDrgNum.Text = "UltraTextEditor3"
        '
        'PanelItem
        '
        Me.PanelItem.Controls.Add(Me.UltraTabControl1)
        Me.PanelItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelItem.Location = New System.Drawing.Point(0, 304)
        Me.PanelItem.Name = "PanelItem"
        Me.PanelItem.Size = New System.Drawing.Size(892, 314)
        Me.PanelItem.TabIndex = 247
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
        Me.UltraTabControl1.Size = New System.Drawing.Size(892, 314)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Elements"
        UltraTab2.Key = "param"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Parameters"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(888, 288)
        '
        'frmDrgHardware
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Hardware"
        Me.ClientSize = New System.Drawing.Size(892, 666)
        Me.Controls.Add(Me.PanelItem)
        Me.Controls.Add(Me.PanelParam)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmDrgHardware"
        Me.Text = "Hardware"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.PanelParam.ResumeLayout(False)
        Me.PanelParam.PerformLayout()
        CType(Me.chk_IsWelded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_LengthParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ThreadParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pValueE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pValueD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pValueC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pValueB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DescripChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ItemNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDrgNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelItem.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_IsWelded As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents TextDrgNum As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class

