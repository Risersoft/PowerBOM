Imports Infragistics.Win.UltraWinGrid
Imports C1.C1Zip
Imports risersoft.shared
Imports risersoft.shared.win
Imports risersoft.app.shared

Public Class myFuncs
    Public DoRefresh As Boolean = False
    Public Shared CopyXML As String, dsBOM As DataSet


    Friend Shared Function StdDrgInfo(ByVal stddrgid As Integer, ByRef drgnum As String) As String
        Dim sql, str1 As String, dt1 As DataTable

        sql = "select distinct completenum + ' - ' + drgname,completenum from desliststddrg() where stddrgid = " & stddrgid
        dt1 = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        If dt1.Rows.Count > 0 Then
            str1 = dt1.Rows(0)(0)
            drgnum = dt1.Rows(0)(1)
        End If
        Return str1
    End Function
    Friend Shared Function DrgItemStdDrgID(ByVal drgitemid As Integer) As Integer
        Dim sql, str1 As String, dt1 As DataTable

        sql = "select stddrgid from drgitems where drgitemid = " & drgitemid
        dt1 = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        If dt1.Rows.Count > 0 Then Return myUtils.cValTN(dt1.Rows(0)(0)) Else Return 0

    End Function

End Class






