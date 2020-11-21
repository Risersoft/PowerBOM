Imports risersoft.app.mxform.eto

Public Class frmTFNestOld
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.initForm()
    End Sub

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "CNCType", "", Me.cmb_CNCTypeID)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTFNestOldModel = Me.InitData("frmTFNestOldModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub btnViewItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewItems.Click
    End Sub

    Private Sub btnUpdViewItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdViewItems.Click
    End Sub

    Private Sub btnPrevTermi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevItems.Click
        Me.UltraTabControl1.Tabs("req").Selected = True
    End Sub

    Private Sub btnNextItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextItems.Click
        Me.cm.EndCurrentEdit()
        Me.UltraTabControl1.Tabs("params").Selected = True
    End Sub

    Private Sub btnPrevParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevParams.Click
    End Sub

    Private Sub btnNextParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextParams.Click
        If Me.VSave() Then
            Me.UltraTabControl1.SelectedTab = Me.UltraTabControl1.Tabs("nest")
        End If
    End Sub

    Private Sub btnPrevNest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevNest.Click
        Me.UltraTabControl1.SelectedTab = Me.UltraTabControl1.Tabs("params")
    End Sub
End Class
