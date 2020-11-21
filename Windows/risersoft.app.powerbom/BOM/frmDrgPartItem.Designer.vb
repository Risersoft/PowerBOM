Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmDrgPartItem
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlUpLoad1 As ctlUpLoad
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents combosubcat As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents PanelChart As System.Windows.Forms.Panel
    Friend WithEvents txt_DescripChart As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chk_SeeDetail As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_IsManualWt As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_pValueA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents PanelDim As System.Windows.Forms.Panel
    Friend WithEvents utcReductions As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlXMLVList1 As ctlXMLVList
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlXMLVList2 As ctlXMLVList
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlXMLVList3 As ctlXMLVList
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlXMLVList4 As ctlXMLVList
    Friend WithEvents utcSectionType As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_TotalArea As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_TotAreaRemoved As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Thk As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_CalcWeightEach As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Density As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_AreaPerMtr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_WtPerMtr As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_MatSection As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utcDimType As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utcDimLenWid As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelWidth As System.Windows.Forms.Label
    Friend WithEvents txt_Width As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Length As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents lbllen1 As System.Windows.Forms.Label
    Friend WithEvents lblwid1 As System.Windows.Forms.Label
    Friend WithEvents lbllen2 As System.Windows.Forms.Label
    Friend WithEvents txt_Width2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblwid2 As System.Windows.Forms.Label
    Friend WithEvents txt_Length2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmb_GasketTypeCode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_OuterDia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_InnerDia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmb_ThkParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_OuterDiaParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_InnerDiaParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmb_WidthParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_LengthParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_Width2ParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_Length2ParamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chk_HasNoJoints As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnOpen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelSectionWt As System.Windows.Forms.Label
    Friend WithEvents CtlUpLoad2 As ctlUpLoad
    Friend WithEvents CtlUpLoad3 As ctlUpLoad
    Friend WithEvents CtlUpLoad4 As ctlUpLoad
    Friend WithEvents chk_NoCommonCut As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelWidth = New System.Windows.Forms.Label()
        Me.cmb_WidthParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_LengthParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_Width = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Length = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_Width2ParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_Length2ParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lbllen1 = New System.Windows.Forms.Label()
        Me.lblwid1 = New System.Windows.Forms.Label()
        Me.lbllen2 = New System.Windows.Forms.Label()
        Me.txt_Width2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblwid2 = New System.Windows.Forms.Label()
        Me.txt_Length2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_GasketTypeCode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlXMLVList1 = New risersoft.[shared].win.ctlXMLVList()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlXMLVList2 = New risersoft.[shared].win.ctlXMLVList()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlXMLVList3 = New risersoft.[shared].win.ctlXMLVList()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlXMLVList4 = New risersoft.[shared].win.ctlXMLVList()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.utcDimLenWid = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_OuterDiaParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_InnerDiaParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_OuterDia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_InnerDia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_TotalArea = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_TotAreaRemoved = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Thk = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_HasNoJoints = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_CalcWeightEach = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Density = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_AreaPerMtr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_WtPerMtr = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.LabelSectionWt = New System.Windows.Forms.Label()
        Me.txt_MatSection = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmb_ThkParamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.utcReductions = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.PanelDim = New System.Windows.Forms.Panel()
        Me.utcDimType = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.utcSectionType = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlUpLoad6 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad5 = New risersoft.[shared].win.ctlUpLoad()
        Me.chk_ExcludeCNC = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_NoCommonCut = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.CtlUpLoad4 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad3 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad2 = New risersoft.[shared].win.ctlUpLoad()
        Me.CtlUpLoad1 = New risersoft.[shared].win.ctlUpLoad()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnOpen = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chk_ShowNonStd = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsManualWt = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_SeeDetail = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.PanelChart = New System.Windows.Forms.Panel()
        Me.txt_DescripChart = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.combosubcat = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_IsDeleted = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsBoughtOut = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_pValueA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.cmb_WidthParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_LengthParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Length, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.cmb_Width2ParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Length2ParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Width2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Length2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_GasketTypeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl10.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.utcDimLenWid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcDimLenWid.SuspendLayout()
        Me.UltraTabSharedControlsPage5.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.cmb_OuterDiaParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_InnerDiaParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OuterDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InnerDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.txt_TotalArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotAreaRemoved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Thk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_HasNoJoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CalcWeightEach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Density, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl14.SuspendLayout()
        CType(Me.txt_AreaPerMtr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WtPerMtr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MatSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.cmb_ThkParamID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.utcReductions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcReductions.SuspendLayout()
        Me.PanelDim.SuspendLayout()
        CType(Me.utcDimType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcDimType.SuspendLayout()
        CType(Me.utcSectionType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcSectionType.SuspendLayout()
        Me.UltraTabSharedControlsPage3.SuspendLayout()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.chk_ExcludeCNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_NoCommonCut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.chk_ShowNonStd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsManualWt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_SeeDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChart.SuspendLayout()
        CType(Me.txt_DescripChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combosubcat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsDeleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsBoughtOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ItemNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextDrgNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.Label5)
        Me.UltraTabPageControl13.Controls.Add(Me.LabelWidth)
        Me.UltraTabPageControl13.Controls.Add(Me.cmb_WidthParamID)
        Me.UltraTabPageControl13.Controls.Add(Me.cmb_LengthParamID)
        Me.UltraTabPageControl13.Controls.Add(Me.txt_Width)
        Me.UltraTabPageControl13.Controls.Add(Me.txt_Length)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(256, 130)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(40, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Length"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelWidth
        '
        Me.LabelWidth.Location = New System.Drawing.Point(40, 56)
        Me.LabelWidth.Name = "LabelWidth"
        Me.LabelWidth.Size = New System.Drawing.Size(40, 16)
        Me.LabelWidth.TabIndex = 295
        Me.LabelWidth.Text = "Width"
        Me.LabelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_WidthParamID
        '
        Me.cmb_WidthParamID.DataMember = "Items"
        Me.cmb_WidthParamID.DisplayMember = "SubCatName"
        Me.cmb_WidthParamID.Location = New System.Drawing.Point(160, 56)
        Me.cmb_WidthParamID.MaxDropDownItems = 15
        Me.cmb_WidthParamID.Name = "cmb_WidthParamID"
        Me.cmb_WidthParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_WidthParamID.TabIndex = 313
        Me.cmb_WidthParamID.ValueMember = "SubcatID"
        '
        'cmb_LengthParamID
        '
        Me.cmb_LengthParamID.DataMember = "Items"
        Me.cmb_LengthParamID.DisplayMember = "SubCatName"
        Me.cmb_LengthParamID.Location = New System.Drawing.Point(160, 32)
        Me.cmb_LengthParamID.MaxDropDownItems = 15
        Me.cmb_LengthParamID.Name = "cmb_LengthParamID"
        Me.cmb_LengthParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_LengthParamID.TabIndex = 312
        Me.cmb_LengthParamID.ValueMember = "SubcatID"
        '
        'txt_Width
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.txt_Width.Appearance = Appearance1
        Me.txt_Width.Location = New System.Drawing.Point(88, 56)
        Me.txt_Width.Name = "txt_Width"
        Me.txt_Width.Size = New System.Drawing.Size(64, 21)
        Me.txt_Width.TabIndex = 291
        Me.txt_Width.Text = "UltraTextEditor8"
        '
        'txt_Length
        '
        Appearance2.TextHAlignAsString = "Center"
        Me.txt_Length.Appearance = Appearance2
        Me.txt_Length.Location = New System.Drawing.Point(88, 32)
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.Size = New System.Drawing.Size(64, 21)
        Me.txt_Length.TabIndex = 290
        Me.txt_Length.Text = "UltraTextEditor8"
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.cmb_Width2ParamID)
        Me.UltraTabPageControl15.Controls.Add(Me.cmb_Length2ParamID)
        Me.UltraTabPageControl15.Controls.Add(Me.lbllen1)
        Me.UltraTabPageControl15.Controls.Add(Me.lblwid1)
        Me.UltraTabPageControl15.Controls.Add(Me.lbllen2)
        Me.UltraTabPageControl15.Controls.Add(Me.txt_Width2)
        Me.UltraTabPageControl15.Controls.Add(Me.lblwid2)
        Me.UltraTabPageControl15.Controls.Add(Me.txt_Length2)
        Me.UltraTabPageControl15.Controls.Add(Me.Label22)
        Me.UltraTabPageControl15.Controls.Add(Me.cmb_GasketTypeCode)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(256, 130)
        '
        'cmb_Width2ParamID
        '
        Me.cmb_Width2ParamID.DataMember = "Items"
        Me.cmb_Width2ParamID.DisplayMember = "SubCatName"
        Me.cmb_Width2ParamID.Location = New System.Drawing.Point(160, 104)
        Me.cmb_Width2ParamID.MaxDropDownItems = 15
        Me.cmb_Width2ParamID.Name = "cmb_Width2ParamID"
        Me.cmb_Width2ParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_Width2ParamID.TabIndex = 315
        Me.cmb_Width2ParamID.ValueMember = "SubcatID"
        '
        'cmb_Length2ParamID
        '
        Me.cmb_Length2ParamID.DataMember = "Items"
        Me.cmb_Length2ParamID.DisplayMember = "SubCatName"
        Me.cmb_Length2ParamID.Location = New System.Drawing.Point(160, 80)
        Me.cmb_Length2ParamID.MaxDropDownItems = 15
        Me.cmb_Length2ParamID.Name = "cmb_Length2ParamID"
        Me.cmb_Length2ParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_Length2ParamID.TabIndex = 314
        Me.cmb_Length2ParamID.ValueMember = "SubcatID"
        '
        'lbllen1
        '
        Me.lbllen1.Location = New System.Drawing.Point(8, 32)
        Me.lbllen1.Name = "lbllen1"
        Me.lbllen1.Size = New System.Drawing.Size(72, 16)
        Me.lbllen1.TabIndex = 304
        Me.lbllen1.Text = "Length"
        Me.lbllen1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblwid1
        '
        Me.lblwid1.Location = New System.Drawing.Point(8, 56)
        Me.lblwid1.Name = "lblwid1"
        Me.lblwid1.Size = New System.Drawing.Size(72, 16)
        Me.lblwid1.TabIndex = 305
        Me.lblwid1.Text = "Width"
        Me.lblwid1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbllen2
        '
        Me.lbllen2.Location = New System.Drawing.Point(8, 80)
        Me.lbllen2.Name = "lbllen2"
        Me.lbllen2.Size = New System.Drawing.Size(72, 16)
        Me.lbllen2.TabIndex = 302
        Me.lbllen2.Text = "Length"
        Me.lbllen2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Width2
        '
        Appearance3.TextHAlignAsString = "Center"
        Me.txt_Width2.Appearance = Appearance3
        Me.txt_Width2.Location = New System.Drawing.Point(88, 104)
        Me.txt_Width2.Name = "txt_Width2"
        Me.txt_Width2.Size = New System.Drawing.Size(64, 21)
        Me.txt_Width2.TabIndex = 301
        Me.txt_Width2.Text = "UltraTextEditor8"
        '
        'lblwid2
        '
        Me.lblwid2.Location = New System.Drawing.Point(8, 104)
        Me.lblwid2.Name = "lblwid2"
        Me.lblwid2.Size = New System.Drawing.Size(72, 16)
        Me.lblwid2.TabIndex = 303
        Me.lblwid2.Text = "Width"
        Me.lblwid2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Length2
        '
        Appearance4.TextHAlignAsString = "Center"
        Me.txt_Length2.Appearance = Appearance4
        Me.txt_Length2.Location = New System.Drawing.Point(88, 80)
        Me.txt_Length2.Name = "txt_Length2"
        Me.txt_Length2.Size = New System.Drawing.Size(64, 21)
        Me.txt_Length2.TabIndex = 300
        Me.txt_Length2.Text = "UltraTextEditor8"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(40, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 16)
        Me.Label22.TabIndex = 299
        Me.Label22.Text = "Type"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_GasketTypeCode
        '
        Me.cmb_GasketTypeCode.Location = New System.Drawing.Point(88, 8)
        Me.cmb_GasketTypeCode.Name = "cmb_GasketTypeCode"
        Me.cmb_GasketTypeCode.Size = New System.Drawing.Size(88, 21)
        Me.cmb_GasketTypeCode.TabIndex = 298
        Me.cmb_GasketTypeCode.Text = "UltraComboEditor1"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.CtlXMLVList1)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(0, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(544, 182)
        '
        'CtlXMLVList1
        '
        Me.CtlXMLVList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlXMLVList1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlXMLVList1.Location = New System.Drawing.Point(0, 0)
        Me.CtlXMLVList1.Name = "CtlXMLVList1"
        Me.CtlXMLVList1.Size = New System.Drawing.Size(544, 182)
        Me.CtlXMLVList1.TabIndex = 2
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.CtlXMLVList2)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(544, 182)
        '
        'CtlXMLVList2
        '
        Me.CtlXMLVList2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlXMLVList2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlXMLVList2.Location = New System.Drawing.Point(0, 0)
        Me.CtlXMLVList2.Name = "CtlXMLVList2"
        Me.CtlXMLVList2.Size = New System.Drawing.Size(544, 182)
        Me.CtlXMLVList2.TabIndex = 1
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.CtlXMLVList3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(544, 182)
        '
        'CtlXMLVList3
        '
        Me.CtlXMLVList3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlXMLVList3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlXMLVList3.Location = New System.Drawing.Point(0, 0)
        Me.CtlXMLVList3.Name = "CtlXMLVList3"
        Me.CtlXMLVList3.Size = New System.Drawing.Size(544, 182)
        Me.CtlXMLVList3.TabIndex = 2
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.CtlXMLVList4)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(544, 182)
        '
        'CtlXMLVList4
        '
        Me.CtlXMLVList4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlXMLVList4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlXMLVList4.Location = New System.Drawing.Point(0, 0)
        Me.CtlXMLVList4.Name = "CtlXMLVList4"
        Me.CtlXMLVList4.Size = New System.Drawing.Size(544, 182)
        Me.CtlXMLVList4.TabIndex = 2
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.utcDimLenWid)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(0, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(256, 130)
        '
        'utcDimLenWid
        '
        Me.utcDimLenWid.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.utcDimLenWid.Controls.Add(Me.UltraTabPageControl13)
        Me.utcDimLenWid.Controls.Add(Me.UltraTabPageControl15)
        Me.utcDimLenWid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcDimLenWid.Location = New System.Drawing.Point(0, 0)
        Me.utcDimLenWid.Name = "utcDimLenWid"
        Me.utcDimLenWid.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.cmb_WidthParamID, Me.cmb_LengthParamID, Me.txt_Width, Me.txt_Length})
        Me.utcDimLenWid.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.utcDimLenWid.Size = New System.Drawing.Size(256, 130)
        Me.utcDimLenWid.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.utcDimLenWid.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl13
        UltraTab1.Text = "tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl15
        UltraTab2.Text = "tab2"
        Me.utcDimLenWid.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Controls.Add(Me.cmb_WidthParamID)
        Me.UltraTabSharedControlsPage5.Controls.Add(Me.cmb_LengthParamID)
        Me.UltraTabSharedControlsPage5.Controls.Add(Me.txt_Width)
        Me.UltraTabSharedControlsPage5.Controls.Add(Me.txt_Length)
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(256, 130)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_OuterDiaParamID)
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_InnerDiaParamID)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_OuterDia)
        Me.UltraTabPageControl5.Controls.Add(Me.Label14)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_InnerDia)
        Me.UltraTabPageControl5.Controls.Add(Me.Label16)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(256, 130)
        '
        'cmb_OuterDiaParamID
        '
        Me.cmb_OuterDiaParamID.DataMember = "Items"
        Me.cmb_OuterDiaParamID.DisplayMember = "SubCatName"
        Me.cmb_OuterDiaParamID.Location = New System.Drawing.Point(144, 64)
        Me.cmb_OuterDiaParamID.MaxDropDownItems = 15
        Me.cmb_OuterDiaParamID.Name = "cmb_OuterDiaParamID"
        Me.cmb_OuterDiaParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_OuterDiaParamID.TabIndex = 293
        Me.cmb_OuterDiaParamID.ValueMember = "SubcatID"
        '
        'cmb_InnerDiaParamID
        '
        Me.cmb_InnerDiaParamID.DataMember = "Items"
        Me.cmb_InnerDiaParamID.DisplayMember = "SubCatName"
        Me.cmb_InnerDiaParamID.Location = New System.Drawing.Point(144, 32)
        Me.cmb_InnerDiaParamID.MaxDropDownItems = 15
        Me.cmb_InnerDiaParamID.Name = "cmb_InnerDiaParamID"
        Me.cmb_InnerDiaParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_InnerDiaParamID.TabIndex = 292
        Me.cmb_InnerDiaParamID.ValueMember = "SubcatID"
        '
        'txt_OuterDia
        '
        Appearance5.TextHAlignAsString = "Center"
        Me.txt_OuterDia.Appearance = Appearance5
        Me.txt_OuterDia.Location = New System.Drawing.Point(72, 64)
        Me.txt_OuterDia.Name = "txt_OuterDia"
        Me.txt_OuterDia.Size = New System.Drawing.Size(64, 21)
        Me.txt_OuterDia.TabIndex = 285
        Me.txt_OuterDia.Text = "UltraTextEditor8"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 287
        Me.Label14.Text = "OD"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_InnerDia
        '
        Appearance6.TextHAlignAsString = "Center"
        Me.txt_InnerDia.Appearance = Appearance6
        Me.txt_InnerDia.Location = New System.Drawing.Point(72, 32)
        Me.txt_InnerDia.Name = "txt_InnerDia"
        Me.txt_InnerDia.Size = New System.Drawing.Size(64, 21)
        Me.txt_InnerDia.TabIndex = 284
        Me.txt_InnerDia.Text = "UltraTextEditor8"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 286
        Me.Label16.Text = "ID"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.txt_TotalArea)
        Me.UltraTabPageControl8.Controls.Add(Me.Label20)
        Me.UltraTabPageControl8.Controls.Add(Me.txt_TotAreaRemoved)
        Me.UltraTabPageControl8.Controls.Add(Me.Label19)
        Me.UltraTabPageControl8.Controls.Add(Me.Label7)
        Me.UltraTabPageControl8.Controls.Add(Me.txt_Thk)
        Me.UltraTabPageControl8.Controls.Add(Me.Label3)
        Me.UltraTabPageControl8.Controls.Add(Me.chk_HasNoJoints)
        Me.UltraTabPageControl8.Controls.Add(Me.Label21)
        Me.UltraTabPageControl8.Controls.Add(Me.txt_CalcWeightEach)
        Me.UltraTabPageControl8.Controls.Add(Me.txt_Density)
        Me.UltraTabPageControl8.Controls.Add(Me.Label15)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(0, 22)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(288, 130)
        '
        'txt_TotalArea
        '
        Me.txt_TotalArea.Location = New System.Drawing.Point(128, 80)
        Me.txt_TotalArea.Name = "txt_TotalArea"
        Me.txt_TotalArea.ReadOnly = True
        Me.txt_TotalArea.Size = New System.Drawing.Size(112, 21)
        Me.txt_TotalArea.TabIndex = 301
        Me.txt_TotalArea.TabStop = False
        Me.txt_TotalArea.Text = "UltraTextEditor5"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(8, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 16)
        Me.Label20.TabIndex = 300
        Me.Label20.Text = "Total Area"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_TotAreaRemoved
        '
        Me.txt_TotAreaRemoved.Location = New System.Drawing.Point(128, 56)
        Me.txt_TotAreaRemoved.Name = "txt_TotAreaRemoved"
        Me.txt_TotAreaRemoved.ReadOnly = True
        Me.txt_TotAreaRemoved.Size = New System.Drawing.Size(112, 21)
        Me.txt_TotAreaRemoved.TabIndex = 299
        Me.txt_TotAreaRemoved.TabStop = False
        Me.txt_TotAreaRemoved.Text = "UltraTextEditor5"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(8, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 16)
        Me.Label19.TabIndex = 298
        Me.Label19.Text = "Total Area Removed"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(200, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 297
        Me.Label7.Text = "mm"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Thk
        '
        Appearance7.TextHAlignAsString = "Center"
        Me.txt_Thk.Appearance = Appearance7
        Me.txt_Thk.Location = New System.Drawing.Point(128, 8)
        Me.txt_Thk.Name = "txt_Thk"
        Me.txt_Thk.ReadOnly = True
        Me.txt_Thk.Size = New System.Drawing.Size(64, 21)
        Me.txt_Thk.TabIndex = 295
        Me.txt_Thk.TabStop = False
        Me.txt_Thk.Text = "UltraTextEditor8"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 296
        Me.Label3.Text = "Thickness"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_HasNoJoints
        '
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.SizeInPoints = 8.0!
        Me.chk_HasNoJoints.Appearance = Appearance8
        Me.chk_HasNoJoints.Location = New System.Drawing.Point(200, 104)
        Me.chk_HasNoJoints.Name = "chk_HasNoJoints"
        Me.chk_HasNoJoints.Size = New System.Drawing.Size(88, 24)
        Me.chk_HasNoJoints.TabIndex = 294
        Me.chk_HasNoJoints.Text = "Does not have joints"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(48, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 24)
        Me.Label21.TabIndex = 293
        Me.Label21.Text = "Calculated Weight Each"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CalcWeightEach
        '
        Me.txt_CalcWeightEach.Location = New System.Drawing.Point(128, 104)
        Me.txt_CalcWeightEach.Name = "txt_CalcWeightEach"
        Me.txt_CalcWeightEach.ReadOnly = True
        Me.txt_CalcWeightEach.Size = New System.Drawing.Size(64, 21)
        Me.txt_CalcWeightEach.TabIndex = 292
        Me.txt_CalcWeightEach.TabStop = False
        Me.txt_CalcWeightEach.Text = "UltraTextEditor8"
        '
        'txt_Density
        '
        Me.txt_Density.Location = New System.Drawing.Point(128, 32)
        Me.txt_Density.Name = "txt_Density"
        Me.txt_Density.ReadOnly = True
        Me.txt_Density.Size = New System.Drawing.Size(112, 21)
        Me.txt_Density.TabIndex = 77
        Me.txt_Density.TabStop = False
        Me.txt_Density.Text = "UltraTextEditor5"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(8, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 16)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "Density kg/dm3 [kg/l]"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.txt_AreaPerMtr)
        Me.UltraTabPageControl14.Controls.Add(Me.Label13)
        Me.UltraTabPageControl14.Controls.Add(Me.txt_WtPerMtr)
        Me.UltraTabPageControl14.Controls.Add(Me.LabelSectionWt)
        Me.UltraTabPageControl14.Controls.Add(Me.txt_MatSection)
        Me.UltraTabPageControl14.Controls.Add(Me.Label2)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(288, 130)
        '
        'txt_AreaPerMtr
        '
        Me.txt_AreaPerMtr.Location = New System.Drawing.Point(128, 80)
        Me.txt_AreaPerMtr.Name = "txt_AreaPerMtr"
        Me.txt_AreaPerMtr.ReadOnly = True
        Me.txt_AreaPerMtr.Size = New System.Drawing.Size(128, 21)
        Me.txt_AreaPerMtr.TabIndex = 297
        Me.txt_AreaPerMtr.TabStop = False
        Me.txt_AreaPerMtr.Text = "UltraTextEditor4"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(24, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 296
        Me.Label13.Text = "Area SQ Mtr / Mtr"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_WtPerMtr
        '
        Me.txt_WtPerMtr.Location = New System.Drawing.Point(128, 56)
        Me.txt_WtPerMtr.Name = "txt_WtPerMtr"
        Me.txt_WtPerMtr.ReadOnly = True
        Me.txt_WtPerMtr.Size = New System.Drawing.Size(88, 21)
        Me.txt_WtPerMtr.TabIndex = 295
        Me.txt_WtPerMtr.TabStop = False
        Me.txt_WtPerMtr.Text = "UltraTextEditor3"
        '
        'LabelSectionWt
        '
        Me.LabelSectionWt.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.LabelSectionWt.Location = New System.Drawing.Point(2, 59)
        Me.LabelSectionWt.Name = "LabelSectionWt"
        Me.LabelSectionWt.Size = New System.Drawing.Size(118, 16)
        Me.LabelSectionWt.TabIndex = 294
        Me.LabelSectionWt.Text = "Weight / Mtr"
        Me.LabelSectionWt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MatSection
        '
        Me.txt_MatSection.Location = New System.Drawing.Point(128, 8)
        Me.txt_MatSection.Name = "txt_MatSection"
        Me.txt_MatSection.ReadOnly = True
        Me.txt_MatSection.Size = New System.Drawing.Size(152, 21)
        Me.txt_MatSection.TabIndex = 292
        Me.txt_MatSection.TabStop = False
        Me.txt_MatSection.Text = "UltraTextEditor8"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 293
        Me.Label2.Text = "Material Section"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Label24)
        Me.UltraTabPageControl7.Controls.Add(Me.Label25)
        Me.UltraTabPageControl7.Controls.Add(Me.cmb_ThkParamID)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(288, 130)
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(216, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 16)
        Me.Label24.TabIndex = 299
        Me.Label24.Text = "mm"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(40, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 16)
        Me.Label25.TabIndex = 298
        Me.Label25.Text = "Thickness"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_ThkParamID
        '
        Me.cmb_ThkParamID.DataMember = "Items"
        Me.cmb_ThkParamID.DisplayMember = "SubCatName"
        Me.cmb_ThkParamID.Location = New System.Drawing.Point(128, 8)
        Me.cmb_ThkParamID.MaxDropDownItems = 15
        Me.cmb_ThkParamID.Name = "cmb_ThkParamID"
        Me.cmb_ThkParamID.Size = New System.Drawing.Size(88, 22)
        Me.cmb_ThkParamID.TabIndex = 294
        Me.cmb_ThkParamID.ValueMember = "SubcatID"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.PanelDetail)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(932, 356)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(388, 356)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'PanelDetail
        '
        Me.PanelDetail.Controls.Add(Me.Panel5)
        Me.PanelDetail.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDetail.Location = New System.Drawing.Point(388, 0)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(544, 356)
        Me.PanelDetail.TabIndex = 242
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.utcReductions)
        Me.Panel5.Controls.Add(Me.PanelDim)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(544, 356)
        Me.Panel5.TabIndex = 0
        '
        'utcReductions
        '
        Me.utcReductions.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.utcReductions.Controls.Add(Me.UltraTabPageControl6)
        Me.utcReductions.Controls.Add(Me.UltraTabPageControl9)
        Me.utcReductions.Controls.Add(Me.UltraTabPageControl3)
        Me.utcReductions.Controls.Add(Me.UltraTabPageControl10)
        Me.utcReductions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcReductions.Location = New System.Drawing.Point(0, 152)
        Me.utcReductions.Name = "utcReductions"
        Me.utcReductions.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.utcReductions.Size = New System.Drawing.Size(544, 204)
        Me.utcReductions.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.utcReductions.TabIndex = 4
        UltraTab3.TabPage = Me.UltraTabPageControl6
        UltraTab3.Text = "Reductions Rectangular"
        UltraTab4.TabPage = Me.UltraTabPageControl9
        UltraTab4.Text = "Reductions Round"
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Reductions Triangle"
        UltraTab6.TabPage = Me.UltraTabPageControl10
        UltraTab6.Text = "Reductions Radius"
        Me.utcReductions.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5, UltraTab6})
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(544, 182)
        '
        'PanelDim
        '
        Me.PanelDim.Controls.Add(Me.utcDimType)
        Me.PanelDim.Controls.Add(Me.utcSectionType)
        Me.PanelDim.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDim.Location = New System.Drawing.Point(0, 0)
        Me.PanelDim.Name = "PanelDim"
        Me.PanelDim.Size = New System.Drawing.Size(544, 152)
        Me.PanelDim.TabIndex = 0
        '
        'utcDimType
        '
        Me.utcDimType.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.utcDimType.Controls.Add(Me.UltraTabPageControl4)
        Me.utcDimType.Controls.Add(Me.UltraTabPageControl5)
        Me.utcDimType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcDimType.Location = New System.Drawing.Point(288, 0)
        Me.utcDimType.Name = "utcDimType"
        Me.utcDimType.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.utcDimType.Size = New System.Drawing.Size(256, 152)
        Me.utcDimType.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.utcDimType.TabIndex = 5
        UltraTab7.Key = "len"
        UltraTab7.TabPage = Me.UltraTabPageControl4
        UltraTab7.Text = "Length / Width"
        UltraTab8.Key = "od"
        UltraTab8.TabPage = Me.UltraTabPageControl5
        UltraTab8.Text = "ID / OD"
        Me.utcDimType.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(256, 130)
        '
        'utcSectionType
        '
        Me.utcSectionType.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.utcSectionType.Controls.Add(Me.UltraTabPageControl8)
        Me.utcSectionType.Controls.Add(Me.UltraTabPageControl14)
        Me.utcSectionType.Controls.Add(Me.UltraTabPageControl7)
        Me.utcSectionType.Dock = System.Windows.Forms.DockStyle.Left
        Me.utcSectionType.Location = New System.Drawing.Point(0, 0)
        Me.utcSectionType.Name = "utcSectionType"
        Me.utcSectionType.SharedControls.AddRange(New System.Windows.Forms.Control() {Me.chk_HasNoJoints, Me.Label21, Me.txt_CalcWeightEach, Me.txt_Density, Me.Label15})
        Me.utcSectionType.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.utcSectionType.Size = New System.Drawing.Size(288, 152)
        Me.utcSectionType.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.utcSectionType.TabIndex = 4
        UltraTab9.Key = "thk"
        UltraTab9.TabPage = Me.UltraTabPageControl8
        UltraTab9.Text = "Fixed Thickness"
        UltraTab10.Key = "section"
        UltraTab10.TabPage = Me.UltraTabPageControl14
        UltraTab10.Text = "Section"
        UltraTab11.Key = "varthk"
        UltraTab11.TabPage = Me.UltraTabPageControl7
        UltraTab11.Text = "Variable Thickness"
        Me.utcSectionType.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab10, UltraTab11})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Controls.Add(Me.chk_HasNoJoints)
        Me.UltraTabSharedControlsPage3.Controls.Add(Me.Label21)
        Me.UltraTabSharedControlsPage3.Controls.Add(Me.txt_CalcWeightEach)
        Me.UltraTabSharedControlsPage3.Controls.Add(Me.txt_Density)
        Me.UltraTabSharedControlsPage3.Controls.Add(Me.Label15)
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(288, 130)
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl12.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(932, 356)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 176)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(932, 132)
        Me.UltraGrid3.TabIndex = 4
        Me.UltraGrid3.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 308)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(932, 48)
        Me.Panel3.TabIndex = 3
        Me.Panel3.Visible = False
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(932, 176)
        Me.UltraGrid2.TabIndex = 1
        Me.UltraGrid2.Text = "Delivery Schedule"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad6)
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad5)
        Me.UltraTabPageControl2.Controls.Add(Me.chk_ExcludeCNC)
        Me.UltraTabPageControl2.Controls.Add(Me.chk_NoCommonCut)
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad4)
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad3)
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad2)
        Me.UltraTabPageControl2.Controls.Add(Me.CtlUpLoad1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(932, 356)
        '
        'CtlUpLoad6
        '
        Me.CtlUpLoad6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad6.Location = New System.Drawing.Point(0, 200)
        Me.CtlUpLoad6.Name = "CtlUpLoad6"
        Me.CtlUpLoad6.Size = New System.Drawing.Size(932, 40)
        Me.CtlUpLoad6.TabIndex = 298
        Me.CtlUpLoad6.Tag = "6"
        '
        'CtlUpLoad5
        '
        Me.CtlUpLoad5.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad5.Location = New System.Drawing.Point(0, 160)
        Me.CtlUpLoad5.Name = "CtlUpLoad5"
        Me.CtlUpLoad5.Size = New System.Drawing.Size(932, 40)
        Me.CtlUpLoad5.TabIndex = 297
        Me.CtlUpLoad5.Tag = "5"
        '
        'chk_ExcludeCNC
        '
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.FontData.SizeInPoints = 12.0!
        Me.chk_ExcludeCNC.Appearance = Appearance19
        Me.chk_ExcludeCNC.Location = New System.Drawing.Point(298, 246)
        Me.chk_ExcludeCNC.Name = "chk_ExcludeCNC"
        Me.chk_ExcludeCNC.Size = New System.Drawing.Size(344, 24)
        Me.chk_ExcludeCNC.TabIndex = 296
        Me.chk_ExcludeCNC.Text = "Exclude this part from CNC nesting"
        '
        'chk_NoCommonCut
        '
        Appearance21.FontData.BoldAsString = "True"
        Appearance21.FontData.SizeInPoints = 12.0!
        Me.chk_NoCommonCut.Appearance = Appearance21
        Me.chk_NoCommonCut.Location = New System.Drawing.Point(300, 276)
        Me.chk_NoCommonCut.Name = "chk_NoCommonCut"
        Me.chk_NoCommonCut.Size = New System.Drawing.Size(344, 24)
        Me.chk_NoCommonCut.TabIndex = 295
        Me.chk_NoCommonCut.Text = "Do not involve the part in Common Cut"
        '
        'CtlUpLoad4
        '
        Me.CtlUpLoad4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad4.Location = New System.Drawing.Point(0, 120)
        Me.CtlUpLoad4.Name = "CtlUpLoad4"
        Me.CtlUpLoad4.Size = New System.Drawing.Size(932, 40)
        Me.CtlUpLoad4.TabIndex = 3
        Me.CtlUpLoad4.Tag = "4"
        '
        'CtlUpLoad3
        '
        Me.CtlUpLoad3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad3.Location = New System.Drawing.Point(0, 80)
        Me.CtlUpLoad3.Name = "CtlUpLoad3"
        Me.CtlUpLoad3.Size = New System.Drawing.Size(932, 40)
        Me.CtlUpLoad3.TabIndex = 2
        Me.CtlUpLoad3.Tag = "3"
        '
        'CtlUpLoad2
        '
        Me.CtlUpLoad2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad2.Location = New System.Drawing.Point(0, 40)
        Me.CtlUpLoad2.Name = "CtlUpLoad2"
        Me.CtlUpLoad2.Size = New System.Drawing.Size(932, 40)
        Me.CtlUpLoad2.TabIndex = 1
        Me.CtlUpLoad2.Tag = "2"
        '
        'CtlUpLoad1
        '
        Me.CtlUpLoad1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlUpLoad1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad1.Location = New System.Drawing.Point(0, 0)
        Me.CtlUpLoad1.Name = "CtlUpLoad1"
        Me.CtlUpLoad1.Size = New System.Drawing.Size(932, 40)
        Me.CtlUpLoad1.TabIndex = 0
        Me.CtlUpLoad1.Tag = "1"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.UltraTree1)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(932, 356)
        '
        'UltraTree1
        '
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTree1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTree1.Name = "UltraTree1"
        Me.UltraTree1.Size = New System.Drawing.Size(932, 356)
        Me.UltraTree1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnOpen)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 598)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(936, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.FontData.BoldAsString = "True"
        Me.btnOpen.Appearance = Appearance9
        Me.btnOpen.Location = New System.Drawing.Point(544, 8)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(88, 32)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "Open as General Part"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance10.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance10
        Me.btnSave.Location = New System.Drawing.Point(648, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance11.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance11
        Me.btnCancel.Location = New System.Drawing.Point(744, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance12
        Me.btnOK.Location = New System.Drawing.Point(840, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chk_ShowNonStd)
        Me.Panel2.Controls.Add(Me.chk_IsManualWt)
        Me.Panel2.Controls.Add(Me.chk_SeeDetail)
        Me.Panel2.Controls.Add(Me.PanelChart)
        Me.Panel2.Controls.Add(Me.combosubcat)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_Remark)
        Me.Panel2.Controls.Add(Me.chk_IsDeleted)
        Me.Panel2.Controls.Add(Me.chk_IsBoughtOut)
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
        Me.Panel2.Size = New System.Drawing.Size(936, 216)
        Me.Panel2.TabIndex = 222
        '
        'chk_ShowNonStd
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.SizeInPoints = 8.0!
        Me.chk_ShowNonStd.Appearance = Appearance14
        Me.chk_ShowNonStd.Location = New System.Drawing.Point(656, 19)
        Me.chk_ShowNonStd.Name = "chk_ShowNonStd"
        Me.chk_ShowNonStd.Size = New System.Drawing.Size(222, 16)
        Me.chk_ShowNonStd.TabIndex = 234
        Me.chk_ShowNonStd.Text = "Show Non-Standard Materials Also"
        '
        'chk_IsManualWt
        '
        Appearance13.FontData.BoldAsString = "False"
        Appearance13.FontData.SizeInPoints = 8.0!
        Me.chk_IsManualWt.Appearance = Appearance13
        Me.chk_IsManualWt.Location = New System.Drawing.Point(520, 144)
        Me.chk_IsManualWt.Name = "chk_IsManualWt"
        Me.chk_IsManualWt.Size = New System.Drawing.Size(128, 16)
        Me.chk_IsManualWt.TabIndex = 233
        Me.chk_IsManualWt.Text = "Feed Manual Weight"
        '
        'chk_SeeDetail
        '
        Appearance20.FontData.BoldAsString = "False"
        Appearance20.FontData.SizeInPoints = 8.0!
        Me.chk_SeeDetail.Appearance = Appearance20
        Me.chk_SeeDetail.Location = New System.Drawing.Point(568, 176)
        Me.chk_SeeDetail.Name = "chk_SeeDetail"
        Me.chk_SeeDetail.Size = New System.Drawing.Size(80, 16)
        Me.chk_SeeDetail.TabIndex = 232
        Me.chk_SeeDetail.Text = "See Detail"
        '
        'PanelChart
        '
        Me.PanelChart.Controls.Add(Me.txt_DescripChart)
        Me.PanelChart.Controls.Add(Me.Label17)
        Me.PanelChart.Location = New System.Drawing.Point(88, 168)
        Me.PanelChart.Name = "PanelChart"
        Me.PanelChart.Size = New System.Drawing.Size(464, 40)
        Me.PanelChart.TabIndex = 231
        '
        'txt_DescripChart
        '
        Me.txt_DescripChart.Location = New System.Drawing.Point(128, 8)
        Me.txt_DescripChart.Name = "txt_DescripChart"
        Me.txt_DescripChart.Size = New System.Drawing.Size(320, 21)
        Me.txt_DescripChart.TabIndex = 244
        Me.txt_DescripChart.Text = "UltraTextEditor8"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(24, 8)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 24)
        Me.Label17.TabIndex = 245
        Me.Label17.Text = "Chart Description"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combosubcat
        '
        Me.combosubcat.DataMember = "Items"
        Me.combosubcat.DisplayMember = "SubCatName"
        Me.combosubcat.Location = New System.Drawing.Point(216, 112)
        Me.combosubcat.MaxDropDownItems = 15
        Me.combosubcat.Name = "combosubcat"
        Me.combosubcat.Size = New System.Drawing.Size(376, 22)
        Me.combosubcat.TabIndex = 230
        Me.combosubcat.Text = "UltraCombo1"
        Me.combosubcat.ValueMember = "SubcatID"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(653, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 229
        Me.Label10.Text = "Remark"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(656, 64)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(184, 144)
        Me.txt_Remark.TabIndex = 4
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'chk_IsDeleted
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.SizeInPoints = 8.0!
        Me.chk_IsDeleted.Appearance = Appearance15
        Me.chk_IsDeleted.Location = New System.Drawing.Point(488, 48)
        Me.chk_IsDeleted.Name = "chk_IsDeleted"
        Me.chk_IsDeleted.Size = New System.Drawing.Size(104, 24)
        Me.chk_IsDeleted.TabIndex = 226
        Me.chk_IsDeleted.Text = "Part is Deleted"
        '
        'chk_IsBoughtOut
        '
        Appearance16.FontData.BoldAsString = "False"
        Appearance16.FontData.SizeInPoints = 8.0!
        Me.chk_IsBoughtOut.Appearance = Appearance16
        Me.chk_IsBoughtOut.Location = New System.Drawing.Point(328, 48)
        Me.chk_IsBoughtOut.Name = "chk_IsBoughtOut"
        Me.chk_IsBoughtOut.Size = New System.Drawing.Size(120, 24)
        Me.chk_IsBoughtOut.TabIndex = 225
        Me.chk_IsBoughtOut.Text = "Part is Bought Out"
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(440, 144)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.ReadOnly = True
        Me.txt_Weight.Size = New System.Drawing.Size(72, 21)
        Me.txt_Weight.TabIndex = 3
        Me.txt_Weight.Text = "UltraTextEditor8"
        '
        'lblWeight
        '
        Me.lblWeight.Location = New System.Drawing.Point(344, 144)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(88, 16)
        Me.lblWeight.TabIndex = 222
        Me.lblWeight.Text = "Weight"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Qty)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(104, 136)
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
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(112, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 220
        Me.Label12.Text = "Sub Category"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Description
        '
        Me.txt_Description.Location = New System.Drawing.Point(216, 80)
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(376, 21)
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
        Appearance17.FontData.BoldAsString = "True"
        Appearance17.FontData.SizeInPoints = 10.0!
        Me.TextDrgNum.Appearance = Appearance17
        Me.TextDrgNum.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.TextDrgNum.Location = New System.Drawing.Point(216, 16)
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
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl16)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 216)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(936, 382)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab12.TabPage = Me.UltraTabPageControl1
        UltraTab12.Text = "Details"
        UltraTab13.Key = "param"
        UltraTab13.TabPage = Me.UltraTabPageControl12
        UltraTab13.Text = "Parameters"
        UltraTab14.TabPage = Me.UltraTabPageControl2
        UltraTab14.Text = "CNC file"
        UltraTab15.TabPage = Me.UltraTabPageControl16
        UltraTab15.Text = "BOM Tree"
        UltraTab15.Visible = False
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab12, UltraTab13, UltraTab14, UltraTab15})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(932, 356)
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(24, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 297
        Me.Label23.Text = "Length"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_pValueA
        '
        Me.cmb_pValueA.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_pValueA.Location = New System.Drawing.Point(72, 8)
        Me.cmb_pValueA.Name = "cmb_pValueA"
        Me.cmb_pValueA.Size = New System.Drawing.Size(88, 21)
        Me.cmb_pValueA.TabIndex = 296
        Me.cmb_pValueA.Text = "UltraComboEditor1"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(24, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 292
        Me.Label11.Text = "Length"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTextEditor1
        '
        Appearance18.TextHAlignAsString = "Center"
        Me.UltraTextEditor1.Appearance = Appearance18
        Me.UltraTextEditor1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTextEditor1.Location = New System.Drawing.Point(72, 104)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(64, 21)
        Me.UltraTextEditor1.TabIndex = 291
        Me.UltraTextEditor1.Text = "UltraTextEditor8"
        '
        'frmDrgPartItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Drawing Part"
        Me.ClientSize = New System.Drawing.Size(936, 646)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmDrgPartItem"
        Me.Text = "Drawing Part"
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.UltraTabPageControl13.PerformLayout()
        CType(Me.cmb_WidthParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_LengthParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Length, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        Me.UltraTabPageControl15.PerformLayout()
        CType(Me.cmb_Width2ParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Length2ParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Width2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Length2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_GasketTypeCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl10.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.utcDimLenWid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcDimLenWid.ResumeLayout(False)
        Me.UltraTabSharedControlsPage5.ResumeLayout(False)
        Me.UltraTabSharedControlsPage5.PerformLayout()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl5.PerformLayout()
        CType(Me.cmb_OuterDiaParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_InnerDiaParamID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OuterDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InnerDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl8.PerformLayout()
        CType(Me.txt_TotalArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotAreaRemoved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Thk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_HasNoJoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CalcWeightEach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Density, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.UltraTabPageControl14.PerformLayout()
        CType(Me.txt_AreaPerMtr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WtPerMtr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MatSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.UltraTabPageControl7.PerformLayout()
        CType(Me.cmb_ThkParamID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.utcReductions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcReductions.ResumeLayout(False)
        Me.PanelDim.ResumeLayout(False)
        CType(Me.utcDimType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcDimType.ResumeLayout(False)
        CType(Me.utcSectionType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcSectionType.ResumeLayout(False)
        Me.UltraTabSharedControlsPage3.ResumeLayout(False)
        Me.UltraTabSharedControlsPage3.PerformLayout()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.chk_ExcludeCNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_NoCommonCut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.chk_ShowNonStd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsManualWt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_SeeDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChart.ResumeLayout(False)
        Me.PanelChart.PerformLayout()
        CType(Me.txt_DescripChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combosubcat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsDeleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsBoughtOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ItemNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextDrgNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents chk_ShowNonStd As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents TextDrgNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_ExcludeCNC As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents CtlUpLoad6 As risersoft.shared.win.ctlUpLoad
    Friend WithEvents CtlUpLoad5 As risersoft.shared.win.ctlUpLoad

#End Region
End Class

