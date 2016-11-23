using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Routing;
namespace Chapter7.Router
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open client service
            ServiceHost ClientService = new ServiceHost(typeof(Chapter7.RouterTestService.Service1),
            new Uri("http://localhost:1111/TestService"));
            ClientService.Open();
            Console.WriteLine("Service running...");

            //Open routing service
            ServiceHost RouterService = new ServiceHost(typeof(RoutingService));
            RouterService.Open();
            Console.WriteLine("Routing service running");

            Console.ReadLine();
            ClientService.Close();
            RouterService.Close();

        }
    }
}

