Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto

Public Class frmDrgRefFile
    Inherits frmMax
    Dim myViewDocs As New clsWinView, refPIDUnitID As Integer, lastinforow As DataRow
    Dim myBOM As New clsBOM(Me.Controller), rDocu As DataRow, dirtyBOM As Boolean

    Public Sub initForm()
        myViewDocs.SetGrid(Me.UltraGrid1)
        myView.SetGrid(Me.UltraGrid2)
        myView.SetTree(Me.UltraTree1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControl1.Tabs("bom").Visible = False
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("drgitems"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim cont As Boolean = True, RefProDocuId As Integer
        Dim gRow As UltraGridRow, r1 As DataRow = Nothing
        Me.FormPrepared = False
        Dim objModel As frmDrgRefFileModel = Me.InitData("frmDrgRefFileModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then

            If Not myUtils.NullNot(myRow("ProDocuId")) Then
                Me.lblWOCodeFile.Text = ""
                If frmMode = EnumfrmMode.acEditM Then
                    Dim oret As clsProcOutput = Me.GenerateIDOutput("fileinfo", myUtils.cValTN(myRow("RefDrgItemId")))
                    If oret.Success Then
                        r1 = oret.Data.Tables(0).Rows(0)
                    End If
                    If r1 Is Nothing Then cont = False
                End If
                If cont Then
                    If frmMode = EnumfrmMode.acEditM Then
                        LoadPIDU(r1, r1("ProDocuId"))
                        RefProDocuId = r1("ProDocuId")
                    Else
                        RefProDocuId = selCurrFile()
                    End If

                    Dim oret As clsProcOutput = Me.GenerateIDOutput("prodocuinfo", myUtils.cValTN(myRow("ProDocuId")))
                    If oret.Success Then
                        rDocu = oret.Data.Tables(0).Rows(0)
                    End If
                    If frmMode = EnumfrmMode.acEditM Then
                        gRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "DrgItemId", myRow("RefDrgItemId"))
                        If Not gRow Is Nothing Then
                            myView.mainGrid.myGrid.ActiveRow = gRow
                            gRow.Selected = True
                            Me.FormPrepared = True
                        End If
                        dirtyBOM = True
                        Me.OnFrmModeChanged(frmMode)
                        Me.UltraTabControl1.Tabs(0).Selected = True
                    Else
                        Me.FormPrepared = True
                    End If
                End If
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If myViewDocs.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(myViewDocs.mainGrid.myGrid, "Select Drawing")
            If myView.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(myView.mainGrid.myGrid, "Select Item")
            If Me.CanSave Then
                If myUtils.cStrTN(myView.mainGrid.myGrid.ActiveRow.Cells("itemnum").Value).Trim = "901" Then
                    myRow("specification") = myViewDocs.mainGrid.myGrid.ActiveRow.Cells("drawing").Value
                Else
                    myRow("specification") = myViewDocs.mainGrid.myGrid.ActiveRow.Cells("drawing").Value & " - " & myView.mainGrid.myGrid.ActiveRow.Cells("itemnum").Value
                End If
                myRow("RefDrgItemId") = myView.mainGrid.myGrid.ActiveRow.Cells("DrgItemId").Value
                myRow("weight") = myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("weight").Value) * myRow("qty")
                If Me.SaveModel() Then
                    myView.myTreeWin.BindModel(Me.Model.GridViews("drgitems").MainTree)
                    Me.DoRefresh = True
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnMac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMac.Click
        Dim Params As New List(Of clsSQLParam)
        Dim rr() As DataRow = Me.AdvancedSelect("pidunit", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then LoadPIDU(rr(0))
    End Sub

    Private Function LoadPIDU(ByVal inforow As DataRow, Optional ByVal ProDocuId As Integer = 0) As Integer
        If inforow Is Nothing Then
            Me.lblWOCodeFile.Text = ""
            refPIDUnitID = 0
        Else
            Me.lblWOCodeFile.Text = inforow("PidInfo") & " - " & inforow("filenumcomp")
            refPIDUnitID = inforow("PidUnitId")
        End If


        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitId", myUtils.cValTN(refPIDUnitID), GetType(Integer), False))
        Params.Add(New clsSQLParam("@ProDocuId", myUtils.cValTN(myRow("ProDocuId")), GetType(Integer), False))
        Dim oRet As clsProcOutput = Me.GenerateParamsOutput("loadpidu", Params)
        If oRet.Success Then
            myView.mainGrid.BindView(oRet.Data, , 0)
            myView.myMode = EnumViewMode.acSelectM
            myView.mainGrid.QuickConf("", True, "1-0-0-2-5-2-0-2-1", True, "Parts List", , myView.Model.MainGrid.dvTableIndex)
            myView.mainGrid.myDv.RowFilter = "0=1"


            myViewDocs.mainGrid.MainConf("selFirstRow") = True
            myViewDocs.myMode = EnumViewMode.acSelectM
            myViewDocs.mainGrid.BindView(oRet.Data, , 1)
            myViewDocs.mainGrid.QuickConf("", True, "1", True, "Select")

            If ProDocuId = 0 AndAlso (Not myViewDocs.mainGrid.myGrid.ActiveRow Is Nothing) Then ProDocuId = myViewDocs.mainGrid.myGrid.ActiveRow.Cells("ProDocuId").Value
            If ProDocuId > 0 Then
                Dim gRow As UltraGridRow = myWinUtils.FindRow(myViewDocs.mainGrid.myGrid, "ProDocuId", ProDocuId)
                If Not gRow Is Nothing Then
                    myViewDocs.mainGrid.myGrid.ActiveRow = gRow
                    gRow.Selected = True
                End If
            End If
            lastinforow = inforow
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
        Return ProDocuId
    End Function

    Private Function selCurrFile() As Integer
        Return LoadPIDU(myFuncsPB.ProdocuInfo(Me.Controller, myRow("ProDocuId")))
    End Function

    Private Sub btnCurrFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrFile.Click
        selCurrFile()
    End Sub

    Private Sub UltraGrid1_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles UltraGrid1.AfterSelectChange
        Dim refprodocuid As Integer
        If myViewDocs.mainGrid.myGrid.ActiveRow Is Nothing Then
            myView.mainGrid.myDv.RowFilter = "0=1"
        Else
            refprodocuid = myViewDocs.mainGrid.myGrid.ActiveRow.Cells("ProDocuId").Value
            If refprodocuid = myUtils.cValTN(myRow("ProDocuId")) Then
                MsgBox("Drawing cannot refer itself", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            Else
                myView.mainGrid.myDv.RowFilter = "ProDocuId=" & refprodocuid
                myView.mainGrid.myGrid.Text = "Select item from " & myViewDocs.mainGrid.myGrid.ActiveRow.Cells("drawing").Value
            End If
        End If
    End Sub

    Private Sub UltraGrid2_AfterSelectChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs)
        If Me.txt_Description.Text.Trim.Length = 0 AndAlso myView.mainGrid.myGrid.Selected.Rows.Count > 0 Then
            Me.txt_Description.Text = myView.mainGrid.myGrid.Selected.Rows(0).Cells("description").Value
        End If
        dirtyBOM = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim r As DataRow, f As frmMax
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            r = myUtils.DataRowFromGridRow(myView.ContextRow)
            f = myFuncs.GiveDrgItemForm(r)
            If Not f Is Nothing Then
                If f.PrepForm(myView, EnumfrmMode.acEditM, r("DrgItemId")) Then f.ShowDialog()
                myView.RefreshGrid()
            End If
        End If
    End Sub

    Private Sub btnAddCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCollection.Click
        Dim f As New frmDrgCollec
        If Not myViewDocs.mainGrid.myGrid.ActiveRow Is Nothing Then
            Dim refprodocuid As Integer = myViewDocs.mainGrid.myGrid.ActiveRow.Cells("ProDocuId").Value
            f.TextDrgNum.Text = myUtils.cStrTN(myViewDocs.mainGrid.myGrid.ActiveRow.Cells("drawing").Value)
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS PRODOCUID=""" & refprodocuid & """/>") Then
                f.ShowDialog()
                LoadPIDU(lastinforow, refprodocuid)
            End If
        End If
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanging(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangingEventArgs) Handles UltraTabControl1.SelectedTabChanging
        If Me.FormPrepared AndAlso frmMode = EnumfrmMode.acEditM AndAlso e.Tab.Key.ToLower = "bom" AndAlso dirtyBOM Then
            If Me.VSave Then
                'OK To change tab
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Protected Overrides Sub OnFrmModeChanged(value As EnumfrmMode)
        Me.UltraTabControl1.Tabs("bom").Visible = (value = EnumfrmMode.acEditM AndAlso (Not rDocu Is Nothing))
    End Sub
End Class
