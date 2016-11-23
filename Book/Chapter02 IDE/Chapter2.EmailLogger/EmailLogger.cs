using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Chapter2.EmailLogger
{
    [PartMetadata("secure", "false")]
    [Export(typeof(Chapter2.MEFInterfaces.ILogger))]
    public class EmailLogger : MEFInterfaces.ILogger
    {
        [ExportMetadata("timeout", "5000")]
        public string WriteToLog(string Message)
        {
            //Simulate email logging
            return "Email Logger Called";
        }
    }
}