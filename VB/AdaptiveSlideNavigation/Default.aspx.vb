Imports System

Namespace AdaptiveSlideNavigation
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim collapseAtWindowInnerWidth As Integer = 1200
            NavigationPanel.SettingsAdaptivity.CollapseAtWindowInnerWidth = collapseAtWindowInnerWidth
            NavigationPanel.JSProperties("cpCollapseAtWindowInnerWidth") = collapseAtWindowInnerWidth

            PageHeader.InnerText = GetPageName()
            Content.InnerText = String.Format("Content for {0}", GetPageName())
        End Sub
        Private Function GetPageName() As String
            Dim xField As String = Request.QueryString("x")
            Dim name As String = If(String.IsNullOrEmpty(xField), "Home", Request.QueryString("x"))
            Return name
        End Function
    End Class
End Namespace