using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Person GetFirstname()
    {
        Person p = new Person();
        p.firstName = "Alex";
        p.lastName = "Mackey";
        return p;
    }
}

public class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
}