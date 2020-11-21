Imports System.Xml
Imports Infragistics.Win.UltraWinTabControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTFNest
    Inherits risersoft.shared.win.frmWizMax

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab22 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab23 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelFK = New System.Windows.Forms.Label()
        Me.cmb_CNCTypeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NestNumFab = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_Thk = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Nestnum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4.SuspendLayout()
        Me.PanelBtn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_CNCTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NestNumFab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Thk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Nestnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraProgressBar1
        '
        Me.UltraProgressBar1.Size = New System.Drawing.Size(310, 31)
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 529)
        Me.Panel4.Size = New System.Drawing.Size(778, 31)
        '
        'PanelBtn
        '
        Me.PanelBtn.Location = New System.Drawing.Point(0, 481)
        Me.PanelBtn.Size = New System.Drawing.Size(778, 48)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(515, 0)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(603, 0)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(690, 0)
        '
        'btnNav1
        '
        Me.btnNav1.Location = New System.Drawing.Point(418, 0)
        '
        'btnNav2
        '
        Me.btnNav2.Location = New System.Drawing.Point(538, 0)
        '
        'btnNav3
        '
        Me.btnNav3.Location = New System.Drawing.Point(658, 0)
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(774, 355)
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(774, 355)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(774, 355)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelFK)
        Me.Panel1.Controls.Add(Me.cmb_CNCTypeID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_NestNumFab)
        Me.Panel1.Controls.Add(Me.cmb_Thk)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_Nestnum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 100)
        Me.Panel1.TabIndex = 4
        '
        'LabelFK
        '
        Me.LabelFK.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelFK.Location = New System.Drawing.Point(35, 41)
        Me.LabelFK.Name = "LabelFK"
        Me.LabelFK.Size = New System.Drawing.Size(88, 16)
        Me.LabelFK.TabIndex = 174
        Me.LabelFK.Text = "CNC Type"
        Me.LabelFK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CNCTypeID
        '
        Me.cmb_CNCTypeID.DataMember = "Items"
        Me.cmb_CNCTypeID.DisplayMember = "CatName"
        Me.cmb_CNCTypeID.Location = New System.Drawing.Point(131, 41)
        Me.cmb_CNCTypeID.MaxDropDownItems = 15
        Me.cmb_CNCTypeID.Name = "cmb_CNCTypeID"
        Me.cmb_CNCTypeID.Size = New System.Drawing.Size(377, 22)
        Me.cmb_CNCTypeID.TabIndex = 175
        Me.cmb_CNCTypeID.Text = "UltraCombo1"
        Me.cmb_CNCTypeID.ValueMember = "ItemcatID"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(14, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Nest No. Fabrication"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NestNumFab
        '
        Me.txt_NestNumFab.Location = New System.Drawing.Point(131, 69)
        Me.txt_NestNumFab.Name = "txt_NestNumFab"
        Me.txt_NestNumFab.Size = New System.Drawing.Size(120, 21)
        Me.txt_NestNumFab.TabIndex = 172
        Me.txt_NestNumFab.Text = "UltraTextEditor1"
        '
        'cmb_Thk
        '
        Me.cmb_Thk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_Thk.Location = New System.Drawing.Point(131, 12)
        Me.cmb_Thk.Name = "cmb_Thk"
        Me.cmb_Thk.Size = New System.Drawing.Size(129, 23)
        Me.cmb_Thk.TabIndex = 171
        Me.cmb_Thk.Text = "UltraCombo4"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(43, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "Thickness"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(298, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Nest No. Max"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Nestnum
        '
        Me.txt_Nestnum.Location = New System.Drawing.Point(388, 69)
        Me.txt_Nestnum.Name = "txt_Nestnum"
        Me.txt_Nestnum.ReadOnly = True
        Me.txt_Nestnum.Size = New System.Drawing.Size(120, 21)
        Me.txt_Nestnum.TabIndex = 168
        Me.txt_Nestnum.Text = "UltraTextEditor1"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 100)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance11.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance11
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.ShowTabListButton = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraTabControl1.Size = New System.Drawing.Size(778, 381)
        Me.UltraTabControl1.TabIndex = 10
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab22.Key = "def"
        UltraTab22.TabPage = Me.UltraTabPageControl17
        UltraTab22.Text = "Nest Definition"
        UltraTab23.Key = "items"
        UltraTab23.TabPage = Me.UltraTabPageControl12
        UltraTab23.Text = "Nest Items"
        UltraTab1.Key = "output"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Nest Output"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab22, UltraTab23, UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(774, 355)
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(756, 409)
        '
        'frmTFNest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Nest"
        Me.ClientSize = New System.Drawing.Size(778, 560)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTFNest"
        Me.Text = "Nest"
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.PanelBtn, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.UltraTabControl1, 0)
        Me.Panel4.ResumeLayout(False)
        Me.PanelBtn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_CNCTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NestNumFab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Thk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Nestnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelFK As System.Windows.Forms.Label
    Friend WithEvents cmb_CNCTypeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_NestNumFab As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_Thk As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Nestnum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl

#End Region
End Class

