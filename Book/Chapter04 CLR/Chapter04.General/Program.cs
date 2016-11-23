using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            OverflowExample();

            //Big Integer
            BigInteger bigIntFromDouble = new BigInteger(4564564564542332);
            BigInteger assignedFromDouble = (BigInteger)4564564564542332;

            //Sorted set
            SortedSet<int> MySortedSet = new SortedSet<int> { 8, 2, 1, 5, 10, 5, 10, 8 };

            //Tuple
            Tuple<int, int, int, int, int> MultiplesOfTwo = Tuple.Create(2, 4, 6, 8, 10);
            Console.WriteLine(MultiplesOfTwo.Item2);
            var multiples = new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>(2, 4, 6, 8, 10, 12, 14, new Tuple<int, int, int>(3, 6, 9));
            Console.WriteLine(multiples.Rest.Item1);
            
            //Complex number
            Complex c1 = new Complex(8, 2);
            Complex c2 = new Complex(8, 2);
            Complex c3 = c1 + c2;

            //File.ReadLines
            IEnumerable<string> FileContent = File.ReadLines("MyFile.txt");
            foreach (string Line in FileContent)
            {
                Console.Write(Line);
            }

            //Memory stream
            MemoryStream destinationStream = new MemoryStream();
            using (FileStream sourceStream = File.Open(@"c:\temp.txt", FileMode.Open))
            {
                sourceStream.CopyTo(destinationStream);
            }

            //Try parse
            Guid myGuid;
            Guid.TryParse("not a guid", out myGuid);

            //Enum example
            CarOptions myCar = CarOptions.MP3Player | CarOptions.AirCon | CarOptions.Turbo;
            Console.WriteLine("Does car have MP3? {0}", myCar.HasFlag(CarOptions.MP3Player));
            Console.ReadKey();

            //IsNullOrWhiteSpace
            String.IsNullOrWhiteSpace(" ");

            //Clear
            StringBuilder sb = new StringBuilder("long string");
            sb.Clear();

            //Special folder additions
            var test = Environment.SpecialFolder.CDBurning;

            //64 bit changes
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            Console.WriteLine(Environment.Is64BitProcess);

            //stopwatch
            var sw = new Stopwatch();
            sw.Start();

            //httpwebrequest
            string loadbalancerIp = "http://127.0.0.1/";
            string host = "mywebsite.com";
            var request = WebRequest.Create("http://127.0.0.1/") as HttpWebRequest;

            var socket = new System.Net.Sockets.Socket(new System.Net.Sockets.SocketInformation());
            socket.Connect(new DnsEndPoint("www.microsoft.com", 80));
            request.Date = System.DateTime.Now;
            sw.Restart();
        }


        public static void OverflowExample()
        {
            int a = 2000000000;
            Console.WriteLine(a * 2);
            Console.ReadKey();
        }

        [Flags]
        public enum CarOptions
        {
            AirCon = 1,
            Turbo = 2,
            MP3Player = 4
        }
    }
}
