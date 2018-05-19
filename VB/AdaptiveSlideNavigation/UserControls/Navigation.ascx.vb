Imports System
Imports System.Web.UI
Imports System.Xml
Imports DevExpress.Web

Namespace AdaptiveSlideNavigation.UserControls
    Partial Public Class Navigation
        Inherits System.Web.UI.UserControl

        Protected Sub NavigationTreeView_NodeDataBound(ByVal source As Object, ByVal e As DevExpress.Web.TreeViewNodeEventArgs)
            Dim dataNode As XmlNode = (TryCast((TryCast(e.Node.DataItem, IHierarchyData)).Item, XmlNode))
            If dataNode.Name = "group" Then
                e.Node.NodeStyle.CssClass &= " group"
            End If
            If dataNode.ParentNode IsNot Nothing AndAlso dataNode.ParentNode.Name <> "group" Then
                e.Node.NodeStyle.CssClass &= " introPage"
            End If
        End Sub

        Protected Sub NavigationTreeView_PreRender(ByVal sender As Object, ByVal e As EventArgs)
            Dim node As TreeViewNode = NavigationTreeView.SelectedNode
            If node IsNot Nothing Then
                NavigationTreeView.ExpandToNode(node)
                node.Expanded = True
                Do While node IsNot Nothing
                    If node.Parent IsNot Nothing AndAlso node.Parent.Parent Is Nothing Then
                        node.Expanded = False
                    End If
                    node = node.Parent
                Loop
            End If
        End Sub
    End Class
End Namespace