using System;
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
        [Import] private ViewTool _viewTool;

        public Program()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("There are {0} views", p.GetViewCount());
        }

        private int GetViewCount()
        {
            return _viewTool.GetViewCount();
        }
    }
}
