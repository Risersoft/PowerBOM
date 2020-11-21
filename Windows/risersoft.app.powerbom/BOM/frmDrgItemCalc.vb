Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto
Public Class frmDrgItemCalc
    Inherits frmMax
    Dim strDirec As String

    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String
        Me.FormPrepared = False
        Dim objModel As frmDrgItemCalcModel = Me.InitData("frmDrgItemCalcModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If (Not pView Is Nothing) AndAlso (Not pView.ContextRow Is Nothing) Then
                str1 = pView.ContextRow.CellValue("Reference")
            Else
                str1 = myUtils.cStrTN(myRow("Reference"))
            End If

            Dim dt As DataTable = Me.Model.DatasetCollection("DrgItem").Tables("DrgItem")
            If myUtils.cValTN(myRow("ChildDrgItemId")) > 0 AndAlso dt.Rows.Count > 0 Then
                str1 = str1 & "_" & dt.Rows(0)("PartNum")
                Me.textReference.Text = str1
                strDirec = "/CNC/FILE/" & myWinFtp.ReplaceSpecialChars(dt.Rows(0)("WoInfo"))
                InitUpLoad(str1)
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Private Function InitUpLoad(ByVal str1 As String)
        Dim str2 As String
        For Each ctl As ctlUpLoad In New ctlUpLoad() {Me.CtlUpLoad1, Me.CtlUpLoad2, Me.CtlUpLoad3, Me.CtlUpLoad4, Me.CtlUpLoad5, Me.CtlUpLoad6}
            str1 = myWinFtp.ReplaceSpecialChars(str1)
            If myUtils.cValTN(ctl.Tag) > 1 Then str1 = str1 & "." & ctl.Tag
            str1 = str1 & ".dxf"
            If myUtils.cValTN(ctl.Tag) > 1 Then str2 = myUtils.cStrTN(myRow("CNCDRGNEW" & ctl.Tag)) Else str2 = myUtils.cStrTN(myRow("CNCDRGNEW"))
            ctl.InitExt(frmMode, str1, str2, "", strDirec, "dxf", "pbom")
        Next
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
        If Me.ValidateData() Then
            myRow("cncdrgnew") = Me.CtlUpLoad1.FilePath
            myRow("cncdrgnew2") = Me.CtlUpLoad2.FilePath
            myRow("cncdrgnew3") = Me.CtlUpLoad3.FilePath
            myRow("cncdrgnew4") = Me.CtlUpLoad4.FilePath
            myRow("cncdrgnew5") = Me.CtlUpLoad5.FilePath
            myRow("cncdrgnew6") = Me.CtlUpLoad6.FilePath
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function
End Class
