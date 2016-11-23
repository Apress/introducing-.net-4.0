using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace Chapter2.HelloMEF
{
    public class MEFTest
    {
        [Import]
        public string Message { get; set; }
        public void HelloMEF()
        {
            CompositionContainer container = new CompositionContainer();
            CompositionBatch batch = new CompositionBatch();
            batch.AddPart(new Extension1());
            batch.AddPart(this);
            container.Compose(batch);
            Console.WriteLine(Message);
            Console.ReadKey();
        }
    }
}
