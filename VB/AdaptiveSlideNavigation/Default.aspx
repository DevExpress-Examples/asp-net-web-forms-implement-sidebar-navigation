<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="AdaptiveSlideNavigation.Default" %>

<%@ Register Src="~/UserControls/Navigation.ascx" TagPrefix="uc" TagName="Navigation" %>
<%@ Register Src="~/UserControls/Search.ascx" TagPrefix="uc" TagName="Search" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, maximum-scale=1.0, minimum-scale=1.0" />
    <title>TreeView - Slide Navigation</title>
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="Content/Site.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <dx:ASPxPanel runat="server" ClientInstanceName="TopPanel" CssClass="header-panel" FixedPosition="WindowTop">
                <PanelCollection>
                    <dx:PanelContent>
                        <dx:ASPxButton runat="server" Text="" CssClass="menu-button" AutoPostBack="false" UseSubmitBehavior="false" Width="60px" Height="60px">
                            <FocusRectBorder BorderWidth="0" />
                            <ClientSideEvents Click="Site.Nav.ToggleNavigationPanel" />
                            <Image>
                                <SpriteProperties CssClass="icon menu" />
                            </Image>
                        </dx:ASPxButton>
                        <span runat="server" id="PageHeader" class="page-header"></span>
                    </dx:PanelContent>
                </PanelCollection>
            </dx:ASPxPanel>
        </header>

        <dx:ASPxPanel runat="server" ID="NavigationPanel" ClientInstanceName="NavigationPanel" FixedPosition="WindowLeft"
            CssClass="navigation-panel" Collapsible="true" ScrollBars="Auto" Theme="Default">
            <SettingsCollapsing ExpandEffect="PopupToRight" AnimationType="Slide" ExpandButton-Visible="false" />
            <Styles>
                <Panel Paddings-Padding="0" />
                <ExpandBar Width="0" />
            </Styles>
            <PanelCollection>
                <dx:PanelContent>
                    <uc:Search runat="server" ID="Search" />
                    <uc:Navigation runat="server" ID="Navigation" />
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxPanel>

        <main>
            <h1><span runat="server" id="Content"></span></h1>
            <h2>UI Controls for Your Next Great Web App</h2>
            <p>
                With DevExpress web controls, you can build a bridge to the future on the platform you know and love. The 175+ AJAX controls
            and MVC extensions that make up the DevExpress ASP.NET Subscription have been engineered so you can deliver exceptional,
            touch-enabled, interactive experiences for the web, regardless of the target browser or computing device. DevExpress web UI
            components support all major browsers including Internet Explorer, FireFox, Chrome, Safari and Opera, and are continuously tested
            to ensure the best possible compatibility across platforms, operating systems and devices.
            </p>
            <p>
                And to ensure you can build your best and meet the needs of your enterprise each and every time, the DevExpress ASP.NET
            Subscription ships with 20 built-in application themes that can be used out-of-the box or customized via our ASP.NET Theme Builder.
            </p>

            <h2>UI Controls for Your Next Great Hybrid App</h2>
            <p>
                With DevExpress UI controls, you'll be able to deliver elegant line-of-business applications that emulate the touch-first Windows 8 Pro UX
            and maintain backward compatibility with previous versions of the Windows operating system. Whether you need to create a tile-based, modern UI
            application for Windows or need to quickly convert an existing application for use on Microsoft Surface, the DevExpress WinForms
            & WPF Subscriptions will help you deliver immersive business solutions, without abandoning your existing code investments. And because we
            continue to extend our .NET product line with enterprise-ready capabilities designed to help you build next-generation user experiences
            on the platform of your choice, you can rest assured that your apps will never be left behind, regardless of changes made to Windows or the
            introduction of new device form-factors.
            </p>

            <h2>UI Controls for Your Next Great Mobile App</h2>
            <p>
                Create highly-responsive mobile apps that meet the needs of your ever-changing enterprise and the BYOD world. Use the power of HTML, CSS3 and
            JavaScript to deliver line-of-business solutions that look, feel and behave just like native apps, without learning multiple languages or frameworks.
            </p>
        </main>
    </form>
</body>
</html>