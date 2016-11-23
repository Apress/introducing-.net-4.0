using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace Chapter2.HelloMEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //MEFTest MEFTest = new MEFTest();
            //MEFTest.HelloMEF();

            MoreUsefulMEF MoreUsefulMEF = new MoreUsefulMEF();
            MoreUsefulMEF.TestLoggers();



            //Reading part data from MEF component
            CompositionContainer container;
            DirectoryCatalog directoryCatalog = new DirectoryCatalog((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            foreach (var Part in directoryCatalog.Parts)
            {
                Console.WriteLine(Part.Metadata["secure"]);
            }

            Console.ReadKey();
        }
    }
}
