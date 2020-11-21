Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgPartGenModel
    Inherits clsFormDataModel
    Dim dic As New clsCollecString(Of String), myBOM As New clsBOM(myContext)
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "Select * from DrgItems where DrgItemId = " & prepIDX
        Me.InitData(Sql, "StdDrgId,ProDocuId", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("ProDocuId")) Then
            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        End If

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")
        If myUtils.cStrTN(myRow("Specification")).Trim.Length = 0 Then Me.AddError("Specification", "Please enter specification")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            If myBOM.List.SaveItem(myRow.Row) Then
                frmIDX = myRow("DrgItemId")
                frmMode = EnumfrmMode.acEditM
                VSave = True
            End If
        End If
    End Function
End Class
