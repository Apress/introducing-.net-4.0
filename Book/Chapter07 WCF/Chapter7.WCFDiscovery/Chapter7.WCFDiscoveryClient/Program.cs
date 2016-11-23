using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Discovery;
using System.ServiceModel;

namespace Chapter7.WCFDiscoveryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscoveryClient discoveryClient = new DiscoveryClient(new UdpDiscoveryEndpoint());
            Console.WriteLine("Finding end points please wait this may take some time..");

            FindResponse discoveryResponse = discoveryClient.Find(new FindCriteria(typeof(Chapter7.WCFDiscovery.IToUpper)));

            for (int Index = 0; Index < discoveryResponse.Endpoints.Count; Index++)
            {
                Console.WriteLine("Found end point at: " + discoveryResponse.Endpoints[Index].Address.ToString());
            }

            Console.WriteLine("Using end point: " + discoveryResponse.Endpoints[0].Address.ToString());

            EndpointAddress address = discoveryResponse.Endpoints[0].Address;

            ToUpperClient service = new ToUpperClient(new BasicHttpBinding(), address);
            Console.WriteLine(service.ToUpper("make me uppercase!"));
            Console.ReadKey();
        }
    }
}

