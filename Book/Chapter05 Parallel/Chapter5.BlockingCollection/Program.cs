using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Collections.Concurrent;

namespace Chapter5.BlockingCollection
{
    class Program
    {
        public static BlockingCollection<string> blockingCol = new BlockingCollection<string>(5);
        public static string[] Alphabet = new string[5] { "a", "b", "c", "d", "e" };


        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ReadItems));
            Console.WriteLine("Created thread to read items");
            //Creating thread to read items note how we are already enumurating collection!
            ThreadPool.QueueUserWorkItem(new WaitCallback(AddItems));
            Console.WriteLine("Created thread that will add items");
            //Stop app closing
            Console.ReadKey();
        }

        public static void AddItems(object StateInfo)
        {
            int i = 0;
            while (i < 200)
            {
                blockingCol.Add(i++.ToString());
                Thread.Sleep(10);
            }
        }

        public static void ReadItems(object StateInfo)
        {
          
            foreach (object o in blockingCol.GetConsumingEnumerable())
            {
                Console.WriteLine("Read item: " + o.ToString());
            }
        }

    }
}