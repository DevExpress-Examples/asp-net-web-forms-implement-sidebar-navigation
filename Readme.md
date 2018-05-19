# How to implement sidebar navigation shown in DevExpress demos


<p>This example illustrates our brand new design for demos, which was implemented in version 17.2.<br>It contains all the functionality with searching and navigation between different items that are represented in our main demo site.<br>The main sections are

* Header
* Sidebar - Navigation and Search panels
* Main Content<br>The header panel is placed on the Default page and contains a button to show/collapse the sidebar and some info about the page that is selected from the sidebar is shown. <br>The sidebar contains user controls - Navigation and Search user controls. Navigation is implemented using ASPxTreeView and bound to an XML source to show what section the site contains. The Search user control is implemented using ASPxNavBar in which search results are shown. Search and navigation functionalities are implemented using the client-side code in the ~/Content/Site.js" file.</p>

<br/>


