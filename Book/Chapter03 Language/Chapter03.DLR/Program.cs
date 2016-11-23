using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace Chapter03.DLR
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myDynamic = "Something";
            Console.WriteLine(myDynamic.GetType().Name);
            Console.ReadKey();


            dynamic easierXML =new EasierXML(@"<test><node1>Alpha</node1><node2>Beta</node2></test>");
            Console.WriteLine(easierXML.node1);
            Console.WriteLine(easierXML.node2);
            Console.ReadKey();
        }

        public void Reflection()
        {

            object UsingReflection = Activator.CreateInstance(Type.GetType("System.Text.StringBuilder"));
            Type ObjectType = UsingReflection.GetType();
            //Append has many overloads so we need to tell reflection which type we will use
            Type[] TypeArray = new Type[1];
            TypeArray.SetValue(typeof(string), 0);
            var ObjectMethodInfo = ObjectType.GetMethod("Append", TypeArray);
            ObjectMethodInfo.Invoke(UsingReflection, new object[] { "alex" });
            Console.WriteLine(
            ObjectType.GetMethod("ToString", new Type[0]).Invoke(UsingReflection, null)
            );
            Console.ReadKey();
        }

        public void DynamicExample()
        {
            dynamic usingDynamic = Activator.CreateInstance(Type.GetType("System.Text.StringBuilder"));
            usingDynamic.Append("Hello");
            Console.WriteLine(usingDynamic.ToString());
            Console.ReadKey();
        }

        public void ExpandoObject()
        {
            dynamic MyExpando = new ExpandoObject();
            MyExpando.Value1 = "new value 1";
            MyExpando.Value2 = "new value 2";
            MyExpando.DoSomething = new Action(() => Console.WriteLine("DoSomething called"));
            Console.WriteLine(MyExpando.Value1);
            MyExpando.DoSomething();
            Console.ReadKey();
        }


    }
}
