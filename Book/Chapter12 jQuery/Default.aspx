<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<script src="Scripts/jquery-1.3.2.js" type="text/javascript"></script>

<style>
.standardDiv
{
background:#cccccc;
width:300px;
height:200px;
}
.specialDiv
{
background:#00ff00;
width:300px;
height:200px;
}
</style>
    
<script>

    //hello jQuery!
    function hellojQuery() {
        $("#div1").html("hello jQuery");
    }

    //Create function
    jQuery.fn.say = function (message) {
        alert("jQuery says " + message);
        return this;
    }

    //Call our function
    $.fn.say("hello").say("good bye");

    //Load & run external JS file
    $.ajax({
        type: "GET",
        url: "test.js",
        dataType: "script"
    });

    //JSON call to page
    $.getJSON("default2.aspx",
    function (data) {
        alert(data.firstName);
    }
    );


    $.ajax({
        type: "POST",
        url: "Default3.aspx/GetFirstname",
        data: "{}",
        contentType: "application/json",
        dataType: "json",
        success: function (input) {
            alert(input.d.firstName);
        }
    });
</script>  

<input type="button" value="Hello jQuery" onclick="javascript:hellojQuery();" />
<div id="div1" class="standardDiv">
I am a boring grey div element
</div>
<br />
<div id="div2" class="standardDiv">
I am a boring grey div element
</div>
<br />
<div id="div3" class="specialDiv">
I am a special div!
</div>


</asp:Content>
