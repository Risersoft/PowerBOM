Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmDrgPart
    Inherits frmMax
    Dim strDirec, strWO As String

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String
        Me.FormPrepared = False
        Dim objModel As frmDrgPartModel = Me.InitData("frmDrgPartModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            strWO = ""
            strDirec = ""
            If Not myUtils.NullNot(myRow("stddrgid")) Then
                strDirec = "/CNC/STD"
                Me.Panel1.Visible = False
                Me.lblWeight.Text = "Weight Each"
                Me.chk_IsDeleted.Visible = True
            ElseIf Not myUtils.NullNot(myRow("prodocuid")) Then
                Me.Panel1.Visible = True
                Me.lblWeight.Text = "Weight"
                Dim dt As DataTable = Me.Model.DatasetCollection("prodocu").Tables("prodocu")
                If dt.Rows.Count > 0 Then
                    strDirec = "/CNC/FILE"
                    strWO = dt.Rows(0)(0)
                End If
                Me.chk_IsDeleted.Visible = False
            Else
                strDirec = ""
            End If

            If strDirec.Trim.Length > 0 Then
                InitUpLoad()
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            cmb_material.ValueList = Me.Model.ValueLists("Material").ComboList
            Return True
        End If
        Return False
    End Function

    Private Function InitUpLoad()
        Me.CtlUpLoad1.InitExt(frmMode, myWinFtp.ReplaceSpecialChars(Me.TextDrgNum.Text) & "_" & myRow("itemnum") & IIf(strWO.Trim.Length > 0, "_" & myWinFtp.ReplaceSpecialChars(strWO), "") & ".dxf", myUtils.cStrTN(myRow("CNCDRG")), "", strDirec, "dxf", "pbom")
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.Panel1.Visible AndAlso Me.txt_Qty.Text.Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Qty, "Please enter Qty")
        If Me.CanSave Then
            If Me.ValidateData() Then
                myRow("cncdrg") = Me.CtlUpLoad1.FilePath
                If Me.txt_MatSection.Text.Trim.Length > 0 AndAlso Me.txt_Length.Text.Trim.Length > 0 Then
                    myRow("specification") = Me.txt_MatSection.Text & " x " & Me.txt_Length.Text & " mm"
                ElseIf Me.txt_Length.Text.Trim.Length > 0 Then
                    myRow("specification") = Me.txt_Thk.Text & " Thk x " & Me.txt_Width.Text & " x " & Me.txt_Length.Text & " Lg."
                ElseIf Me.txt_OuterDia.Text.Trim.Length > 0 Then
                    myRow("specification") = Me.txt_Thk.Text & " Thk x " & Me.txt_InnerDia.Text & " ID x " & Me.txt_OuterDia.Text & " OD"
                Else
                    myRow("specification") = Me.txt_MatSection.Text
                End If
                If Me.SaveModel() Then
                    InitUpLoad()
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
