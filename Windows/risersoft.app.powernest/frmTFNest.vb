Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxform.eto

Public Class frmTFNest
    Inherits frmWizMax
    Friend oFiler As clsMultiFiler
    Public fd As frmTFNest1, fi As frmTFNest2, fo As frmTFNest3
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        Dim arrDel As New ArrayList, uTab As UltraTab

        Me.SuspendLayout()

        fd = New frmTFNest1
        uTab = fd.AddtoTab(Me.UltraTabControl1, "def", True)

        fi = New frmTFNest2
        uTab = fi.AddtoTab(Me.UltraTabControl1, "items", True)

        fo = New frmTFNest3
        uTab = fo.AddtoTab(Me.UltraTabControl1, "output", True)

        Me.InitTabs(Me.UltraTabControl1, "tfnestid", "")
        Me.InitTabKey = "def"
        Me.arrmode.AddRange(New String() {"def"})


        Me.ResumeLayout()
        oFiler = New clsMultiFiler(Me.Controller, "pbom")
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            'sequencing important because frmTFNest1 will enable/disbale the action button based on below
            If myUtils.cBoolTN(myRow("isnested")) Then Me.DoEnable(False) Else Me.DoEnable(True)
            myWinSQL.AssignCmb(Me.dsCombo, "CNCType", "", Me.cmb_CNCTypeID)

            fd.BindModel(NewModel)
            fi.BindModel(NewModel)
            fo.BindModel(NewModel)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If Me.UltraTabControl1.Tabs.Count > 0 Then
            Dim objModel As frmTFNestModel = Me.InitData("frmTFNestModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                Me.strT = "tfnest"

                myWinSQL.AssignCmb(Me.dsCombo, "Thk", "", Me.cmb_Thk)
                Me.Prepmode()
                Me.FormPrepared = True
            End If
        Else
            MsgBox("Cannot Open!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        Return Me.FormPrepared
    End Function

    Friend Sub DoEnable(enable As Boolean)
        Me.Panel1.Enabled = enable
        fd.Enabled = enable
    End Sub

    Protected Overrides Sub OnMakeFTFPanel(vsbl As Boolean)
        Me.Panel1.Visible = vsbl
        MyBase.OnMakeFTFPanel(vsbl)
    End Sub

    Private Sub frmTFNest_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        fi.ClosePartView()
        fo.CloseRemView()
        fo.CloseSheetView()
        For Each f As frmMax In New frmMax() {fi.f1, fo.f2, fo.f3, fd, fi, fo}
            f.Close()
            f = Nothing
        Next
        GC.Collect()
    End Sub

    Private Sub cmb_CNCTypeID_ValueChanged(sender As Object, e As System.EventArgs)
        If Not fd.myView.mainGrid.myDv Is Nothing Then
            fd.myView.mainGrid.myDv.RowFilter = "cnctypeid=" & myUtils.cValTN(Me.cmb_CNCTypeID.Value)
            myUtils.ChangeAll(fd.myView.mainGrid.myDS.Tables(0).Select("cnctypeid<>" & myUtils.cValTN(Me.cmb_CNCTypeID.Value)), "sysincl=0")
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function
End Class

