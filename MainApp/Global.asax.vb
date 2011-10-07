Imports System.Web.SessionState
Imports FubuMVC.Core
Imports FubuMVC.StructureMap
Imports StructureMap
Imports System.Web.Routing
Imports Bottles

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ObjectFactory.Initialize(Sub()
                                 End Sub)
        FubuApplication.For(Of PlaceHolderRegistry)().StructureMapObjectFactory().Bootstrap(RouteTable.Routes)

        PackageRegistry.AssertNoFailures()
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class

Public Class PlaceHolderRegistry
    Inherits FubuRegistry
    Public Sub New()
    End Sub
End Class