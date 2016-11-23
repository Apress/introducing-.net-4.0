using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Chapter11.HelloAJAX
{
    [ServiceContract(Namespace = "ws")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GetDataFromWCF
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public Person GetPerson(string Name)
        {
            //System.Threading.Thread.Sleep(2000);

            List<Person> People = new List<Person>();

            People.Add(new Person { Name = "Alex Mackey", Age = "28" });
            People.Add(new Person { Name = "Matt Lacey", Age = "31" });
            People.Add(new Person { Name = "Barry Dorrans", Age = "78" });
            People.Add(new Person { Name = "Craig Murphy", Age = "33" });
            People.Add(new Person { Name = "Chris Hay", Age = "32" });
            People.Add(new Person { Name = "Andy Gibson", Age = "21" });

            return People.FirstOrDefault(p => p.Name == Name);
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
