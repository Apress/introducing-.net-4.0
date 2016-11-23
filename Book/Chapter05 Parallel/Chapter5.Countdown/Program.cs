using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace Chapter05.Countdown
{
    class Program
    {
        static CountdownEvent CountDown = new CountdownEvent(2);
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(CountDownDeduct));
            ThreadPool.QueueUserWorkItem(new WaitCallback(CountDownDeduct));

            //Wait until countdown decremented by DecrementCountDown method
            CountDown.Wait();
            Console.WriteLine("Completed");
            Console.ReadKey();
        }

        static void CountDownDeduct(object StateInfo)
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Deducting 1 from countdown");
            CountDown.Signal();
        }
    }
}
