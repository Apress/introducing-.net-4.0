<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <%= TempData["Message"] %>
  
   <a href="Film">Example 1 - Hello MVC</a> <br />
   <a href="Film/All">Example 2 - All Films</a> <br />
   <a href="Film/Detail/1">Example 3 - Film Detail</a> <br />
   <a href="Film/Edit/1">Example 4 -  Edit Strongly Typed</a> <br />
   <a href="Film/EditJSON/1">Example 5 - Edit using JSON</a> <br />
   
</asp:Content>