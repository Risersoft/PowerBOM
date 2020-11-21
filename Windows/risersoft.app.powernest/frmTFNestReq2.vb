Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmTFNestReq2
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

            Me.cmb_DesDocGrp.ValueList = Me.Model.ValueLists("DesDocGrp").ComboList
            Me.cmb_DesDocGrp.Text = ""

            Me.cmb_CNCTypeID.ValueList = Me.Model.ValueLists("CNCType").ComboList
            Me.cmb_CNCTypeID.Value = Nothing

            dtNest = Me.Model.DatasetCollection("TfNestItems").Tables(0)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTFNestReq2Model = Me.InitData("frmTFNestReq2Model", oview, prepMode, prepIdx, strXML)
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
            rr = dtNest.Select("tfnestreqid=" & myUtils.cValTN(myView.ContextRow.CellValue("tfnestreqid")))
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
            rr = dtNest.Select("tfnestreqid=" & myUtils.cValTN(myViewPart.ContextRow.CellValue("tfnestreqid")))
            If rr.Length = 0 Then
                myViewPart.ContextRow.Delete(True)
            Else
                MsgBox("This requirement has been nested and cannot be deleted", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim rr(), nr As DataRow
        If Me.cmb_DesDocGrp.Text.Trim.Length > 0 AndAlso (Not Me.cmb_CNCTypeID.SelectedItem Is Nothing) Then
            rr = myView.mainGrid.myDS.Tables(0).Select("desdocgrp='" & myUtils.cStrTN(Me.cmb_DesDocGrp.Text) & "' and cnctypeid=" & myUtils.cValTN(Me.cmb_CNCTypeID.Value))
            If rr.Length = 0 Then
                nr = myView.mainGrid.myDS.Tables(0).NewRow
                nr("desdocgrp") = Me.cmb_DesDocGrp.Text
                nr("cnctypeid") = Me.cmb_CNCTypeID.Value
                nr("iscompleted") = False
                myView.mainGrid.myDS.Tables(0).Rows.Add(nr)
            End If
        End If
    End Sub

    Private Sub btnAddStd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStd.Click
        Dim f As New frmTFNestDrgItem
        If f.PrepForm(myViewPart, EnumfrmMode.acAddM, "") Then f.ShowDialog()
    End Sub
End Class

