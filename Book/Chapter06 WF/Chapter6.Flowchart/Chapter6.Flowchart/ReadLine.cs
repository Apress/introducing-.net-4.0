using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace Chapter6.Flowchart
{
    public class ReadInput : CodeActivity<Int32>
    {
        protected override Int32 Execute(CodeActivityContext context)
        {
            return Convert.ToInt32(Console.ReadLine());
         
        }
    }

}
