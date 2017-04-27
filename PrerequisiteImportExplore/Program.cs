using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace PrerequisiteImportExplore
{
    class Program
    {
        [Import] private Importer _importer;

        public Program()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
