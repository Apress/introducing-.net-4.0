using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter05.Cancellation
{
    class Program
    {
        static CancellationTokenSource cts = new CancellationTokenSource();

        static void Main(string[] args)
        {
            //Note this example has a mistake in the book so ammended
            Task t = Task.Factory.StartNew(() => DoSomething(), cts.Token);                      
            cts.Cancel();
            Console.ReadKey();
        }

        public static void DoSomething()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("doing stuff");

                   
                }

                if (cts.Token.IsCancellationRequested == true)
                {
                    Console.WriteLine("cancelled");
                    throw new OperationCanceledException(cts.Token);
                }
            }

            catch (OperationCanceledException ex)
            {
                //operation cancelled do any clean up here
                Console.WriteLine("Cancellation occurred");
            }
        }
    }
}