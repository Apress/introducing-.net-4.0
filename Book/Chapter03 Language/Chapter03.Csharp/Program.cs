using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter03.Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Optional params
            Print(1);
            Print(1, "Color");
            Print(1, "Color", "My doc");
            Print(Copies: 1);
            Print(ColorMode: "Color");
            Print(DocumentName: "myDoc.txt");
            Print(Copies: 1, ColorMode: "Color");
            Print(Copies: 1, ColorMode: "Color", DocumentName: "myDoc.txt");
        }

        static void Print(int Copies = 1, string ColorMode = "Color", string DocumentName = "")
        {

        }
    }
}
