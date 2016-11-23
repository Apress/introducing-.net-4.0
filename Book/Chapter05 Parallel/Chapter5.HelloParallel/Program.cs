using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Chapter5.HelloParallel
{
    class Program
    {
        public static List<StockQuote> Stocks = new List<StockQuote>();

        static void Main(string[] args)
        {
            double serialSeconds = 0;
            double parallelSeconds = 0;
            Stopwatch sw = new Stopwatch();
            PopulateStockList();
            sw = Stopwatch.StartNew();
            RunInSerial();
            serialSeconds = sw.Elapsed.TotalSeconds;
            sw = Stopwatch.StartNew();
            RunInParallel();
            parallelSeconds = sw.Elapsed.TotalSeconds;
            Console.WriteLine(
            "Finished serial at {0} and took {1}", DateTime.Now, serialSeconds);
            Console.WriteLine(
            "Finished parallel at {0} and took {1}", DateTime.Now, parallelSeconds);
            Console.ReadLine();

            //Parallel options
            ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
            Parallel.For(0, 100, options, x =>
            {
                //Do something
            });

            //Parallel for each
            Parallel.ForEach(Stocks, stock =>
            {
                StockService.CallService(stock);
            });

            //Invoke example
            Parallel.Invoke(() => StockService.CallService(Stocks[0]),
            () => StockService.CallService(Stocks[1]),
            () => StockService.CallService(Stocks[2])
            );

            //PLINQ Example
            var query = from s in Stocks
                        let result = StockService.CallService(s)
                        select result;

            var query2 = from s in Stocks.AsParallel()
                        let result = StockService.CallService(s)
                        select result;


            var query3 = from s in Stocks.AsParallel().AsOrdered()
                         orderby s.Company
                         let company = s.Company
                         let result = StockService.CallService(s)
                         select result;
            
            query3.ForAll(result => Console.WriteLine(result));

            //as sequential
            var query4 = from s in Stocks.AsParallel().AsSequential()
            let result = StockService.CallService(s)
            select result;
            

            //select stock that doesnt exist to demonstrate aggregate exception
            var query5 = from s in Stocks.AsParallel()
                        let result = StockService.CallService(Stocks[11])
                        select result;
            try
            {
                query5.ForAll(result => Console.WriteLine(result.ToString()));
            }
            catch (AggregateException e)
            {
                foreach (var ex in e.InnerExceptions)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }


        private static void PopulateStockList()
        {
            Stocks.Add(new StockQuote { ID = 1, Company = "Microsoft", Price = 5.34m });
            Stocks.Add(new StockQuote { ID = 2, Company = "IBM", Price = 1.9m });
            Stocks.Add(new StockQuote { ID = 3, Company = "Yahoo", Price = 2.34m });
            Stocks.Add(new StockQuote { ID = 4, Company = "Google", Price = 1.54m });
            Stocks.Add(new StockQuote { ID = 5, Company = "Altavista", Price = 4.74m });
            Stocks.Add(new StockQuote { ID = 6, Company = "Ask", Price = 3.21m });
            Stocks.Add(new StockQuote { ID = 7, Company = "Amazon", Price = 20.8m });
            Stocks.Add(new StockQuote { ID = 8, Company = "HSBC", Price = 54.6m });
            Stocks.Add(new StockQuote { ID = 9, Company = "Barclays", Price = 23.2m });
            Stocks.Add(new StockQuote { ID = 10, Company = "Gilette", Price = 1.84m });
        }

        private static void RunInSerial()
        {
            for (int i = 0; i < Stocks.Count; i++)
            {
                Console.WriteLine("Serial processing stock: {0}", Stocks[i].Company);
                StockService.CallService(Stocks[i]);
                Console.WriteLine();
            }
        }

        private static void RunInParallel()
        {
            Parallel.For(0, Stocks.Count, i =>
            {
                Console.WriteLine("Parallel processing stock: {0}", Stocks[i].Company);
                StockService.CallService(Stocks[i]);
                Console.WriteLine();
            });
        }
    }
}
