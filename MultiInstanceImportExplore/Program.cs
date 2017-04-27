using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MultiInstanceImportExplore
{
    class Program
    {
        [Import] private IController _controller;
        [Import] private IView _view1;
        [Import] private IView _view2;

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
