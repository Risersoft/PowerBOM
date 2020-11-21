Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgItemCalcModel
    Inherits clsFormDataModel
    Dim dic As New clsCollecString(Of String)
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
        Dim sql As String
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "Select * from drgItemCalc where drgItemCalcId = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            dic.Add("DrgItem", "Select WoInfo,PartNum from desListDrgItemCalc() where DrgItemCalcId = " & myUtils.cValTN(myRow("DrgItemCalcId")))
            Me.AddDataSet("DrgItem", dic)
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
