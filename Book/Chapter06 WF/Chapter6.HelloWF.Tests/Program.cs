using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Diagnostics;

namespace Chapter6.HelloWF.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> Arguments = new Dictionary<string, object>();
            Arguments.Add("FilmName", "Terminator");
            Arguments.Add("ShowingDate", System.DateTime.Now);
            Arguments.Add("NumberOfTickets", 10);

            IDictionary<string, object> Output = new Dictionary<string, object>();

            Output = WorkflowInvoker.Invoke(new Chapter6.HelloWF.Workflow1(), Arguments);

            Debug.Assert((bool)Output["BookingSuccessful"] == false);

        }
    }
}
