<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Chapter10.ASP._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">



<asp:Panel ID="pnlParent" runat="server" ViewStateMode="Inherit">
    <asp:Label ID="lbl1" Text="text" ViewStateMode="Inherit" runat="server" />
</asp:Panel>

<asp:Label ID="lblTest" runat="server" Text="Test" ClientIdMode="Inherit"></asp:Label>

<%= HttpUtility.HtmlEncode("<script>alert('hello');</script>") %>
<%: new HtmlString("<script>alert('I will now be run');</script>") %>


<asp:ListView ID="ListView1" runat="server">
<ItemTemplate>
<%# Eval("firstname") %>
</ItemTemplate>
</asp:ListView>


<asp:Chart id="chart1" runat="server">
<series><asp:Series Name="Series1"></asp:Series></series>
<chartareas><asp:ChartArea Name="ChartArea1"></asp:ChartArea></chartareas>
</asp:Chart>



</asp:Content>
