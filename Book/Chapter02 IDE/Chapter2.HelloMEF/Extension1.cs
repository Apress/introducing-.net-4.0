using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Chapter2.HelloMEF
{
    public class Extension1
    {
        [Export]
        public string Message
        {
            get
            {
                return "I am extension 1";
            }
        }
    }
}
