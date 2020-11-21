Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmDrgPartModel
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
        Dim vlist1 As New clsValueList

        vlist1.Add("Aluminium")
        vlist1.Add("Copper")
        vlist1.Add("CI")
        vlist1.Add("GI Flat")
        vlist1.Add("Gun Metal")
        vlist1.Add("Brass")
        vlist1.Add("Glass")
        vlist1.Add("Nylon")
        vlist1.Add("Teflon / PTFE")
        vlist1.Add("Nitrile Rubber")
        vlist1.Add("Neoprene Rubber")
        vlist1.Add("Sy. Rubber")

        vlist1.Add("MS")
        vlist1.Add("MS Angle")
        vlist1.Add("MS Beam")
        vlist1.Add("MS Channel")
        vlist1.Add("MS Hardware")
        vlist1.Add("MS Pipe")
        vlist1.Add("MS Rod")
        vlist1.Add("MS Flat")
        vlist1.Add("MS Plate")
        vlist1.Add("MS Sheet")

        vlist1.Add("RBC")
        vlist1.Add("Permawood")
        vlist1.Add("CRGO")
        vlist1.Add("PBD")
        vlist1.Add("Bakelite")

        vlist1.Add("Non Magnetic SS Plate")
        vlist1.Add("SS Hardware")

        Me.ValueLists.Add("Material", vlist1)
        Me.AddLookupField("Material", "Material")

        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from drgitems where drgitemid = " & prepIDX
        Me.InitData(Sql, "stddrgid,prodocuid", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("prodocuid")) Then
            dic.Add("prodocu", "select woinfo from deslistprodocu() where prodocuid = " & myUtils.cValTN(myRow("prodocuid")))
            Me.AddDataSet("prodocu", dic)
        End If

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            If myBOM.List.SaveItem(myRow.Row) Then
                frmIDX = myRow("drgitemid")
                frmMode = EnumfrmMode.acEditM
                VSave = True
            End If
        End If
    End Function
End Class
