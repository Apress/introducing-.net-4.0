using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.IO;

namespace Chapter2.HelloMEF
{
    class MoreUsefulMEF
    {
        [Import]
        private Chapter2.MEFInterfaces.ILogger Logger;
        public void TestLoggers()
        {
            CompositionContainer container;
            DirectoryCatalog directoryCatalog =
            new DirectoryCatalog(
            (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            );
            container = new CompositionContainer(directoryCatalog);
            CompositionBatch batch = new CompositionBatch();
            batch.AddPart(this);
            container.Compose(batch);
            Console.Write(Logger.WriteToLog("test"));


         
            Console.ReadKey();
        }
    }
}
