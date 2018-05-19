Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI.WebControls
Imports System.Xml
Imports DevExpress.Web

Namespace AdaptiveSlideNavigation.UserControls
    Partial Public Class Search
        Inherits System.Web.UI.UserControl

        Protected Sub SearchResults_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
            Dim text = e.Parameter
            Dim results = DoSearch(text)
            If results.Count > 0 Then
                BindSearchResultsNavBar(results)
                SearchResultsNavBar.Visible = True
                noResultsContainer.Visible = False
            Else
                SearchResultsNavBar.Visible = False
                requestText.InnerHtml = text
                noResultsContainer.Visible = True
            End If
        End Sub

        Private Sub BindSearchResultsNavBar(ByVal data As IList(Of SearchResultItem))
            Dim group = New NavBarGroup()
            SearchResultsNavBar.Groups.Add(group)
            For Each item In data
                Dim navBarItem = New NavBarItem(text:= String.Format("<span class='title'>{0}</span> <span class='tags'>Tags: {1}</span>", item.Title, GetFromattedTags(item.Tags)), name:= "", imageUrl:= "", navigateUrl:= item.Url)
                group.Items.Add(navBarItem)
            Next item
        End Sub

        Private Function GetFromattedTags(ByVal tags As String) As String
            Return String.Concat(tags.Split(","c).Select(Function(i) String.Format("<span class='tag'>{0}</span>", i.Trim())))
        End Function

        Private Function DoSearch(ByVal text As String) As IList(Of SearchResultItem)
            Dim pagesNodes = XmlDataSource1.GetXmlDocument().GetElementsByTagName("page").OfType(Of XmlNode)()
            Return pagesNodes.Where(Function(n) n.Attributes("Title").Value.ToUpper().Contains(text.ToUpper()) OrElse n.Attributes("Tags").Value.ToUpper().Contains(text.ToUpper())).Select(Function(n) New SearchResultItem() With { _
                .Title = n.Attributes("Title").Value, _
                .Tags = n.Attributes("Tags").Value, _
                .Url = n.Attributes("Url").Value _
            }).ToList()
        End Function

        Private Class SearchResultItem
            Public Property Title() As String
            Public Property Tags() As String
            Public Property Url() As String
        End Class
    End Class
End Namespace