using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace FieldExportExplore
{
    class Program
    {
        [Import("SelfInitialized")] string S1;
        [Import("ConstructorInitialized")] string S2;

        public Program()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("SelfInitialized={0}, ConstructorInitialized={1}", p.S1, p.S2);
        }
    }
}
