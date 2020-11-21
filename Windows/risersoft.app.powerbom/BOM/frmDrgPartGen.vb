Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto

Public Class frmDrgPartGen
    Inherits frmMax

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmDrgPartGenModel = Me.InitData("frmDrgPartGenModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            If Not myUtils.NullNot(myRow("StdDrgId")) Then
                Me.Panel1.Visible = False
                Me.lblWeight.Text = "Weight Each"
                Me.chk_IsDeleted.Visible = True
                FormPrepared = True
            ElseIf Not myUtils.NullNot(myRow("ProDocuId")) Then
                Me.Panel1.Visible = True
                Me.lblWeight.Text = "Weight"
                Me.chk_IsDeleted.Visible = False
                FormPrepared = True
            End If

            myRow("ItemId") = DBNull.Value
            myRow("MATERIAL") = DBNull.Value
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.Panel1.Visible AndAlso Me.txt_Qty.Text.Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Qty, "Please enter Qty")
        If Me.CanSave Then
            If Me.ValidateData() Then
                If Me.SaveModel() Then
                    Me.DoRefresh = True
                    Return True
                End If
            Else
                Me.SetError()
            End If
        End If
        Me.Refresh()
    End Function
End Class
