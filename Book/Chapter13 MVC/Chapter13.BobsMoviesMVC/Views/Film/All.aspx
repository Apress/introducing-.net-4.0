<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	All
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<a href="<%= "Create/" %>">Create</a>

<br /><br />

<%
    foreach (Chapter13.BobsMoviesMVC.Models.Film Film in (IEnumerable<Chapter13.BobsMoviesMVC.Models.Film>)Model)
    {
%>

<a href="<%= "Detail/" + Film.FilmID %>">
    <%= Film.Title %>
</a>

&nbsp; &nbsp;
  <%= Html.ActionLink("[Edit]", "Edit", new { id = Film.FilmID })%>  

&nbsp; 

  <%= Html.ActionLink("[Edit JSON]", "EditJSON", new {id=Film.FilmID})%>  

&nbsp; 

   <%= Html.ActionLink("[Delete]", "Delete", new {id=Film.FilmID})%>  

<br />

<% 
    }  
%>

</asp:Content>
