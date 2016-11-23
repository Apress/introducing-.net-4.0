using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Chapter6.Flowchart
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new Workflow1());
            Console.ReadKey();
        }
    }
}
