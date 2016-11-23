using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace Chapter6.HelloWF
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> Arguments = new Dictionary<string, object>();
            Arguments.Add("FilmName", "Terminator");
            Arguments.Add("ShowingDate", System.DateTime.Now.ToString());
            Arguments.Add("NumberOfTickets",3);

            WorkflowInvoker.Invoke(new Workflow1(), Arguments);
            Console.ReadLine();
        }
    }
}
