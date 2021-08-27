<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134059232/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T598380)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to implement sidebar navigation shown in DevExpress demos
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t598380/)**
<!-- run online end -->


<p>This example illustrates our brand new design for demos, which was implemented in version 17.2.<br>It contains all the functionality with searching and navigation between different items that are represented in our main demo site.<br>The main sections are

* Header
* Sidebar - Navigation and Search panels
* Main Content<br>The header panel is placed on the Default page and contains a button to show/collapse the sidebar and some info about the page that is selected from the sidebar is shown. <br>The sidebar contains user controls - Navigation and Search user controls. Navigation is implemented using ASPxTreeView and bound to an XML source to show what section the site contains. The Search user control is implemented using ASPxNavBar in which search results are shown. Search and navigation functionalities are implemented using the client-side code in the ~/Content/Site.js" file.</p>

<br/>


