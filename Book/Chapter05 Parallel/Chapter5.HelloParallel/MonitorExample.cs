using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter5.HelloParallel
{
    class MonitorExample
    {
        public void Example1()
        {
            bool gotLock = false;
            object lockObject = new object();
            try
            {
                Monitor.Enter(lockObject, ref gotLock);
                //Do stuff
            }
            finally
            {
                if (gotLock)
                {
                    Monitor.Exit(lockObject);
                }
            }
        }
    }
}
