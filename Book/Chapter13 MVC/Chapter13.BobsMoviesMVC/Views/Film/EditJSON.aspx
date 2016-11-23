<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditJSON
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script>

    function submit() {

        //Get values from form
        var InputFilmID = $("#FilmID").val();
        var InputTitle = $("#Title").val();
        var InputDescription = $("#Description").val();

        //Submit client side
        $.ajax({
            type:
        "POST",
            dataType: "json",
            url: "EditJSON",

            data: { FilmID: InputFilmID, Title: InputTitle, Description: InputDescription },
            success: function (result) {
                alert(result.Message + " updating film " + result.Title);
                window.location = "../All";
            },
            error: function (error) {
                alert('error ');
            }

        });
    }


</script>


<form>

ID: <br />
<%= Html.TextBox("FilmID")%>
  
<br /> <br />

Title: <br />
<%= Html.TextBox("Title")%>
  
<br /> <br />
  
Description: <br />
<%= Html.TextBox("Description")%>


<br />
</form>

<input type="button" onclick="javascript:submit();" value="Update" />

</asp:Content>
