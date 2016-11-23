using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using Chapter7.WCFWebService;

namespace Chapter7.WCFWebServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            WebServiceHost MyServiceHost = new WebServiceHost(typeof(Chapter7.WCFWebService.Service1), new Uri("http://localhost:8888/Test"));
                       
            MyServiceHost.Open();
                      

            Console.WriteLine("Service running...");
            Console.ReadLine();
            MyServiceHost.Close();

        }
    }
}
