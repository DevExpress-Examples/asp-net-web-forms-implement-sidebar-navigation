using System;

namespace AdaptiveSlideNavigation {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int collapseAtWindowInnerWidth = 1200;
            NavigationPanel.SettingsAdaptivity.CollapseAtWindowInnerWidth = collapseAtWindowInnerWidth;
            NavigationPanel.JSProperties["cpCollapseAtWindowInnerWidth"] = collapseAtWindowInnerWidth;

            PageHeader.InnerText = GetPageName();
            Content.InnerText = string.Format("Content for {0}", GetPageName());
        }
        
        string GetPageName() {
            string xField = Request.QueryString["x"];
            string name = string.IsNullOrEmpty(xField)
                ? "Home" : Request.QueryString["x"];
            return name;
        }
    }
}
