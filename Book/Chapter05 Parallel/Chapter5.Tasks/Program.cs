using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Factory.StartNew(() => Console.WriteLine("hello task 1"));
            Task task2 = new Task(() => Console.WriteLine("hello task 2"));
            task2.Start();
        }


        private void WaitExample()
        {
            Task task1 = Task.Factory.StartNew(() => Console.WriteLine("hello task 1"));
            Task task2 = new Task(() => Console.WriteLine("hello task 2"));
            Task task3 = Task.Factory.StartNew(() => Console.WriteLine("hello task 3"));
            Task task4 = Task.Factory.StartNew(() => Console.WriteLine("hello task 4"));

            task2.Start();
            task1.Wait();
            Task.WaitAll(task2, task3, task4);

            //Could also do this
            Task.WaitAny(task2, task3, task4);

            //Or this
            while (task1.IsCompleted == false)
            {
                Console.WriteLine("Waiting on task 1");
            }
        }

        private void ContinueWithExample()
        {
            Task task3 = Task.Factory.StartNew(() => Console.WriteLine("hello task 1"))
    .ContinueWith((t) => Console.WriteLine("hello task 2"))
    .ContinueWith((t) => Console.WriteLine("hello task 3"))
    .ContinueWith((t) => Console.WriteLine("hello task 4"));


           
        }

        private void ContinueWithFaulted()
        {
            Task task3 = Task.Factory.StartNew(() => doSomethingBad())
           .ContinueWith((t) => System.Diagnostics.Trace.Write("I will be run"),TaskContinuationOptions.OnlyOnFaulted);
        }

        private void doSomethingBad()
        {
            //do something bad here
        }

        private void returnValue()
        {
            var data = Task.Factory.StartNew(() => GetResult());
            Console.WriteLine("Parallel task returned with value of {0}", data.Result);

            //Alternative
            Task<string> t = new Task<string>(() => GetResult());
            t.Start();
            Console.WriteLine("Parallel task returned with value of {0}", t.Result);
        }

        private string GetResult()
        {
            return "test";
        }
    }
}
