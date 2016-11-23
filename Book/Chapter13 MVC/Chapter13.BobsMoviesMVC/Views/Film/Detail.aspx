<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detail
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<%= ViewData["Title"] %> <br /> <br />

Description: <br />
<input type="text" value='<%= ViewData["Description"] %>' style='width:300px' /> <br />

Length: <br />
<%= Html.TextBox("Length") %> <br />

</asp:Content>
