using System;
using System.ComponentModel.Composition;

namespace ExportInheritanceExplore
{
    [InheritedExport(typeof(Exporter))]
    public class Exporter
    {
        public Exporter()
        {
            Console.WriteLine("Exporter constructed");
        }
    }
}