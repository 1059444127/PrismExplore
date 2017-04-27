using System;
using System.ComponentModel.Composition;

namespace PrerequisiteImportExplore
{
    [Export]
    public class Exporter
    {
        public Exporter()
        {
            Console.WriteLine("Exporter Constructed.");
        }
    }
}