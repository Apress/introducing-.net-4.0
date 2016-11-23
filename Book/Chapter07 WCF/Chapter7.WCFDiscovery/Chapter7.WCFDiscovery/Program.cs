using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Discovery;
using System.ServiceModel.Description;

namespace Chapter7.WCFService
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ToUpperService), new Uri("http://localhost:8081/DiscoverMe"));
            host.AddServiceEndpoint(typeof(IToUpper), new BasicHttpBinding(), "ToUpper");
            host.AddServiceEndpoint(typeof(IToUpper), new WS2007HttpBinding(), "ToUpper2");
            host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });

            ServiceDiscoveryBehavior discoveryBehavior = new ServiceDiscoveryBehavior();
            host.Description.Behaviors.Add(discoveryBehavior);

            host.AddServiceEndpoint(new UdpDiscoveryEndpoint());
            discoveryBehavior.AnnouncementEndpoints.Add(new UdpAnnouncementEndpoint());

            host.Open();

            Console.WriteLine("Service running");
            Console.ReadKey();

        }

        public class ToUpperService : IToUpper
        {
            public string ToUpper(string Input)
            {
                return Input.ToUpper();
            }
        }



    }

    [ServiceContract]
    public interface IToUpper
    {
        [OperationContract]
        string ToUpper(string Input);
    }

}

