Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmBOMProDocuModel
    Inherits clsFormDataModel
    Dim myBOM As New clsBOM(myContext)
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
        Dim sql As String = "select * from deslistprodocu() where prodocuid = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            VSave = True
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "drgitems"
                Dim sql As String = "Select * from desListDrgItems() where ProDocuId=" & myUtils.cValTN(frmIDX) & " order by ItemNum"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "process"
                Dim myBOM As New clsBOM(myContext), ds As DataSet, dt As DataTable
                Dim cnt1, cnt2 As Decimal
                ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "Select * from deslistdrgitemcalc() where len(cncdrgnew)>0 and prodocuid=" & frmIDX)
                dt = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from drgitems where prodocuid=" & frmIDX).Tables(0)

                Dim rr() As DataRow = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, "select * from deslistprodocu() where prodocuid=" & frmIDX).Tables(0).Select
                cnt1 = 1
                myFuncsPB.SuspendFreshBOMDs = True
                cnt2 = dt.Select.Length
                For Each r1 As DataRow In dt.Select
                    myContext.CallBack.ReportProgress(CInt(cnt1 / cnt2 * 100), "Processing " & r1("description"))
                    myBOM.HandleCalc(r1, rr(0), ds, myFuncsPB.BuildBOMTree, "Select * from DrgItems where DrgItemId=0")
                    cnt1 = cnt1 + 1
                Next
                myFuncsPB.SuspendFreshBOMDs = False
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "btnpaste"
                    Dim ProDocuId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ProDocuid", Params))

                    Dim sql1 As String = myContext.SQL.PopulateSQLParams("Select * from DrgItems where ProDocuId = @BOMCopyPDocuID", Params)
                    Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1).Tables(0)

                    Dim sql2 As String = myContext.SQL.PopulateSQLParams("Select * from DrgItems where ProDocuId = @ProDocuid", Params)
                    Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql2).Tables(0)
                    For Each r1 In dt1.Select
                        If Not myUtils.cBoolTN(r1("IsCollection")) Then
                            Dim rr() As DataRow = dt2.Select("ItemNum='" & myUtils.cStrTN(r1("ItemNum")) & "'")
                            If rr.Length = 0 Then
                                Dim r2 As DataRow = myUtils.CopyOneRow(r1, dt2)
                                r2("DrgItemId") = DBNull.Value
                                r2("ProDocuId") = myUtils.cValTN(ProDocuId)
                                r2("CncDrg") = DBNull.Value
                                myContext.Provider.objSQLHelper.SaveResults(dt2, sql2)
                            End If
                        End If
                    Next
                Case "shiftup"
                    Dim ProDocuId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ProDocuid", Params))
                    Dim DrgItemID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@DrgItemID", Params))

                    Dim myBOM As New clsBOM(myContext)
                    myBOM.List.ShiftUpSaveItem(DrgItemID, ProDocuId, False)
                Case "delete"
                    Try
                        Dim ProDocuId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@ProDocuid", Params))
                        Dim DrgItemID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@DrgItemID", Params))
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, "Delete from DrgItems where DrgItemId = " & myUtils.cValTN(DrgItemID))
                        myBOM.List.HandleProdocu(ProDocuId)
                    Catch ex As Exception
                        oRet.AddException(ex)
                    End Try
            End Select
        End If
        Return oRet
    End Function
End Class
