Imports risersoft.app.shared
Imports risersoft.app.powerbom
Imports risersoft.app.shared.mxengg
Imports risersoft.app2.shared
Imports risersoft.shared.DotnetFx
Public Module Utils

    Public Sub Main(ByVal args() As String)
        myApp = New clsRSWinCloudApp(New clsExtendAppPBOM)
        myWinApp.CheckInitConsole(args)
        Dim fMain As frmMax = AppStarter.StartWinFormApp(args)
        If Not fMain Is Nothing Then
            Application.Run(fMain)
        End If
    End Sub
End Module
