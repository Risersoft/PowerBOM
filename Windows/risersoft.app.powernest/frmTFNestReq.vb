Imports risersoft.app.mxform.eto

Public Class frmTFNestReq
    Inherits frmMax
    Dim myViewPart As New clsWinView, dtNest As DataTable

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGrid1)
        myViewPart.SetGrid(Me.UltraGrid2)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("TFNestReq"))
            myViewPart.PrepEdit(NewModel.GridViews("Part"))

            dtNest = Me.Model.DatasetCollection("TfNestItems").Tables(0)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTFNestReqModel = Me.InitData("frmTFNestReqModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim rr() As DataRow
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            rr = dtNest.Select("TFNestReqId=" & myUtils.cValTN(myView.ContextRow.CellValue("TFNestReqId")))
            If rr.Length = 0 Then
                myView.ContextRow.Delete(True)
            Else
                MsgBox("This requirement has been nested and cannot be deleted", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim rr() As DataRow
        myViewPart.ContextRow = myViewPart.mainGrid.ActiveRow
        If Not myViewPart.ContextRow Is Nothing Then
            rr = dtNest.Select("TFNestReqId=" & myUtils.cValTN(myViewPart.ContextRow.CellValue("TFNestReqId")))
            If rr.Length = 0 Then
                myViewPart.ContextRow.Delete(True)
            Else
                MsgBox("This requirement has been nested and cannot be deleted", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btnAddCore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCore.Click
        Dim rr(), nr As DataRow
        rr = myView.mainGrid.myDS.Tables(0).Select("DesDocGrp='core'")
        If rr.Length = 0 Then
            nr = myView.mainGrid.myDS.Tables(0).NewRow
            nr("CncTypeId") = 1
            nr("DesDocGrp") = "Core"
            nr("isCompleted") = False
            myView.mainGrid.myDS.Tables(0).Rows.Add(nr)
        End If
    End Sub

    Private Sub btnAddTank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTank.Click
        Dim rr(), nr As DataRow
        rr = myView.mainGrid.myDS.Tables(0).Select("DesDocGrp='tank'")
        If rr.Length = 0 Then
            nr = myView.mainGrid.myDS.Tables(0).NewRow
            nr("CncTypeId") = 1
            nr("DesDocGrp") = "Tank"
            nr("isCompleted") = False
            myView.mainGrid.myDS.Tables(0).Rows.Add(nr)
        End If
    End Sub

    Private Sub btnAddStd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStd.Click
        Dim f As New frmTFNestDrgItem
        If f.PrepForm(myViewPart, EnumfrmMode.acAddM, "") Then
            f.myRow("CncTypeId") = 1
            f.ShowDialog()
        End If
    End Sub
End Class

