using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter5.Spinlock
{
    class Program
    {
        private static SpinLock MySpinLock = new SpinLock();

        static void Main(string[] args)
        {
            bool Locked = false;
            try
            {
                MySpinLock.Enter(ref Locked);
                //Work that requires lock would be done here
            }
            finally
            {
                if (Locked)
                {
                    MySpinLock.Exit();
                }
            }
        }
    }
}
