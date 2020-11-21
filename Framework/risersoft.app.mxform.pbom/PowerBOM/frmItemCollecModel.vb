Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports System.Runtime.Serialization

<DataContract>
Public Class frmItemCollecModel
    Inherits clsFormDataModel
    Dim myBOM As New clsBOM(myContext)
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Items")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String = "Select Distinct SubCatId, DrgBomName, isGasket, BomSepCharts, BomSectionTypeCode from invListItems() where isNull(inTankDrawings,0)=1 and (isNull(inItemCollec,0)=1) order by DrgBomName"
        Me.AddLookupField("SubCat", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "SubCat").TableName)

        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "select * from DrgItems where DrgItemId = " & prepIDX
        Me.InitData(Sql, "StdDrgId,ProDocuId", oView, prepMode, prepIDX, strXML)

        If Not myUtils.NullNot(myRow("ProDocuId")) Then
            myBOM.UpdateDocHasBOM(myUtils.cValTN(myRow("ProDocuId")))
        End If

        If (Not myUtils.NullNot(myRow("StdDrgId"))) OrElse (Not myUtils.NullNot(myRow("ProDocuId"))) Then
            myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
            Dim sqlGrid As String = "Select Distinct DrgItemBomId,DrgItemId,ItemId,SpecBom,SubCatId,Legend,ItemCode,ItemName,Qty from deslistdrgitembom() where drgitemid=%frmidx%"
            myView.MainGrid.QuickConf(sqlGrid, True, "1-0-4-0-0-0-0-0-1", True)
            myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), "Select distinct ItemId,SubCatId,ItemCode,ItemName from invListItems() where isnull(inItemCollec,0)=1 and isnull(inTankDrawings,0)=1", "ItemId")
            myView.MainGrid.BindGridData(myFuncsBase.AttributedItemsTable(myContext, myView.MainGrid.myDS.Tables(0), Nothing), 0)
            myView.MainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(myContext, myView.MainGrid.myDV.Table.DataSet.Tables("attrib"))
            Dim strPrep As String = "<BAND INDEX=""0"" TABLE=""DrgItemBOM"" IDFIELD=""DrgItemBOMID""><COL KEY=""specbom,drgitemid,itemid,qty,legend""/></BAND>"""
            myView.MainGrid.PrepEdit(strPrep, EnumEditType.acCommandAndEdit)
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ItemNum")).Trim.Length = 0 Then Me.AddError("ItemNum", "Please enter item number")
        If myUtils.cStrTN(myRow("Description")).Trim.Length = 0 Then Me.AddError("Description", "Please enter description")
        If myView.MainGrid.myDS.Tables(0).Select("sysincl=1").Length = 0 Then Me.AddError("", "Select Items")
        myView.MainGrid.CheckValid("qty", "sysincl=1")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                If myBOM.List.SaveItem(myRow.Row) Then
                    frmIDX = myRow("drgitemid")
                    frmMode = EnumfrmMode.acEditM

                    myView.MainGrid.SaveChanges(, "drgitemid=" & frmIDX)
                    Dim rDocu As DataRow = myFuncsPB.ProdocuInfo(myContext, myUtils.cValTN(myRow("prodocuid")))
                    myBOM.HandleCalc(myRow.Row, rDocu, Nothing, myFuncsPB.BuildBOMTree, Me.sqlForm)

                    myContext.Provider.dbConn.CommitTransaction()
                    VSave = True
                End If
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
