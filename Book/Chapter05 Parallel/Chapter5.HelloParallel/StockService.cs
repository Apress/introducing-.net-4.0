using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5.HelloParallel
{
    public class StockService
    {
        public static decimal CallService(StockQuote Quote)
        {
            Console.WriteLine("Executing long task for {0}", Quote.Company);
            var rand = new Random(DateTime.Now.Millisecond);
            System.Threading.Thread.Sleep(1000);
            return Convert.ToDecimal(rand.NextDouble());
        }
    }
}
