Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTFNestReqModel
    Inherits clsFormDataModel
    Dim myViewPart As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("TFNestReq")
        myViewPart = Me.GetViewModel("Part")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim sql, str1 As String

        If prepMode = EnumfrmMode.acEditM Then
            sql = "select * from plnListProdSerial() where prodserialId = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

            sql = "select tfnestreqid,cnctypeid, ProdSerialId, DesDocGrp, ReqDate, WorkGroup, IsCompleted, Remark from TFNestReq where drgitemid is null and prodSerialId = " & prepIDX
            myView.MainGrid.QuickConf(sql, True, "1-1-1-1-2", True)
            str1 = "<BAND INDEX=""0"" TABLE=""TFNestReq"" IDFIELD=""TFNestReqID""><COL KEY=""cnctypeid,ProdSerialId,Remark""/><COL NOEDIT=""True"" KEY=""desdocgrp"" CAPTION=""Type""/><COL KEY=""reqdate"" CAPTION=""Required Date""/><COL KEY=""WorkGroup"" CAPTION=""Group""/><COL KEY=""IsCompleted"" CAPTION=""Status"" VLIST=""False;Incomplete|True;Completed""/></BAND>"
            myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            sql = "select tfnestreqid,cnctypeid, ProdSerialID, Drgitemid, Qty, ReqDate, WorkGroup, IsCompleted, Remark from TFNestReq where len(desdocgrp)=0 and ProdSerialID = " & prepIDX
            myViewPart.MainGrid.QuickConf(sql, True, "2-1-1-1-1-2", True)
            str1 = "<BAND INDEX=""0"" TABLE=""TFNestReq"" IDFIELD=""TFNestReqID""><COL KEY=""cnctypeid,ProdSerialID,Remark,Qty""/><COL NOEDIT=""True"" KEY=""drgitemid"" LOOKUPSQL=""Select drgitemid, item from deslistdrgitems()"" CAPTION=""Item""/><COL KEY=""reqdate"" CAPTION=""Required Date""/><COL KEY=""WorkGroup"" CAPTION=""Group""/><COL KEY=""IsCompleted"" CAPTION=""Status"" VLIST=""False;Incomplete|True;Completed""/></BAND>"
            myViewPart.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            sql = "select * from tfnestitems where tfnestreqid in (select tfnestreqid from tfnestreq where ProdSerialID = " & frmIDX & ")"
            Me.AddDataSet("TfNestItems", sql)
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        myView.MainGrid.CheckValid("ReqDate,WorkGroup,IsCompleted")
        myViewPart.MainGrid.CheckValid("ReqDate,WorkGroup,Qty,IsCompleted")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext)
                myView.MainGrid.SaveChanges(, "ProdSerialID=" & frmIDX)
                myViewPart.MainGrid.SaveChanges(, "ProdSerialID=" & frmIDX)
                myContext.Provider.dbConn.CommitTransaction()
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction()
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
