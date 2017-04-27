using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace MultiInstanceImportExplore
{
    [Export(typeof(IController))]
    public class Controller : IController
    {
        [Export]
        private readonly IList<IView> _views = new List<IView>();

        public Controller()
        {
            Console.WriteLine("Controller constructed");
        }

        #region Implementation of IController

        public void Register(IView view)
        {
            _views.Add(view);
            Console.WriteLine("Controller Register a view");
        }

        #endregion
    }
}