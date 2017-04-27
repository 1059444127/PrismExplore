using System;
using System.ComponentModel.Composition;

namespace ExportInheritanceExplore
{
    public class ChildExporter : Exporter
    {
        public ChildExporter()
        {
            Console.WriteLine("ChildExporter constructed");
        }
    }
}