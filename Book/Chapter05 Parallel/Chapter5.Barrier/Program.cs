using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter05.BarrierExample
{
    class Program
    {
        static Barrier MyBarrier;

        static void Main(string[] args)
        {
            //There will be two participants in this barrier
            MyBarrier = new Barrier(2);
            Thread shortTask = new Thread(new ThreadStart(DoSomethingShort));
            shortTask.Start();
            Thread longTask = new Thread(new ThreadStart(DoSomethingLong));
            longTask.Start();
            Console.ReadKey();
        }

        static void DoSomethingShort()
        {
            Console.WriteLine("Doing a short task for 5 seconds");
            Thread.Sleep(5000);
            Console.WriteLine("Completed short task");
            MyBarrier.SignalAndWait();
            Console.WriteLine("Off we go from short task!");
        }

        static void DoSomethingLong()
        {
            Console.WriteLine("Doing a long task for 10 seconds");
            Thread.Sleep(10000);
            Console.WriteLine("Completed a long task");
            MyBarrier.SignalAndWait();
            Console.WriteLine("Off we go from long task!");
        }
    }
}
