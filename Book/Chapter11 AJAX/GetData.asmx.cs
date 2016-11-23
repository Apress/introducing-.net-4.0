using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;

namespace Chapter11.HelloAJAX
{
    /// <summary>
    /// Summary description for GetData
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetData : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod]
        public List<Person> GetPeople()
        {
            System.Threading.Thread.Sleep(2000);

            List<Person> People = new List<Person>();

            People.Add(new Person { Name = "Alex Mackey", Age = "28" });
            People.Add(new Person { Name = "Matt Lacey", Age = "31" });
            People.Add(new Person { Name = "Barry Dorrans", Age = "78" });
            People.Add(new Person { Name = "Craig Murphy", Age = "33" });
            People.Add(new Person { Name = "Chris Hay", Age = "32" });
            People.Add(new Person { Name = "Andy Gibson", Age = "21" });

            return People;
        }

    }
}
