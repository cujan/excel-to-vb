﻿Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As  _
    System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            ' Nastavení doby na 5000 ms (5 sekund). 
            Me.MinimumSplashScreenDisplayTime = 5000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function






        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

        End Sub
    End Class

    
End Namespace
