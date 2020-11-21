Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmDrgPart
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chk_IsDeleted As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsBoughtOut As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_material As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Weight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Description As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ItemNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_OuterDia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_InnerDia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Width As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Length As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Thk As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_MatSection As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlUpLoad1 As ctlUpLoad
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DescripChart As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_OuterDia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_InnerDia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Width = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Length = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Thk = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_MatSection = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlUpLoad1 = New risersoft.[shared].win.ctlUpLoad()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DescripChart = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_IsDeleted = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsBoughtOut = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_material = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Weight = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Description = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ItemNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextDrgNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_OuterDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InnerDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Length, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Thk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MatSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.txt_DescripChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsBoughtOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ItemNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDrgNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Label19)
        Me.UltraTabPageControl1.Controls.Add(Me.Label18)
        Me.UltraTabPageControl1.Controls.Add(Me.Label13)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_OuterDia)
        Me.UltraTabPageControl1.Controls.Add(Me.Label14)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_InnerDia)
        Me.UltraTabPageControl1.Controls.Add(Me.Label16)
        Me.UltraTabPageControl1.Controls.Add(Me.Label15)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Width)
        Me.UltraTabPageControl1.Controls.Add(Me.Label11)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Length)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Thk)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_MatSection)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(772, 260)
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(264, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 241
        Me.Label19.Text = "mm"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(280, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 240
        Me.Label18.Text = "mm"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(296, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 239
        Me.Label13.Text = "mm"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(264, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 238
        Me.Label7.Text = "mm"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_OuterDia
        '
        Me.txt_OuterDia.Location = New System.Drawing.Point(192, 192)
        Me.txt_OuterDia.Name = "txt_OuterDia"
        Me.txt_OuterDia.Size = New System.Drawing.Size(80, 21)
        Me.txt_OuterDia.TabIndex = 235
        Me.txt_OuterDia.Text = "UltraTextEditor8"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(112, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 237
        Me.Label14.Text = "OD"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_InnerDia
        '
        Me.txt_InnerDia.Location = New System.Drawing.Point(192, 160)
        Me.txt_InnerDia.Name = "txt_InnerDia"
        Me.txt_InnerDia.Size = New System.Drawing.Size(64, 21)
        Me.txt_InnerDia.TabIndex = 234
        Me.txt_InnerDia.Text = "UltraTextEditor8"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(128, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 236
        Me.Label16.Text = "ID"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(280, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 233
        Me.Label15.Text = "mm"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Width
        '
        Me.txt_Width.Location = New System.Drawing.Point(192, 96)
        Me.txt_Width.Name = "txt_Width"
        Me.txt_Width.Size = New System.Drawing.Size(80, 21)
        Me.txt_Width.TabIndex = 224
        Me.txt_Width.Text = "UltraTextEditor8"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(64, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 232
        Me.Label11.Text = "Width"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Length
        '
        Me.txt_Length.Location = New System.Drawing.Point(192, 128)
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.Size = New System.Drawing.Size(96, 21)
        Me.txt_Length.TabIndex = 225
        Me.txt_Length.Text = "UltraTextEditor8"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(64, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "Length"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Thk
        '
        Me.txt_Thk.Location = New System.Drawing.Point(192, 64)
        Me.txt_Thk.Name = "txt_Thk"
        Me.txt_Thk.Size = New System.Drawing.Size(64, 21)
        Me.txt_Thk.TabIndex = 223
        Me.txt_Thk.Text = "UltraTextEditor8"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(128, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Thickness"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MatSection
        '
        Me.txt_MatSection.Location = New System.Drawing.Point(192, 32)
        Me.txt_MatSection.Name = "txt_MatSection"
        Me.txt_MatSection.Size = New System.Drawing.Size(168, 21)
        Me.txt_MatSection.TabIndex = 222
        Me.txt_MatSection.Text = "UltraTextEditor8"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(88, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Material Section"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(772, 260)
        '
        'CtlUpLoad1
        '
        Me.CtlUpLoad1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUpLoad1.Name = "CtlUpLoad1"
        Me.CtlUpLoad1.Size = New System.Drawing.Size(772, 40)
        Me.CtlUpLoad1.TabIndex = 229
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.txt_DescripChart)
        Me.UltraTabPageControl3.Controls.Add(Me.Label17)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(772, 260)
        '
        'txt_DescripChart
        '
        Me.txt_DescripChart.Location = New System.Drawing.Point(216, 32)
        Me.txt_DescripChart.Name = "txt_DescripChart"
        Me.txt_DescripChart.Size = New System.Drawing.Size(376, 21)
        Me.txt_DescripChart.TabIndex = 240
        Me.txt_DescripChart.Text = "UltraTextEditor8"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(80, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 24)
        Me.Label17.TabIndex = 241
        Me.Label17.Text = "Chart Description"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 550)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(776, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(488, 8)
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
        Me.btnCancel.Location = New System.Drawing.Point(584, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(680, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_Remark)
        Me.Panel2.Controls.Add(Me.chk_IsDeleted)
        Me.Panel2.Controls.Add(Me.chk_IsBoughtOut)
        Me.Panel2.Controls.Add(Me.cmb_material)
        Me.Panel2.Controls.Add(Me.txt_Weight)
        Me.Panel2.Controls.Add(Me.lblWeight)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_Description)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_ItemNum)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextDrgNum)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 264)
        Me.Panel2.TabIndex = 222
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(112, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 40)
        Me.Label10.TabIndex = 229
        Me.Label10.Text = "Remark"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(216, 192)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(464, 48)
        Me.txt_Remark.TabIndex = 228
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'chk_IsDeleted
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.SizeInPoints = 8.0!
        Me.chk_IsDeleted.Appearance = Appearance4
        Me.chk_IsDeleted.Location = New System.Drawing.Point(488, 56)
        Me.chk_IsDeleted.Name = "chk_IsDeleted"
        Me.chk_IsDeleted.Size = New System.Drawing.Size(152, 16)
        Me.chk_IsDeleted.TabIndex = 226
        Me.chk_IsDeleted.Text = "Part is Deleted"
        '
        'chk_IsBoughtOut
        '
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.SizeInPoints = 8.0!
        Me.chk_IsBoughtOut.Appearance = Appearance5
        Me.chk_IsBoughtOut.Location = New System.Drawing.Point(328, 56)
        Me.chk_IsBoughtOut.Name = "chk_IsBoughtOut"
        Me.chk_IsBoughtOut.Size = New System.Drawing.Size(152, 16)
        Me.chk_IsBoughtOut.TabIndex = 225
        Me.chk_IsBoughtOut.Text = "Part is Bought Out"
        '
        'cmb_material
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.SizeInPoints = 10.0!
        Me.cmb_material.Appearance = Appearance6
        Me.cmb_material.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_material.Location = New System.Drawing.Point(216, 120)
        Me.cmb_material.Name = "cmb_material"
        Me.cmb_material.Size = New System.Drawing.Size(216, 24)
        Me.cmb_material.TabIndex = 224
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(496, 160)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(72, 21)
        Me.txt_Weight.TabIndex = 223
        Me.txt_Weight.Text = "UltraTextEditor8"
        '
        'lblWeight
        '
        Me.lblWeight.Location = New System.Drawing.Point(352, 160)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(136, 16)
        Me.lblWeight.TabIndex = 222
        Me.lblWeight.Text = "Weight"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Qty)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(104, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 32)
        Me.Panel1.TabIndex = 221
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 8)
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
        Me.txt_Qty.TabIndex = 176
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
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(112, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 220
        Me.Label12.Text = "Material"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Description
        '
        Me.txt_Description.Location = New System.Drawing.Point(216, 88)
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(376, 21)
        Me.txt_Description.TabIndex = 217
        Me.txt_Description.Text = "UltraTextEditor8"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "BOM Description"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ItemNum
        '
        Me.txt_ItemNum.Location = New System.Drawing.Point(216, 56)
        Me.txt_ItemNum.Name = "txt_ItemNum"
        Me.txt_ItemNum.Size = New System.Drawing.Size(96, 21)
        Me.txt_ItemNum.TabIndex = 216
        Me.txt_ItemNum.Text = "UltraTextEditor8"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(72, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 16)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "Item Number"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(72, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Drawing Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextDrgNum
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.SizeInPoints = 10.0!
        Me.TextDrgNum.Appearance = Appearance7
        Me.TextDrgNum.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.TextDrgNum.Location = New System.Drawing.Point(216, 24)
        Me.TextDrgNum.Name = "TextDrgNum"
        Me.TextDrgNum.ReadOnly = True
        Me.TextDrgNum.Size = New System.Drawing.Size(384, 20)
        Me.TextDrgNum.TabIndex = 215
        Me.TextDrgNum.Text = "UltraTextEditor3"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 264)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(776, 286)
        Me.UltraTabControl1.TabIndex = 223
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Details"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "CNC file"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Gasket / Hardware Charts"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(772, 260)
        '
        'frmDrgPart
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Drawing Part"
        Me.ClientSize = New System.Drawing.Size(776, 598)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmDrgPart"
        Me.Text = "Drawing Part"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_OuterDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InnerDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Length, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Thk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MatSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.txt_DescripChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsBoughtOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ItemNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDrgNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextDrgNum As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class

