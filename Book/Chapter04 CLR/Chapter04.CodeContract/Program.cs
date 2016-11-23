using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;

namespace Chapter04.CodeContract
{
    class Program

    {
        private object ImportantData;

        static void Main(string[] args)
        {
            DoSomething(5);
        }

        public static void DoSomething(int? Input)
        {
            Contract.Requires(Input != null);
            Contract.Requires(Input != 5);
        }

        [Pure]
        public static double Multiply(int x, int y)
        {
            return x * y;
        }

        [ContractInvariantMethod]
        void MyInvariant()
        {
            Contract.Invariant(ImportantData != null);
        }


        [ContractClass(typeof(ContractForInteface))]
        interface IDoSomething
        {
            int DoSomething(int value);
        }

        [ContractClassFor(typeof(IDoSomething))]
        sealed class ContractForInteface : IDoSomething
        {
            int IDoSomething.DoSomething(int value)
            {
                Contract.Requires(value != 0);
                //contracts require a dummy value
                return default(int);
            }
        }

    }
}
