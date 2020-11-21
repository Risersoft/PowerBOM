Public Class myFuncs
    Public Sub fncDrgItemEdit(ByRef oView As clsWinView, ByVal DrgItemID As Integer)
        Dim sql, prepIDX, str1 As String, dt As DataTable, r As DataRow
        Dim f As frmMax

        sql = "select * from deslistdrgitems() where drgitemid = " & DrgItemID
        dt = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        If dt.Rows.Count > 0 Then
            f = GiveDrgItemForm(dt.Rows(0))
            If (Not f Is Nothing) AndAlso f.GetRowLock(EnumfrmMode.acEditM, "drgitemid", DrgItemID, True) Then
                If f.PrepForm(oView, EnumfrmMode.acEditM, DrgItemID) Then WinFormUtils.CentreForm(f, oView.fParentWin)
            End If
        End If

    End Sub
    Public Shared Function GiveDrgItemForm(ByVal rDrgItem As DataRow) As frmMax
        Dim r As DataRow, str1 As String, f As frmMax

        r = rDrgItem
        If myUtils.cValTN(r("stddrgid")) > 0 Then str1 = r("stddrg") Else str1 = r("drawing")
        If myUtils.cBoolTN(r("iscollection")) Then
            Dim f1 As New frmDrgCollec
            f1.TextDrgNum.Text = str1
            f = f1
        ElseIf myUtils.cValTN(r("refdrgitemid")) > 0 Then
            If myUtils.cValTN(r("refstddrgid")) > 0 Then
                Dim f1 As New frmDrgRefStd
                f1.TextDrgNum.Text = str1
                f = f1
            Else
                Dim f1 As New frmDrgRefFile
                f1.TextDrgNum.Text = str1
                f = f1
            End If
        ElseIf myUtils.cValTN(r("itemid")) > 0 OrElse myUtils.cStrTN(r("material")).Trim.Length > 0 Then
            If myUtils.cValTN(r("itemcollectypecode")) = 1 OrElse myUtils.cStrTN(r("material")).ToLower = "ms hardware" OrElse myUtils.cStrTN(r("material")).ToLower = "ss hardware" Then
                Dim f1 As New frmDrgHardware
                f1.TextDrgNum.Text = str1
                f = f1
            ElseIf myUtils.cValTN(r("itemcollectypecode")) = 2 Then
                Dim f1 As New frmItemCollec
                f1.TextDrgNum.Text = str1
                f = f1
            Else
                Dim f1 As New frmDrgPartItem
                f1.TextDrgNum.Text = str1
                f = f1
            End If
        ElseIf myUtils.cValTN(r("itemcollectypecode")) = 2 Then
            Dim f1 As New frmItemCollec
            f1.TextDrgNum.Text = str1
            f = f1
        Else
            Dim f1 As New frmDrgPartGen
            f1.TextDrgNum.Text = str1
            f = f1
        End If

        Return f

    End Function

End Class
