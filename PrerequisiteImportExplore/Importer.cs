using System;
using System.ComponentModel.Composition;

namespace PrerequisiteImportExplore
{
    [Export]
    public class Importer
    {
        private Exporter _exporter;

        [ImportingConstructor]
        public Importer(Exporter exporter)
        {
            _exporter = exporter;
            Console.WriteLine("Importer constructed");
        } 
    }
}