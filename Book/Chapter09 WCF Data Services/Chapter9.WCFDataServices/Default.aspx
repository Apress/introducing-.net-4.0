<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<script src="Scripts/jquery-1.3.2-vsdoc.js" type="text/javascript"></script>
   <script>
function getMovieTitle() {
$.ajax({
type: "GET",
dataType: "json",
url: "MovieService.svc/Films(1)",
success: function (result) {
    alert(result.d.Title);
},
error: function (error) {
    alert('error ');
}
});
}
</script>


<input type="button" Value="Get Movie Title" onclick="javascript:getMovieTitle();" />

</asp:Content>
