using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;


namespace Chapter03.COMandDLR
{
    class Program
    {
        static void Main(string[] args)
        {
            var WordApplication =
            new Microsoft.Office.Interop.Word.Application(); 
            WordApplication.Visible = true;

            object missing = System.Reflection.Missing.Value;
            object file = @"c:\test.txt";
            object visible = true;
            object readOnly = false;

            Document aDoc = WordApplication.Documents.Open(
            ref file, ref missing, ref readOnly, ref missing,
            ref missing, ref missing, ref missing, ref missing,
            ref missing, ref missing, ref missing, ref visible,
            ref missing, ref missing, ref missing, ref missing);

            //With VS2010
            var betterWay = WordApplication.Documents.Open(file, ReadOnly: true, Visible: true);
            betterWay.Activate();

            //excel.Cells[1, 1].Value = "Excell-ent!";
        }
    }
}
