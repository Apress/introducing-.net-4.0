using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetMovieCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.HttpWebRequest Request =(System.Net.HttpWebRequest) System.Net.HttpWebRequest.Create(
                "http://localhost/Chapter9/MovieService.svc/Films(1)"
                );

            Request.Method = "GET";
            Request.Accept = "application/json";
            System.Net.HttpWebResponse Response = (System.Net.HttpWebResponse)Request.GetResponse();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(Response.GetResponseStream()))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
