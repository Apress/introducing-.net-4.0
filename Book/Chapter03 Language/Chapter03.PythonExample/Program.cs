using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace Chapter03.PythonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine pythonEngine = Python.CreateEngine();
            ScriptScope scope = pythonEngine.CreateScope();
            string script = @"print ""Hello "" + message";
            scope.SetVariable("message", "world!");
            ScriptSource source =
            scope.Engine.CreateScriptSourceFromString(script, SourceCodeKind.Statements);
            source.Execute(scope);
            Console.ReadKey();
        }
    }
}
