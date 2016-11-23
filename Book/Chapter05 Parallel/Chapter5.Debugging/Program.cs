using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Factory.StartNew(() => startAnotherTask());
            Task task2 = Task.Factory.StartNew(() => startAnotherTask());
            Task task3 = Task.Factory.StartNew(() => doSomething());
            Console.ReadKey();
        }

        static void startAnotherTask()
        {
            Task task4 = Task.Factory.StartNew(() => doSomethingElse());
        }
        static void doSomething()
        {
            System.Threading.Thread.Sleep(500000);
        }
        static void doSomethingElse()
        {
            System.Threading.Thread.Sleep(500000);
        }
    }
}
