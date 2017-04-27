using System;
using System.ComponentModel.Composition;

namespace MultiInstanceImportExplore
{
    [Export(typeof(IView)), PartCreationPolicy(CreationPolicy.NonShared)]
    public class View : IView
    {
        private IController _controller;
        [Import] private IController Controller { set { _controller = value; _controller.Register(this); } }

        public View()
        {
            Console.WriteLine("View contructed");
        }
    }
}