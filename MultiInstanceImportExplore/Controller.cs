using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace MultiInstanceImportExplore
{
    [Export(typeof(IController))]
    public class Controller : IController
    {
        private readonly IList<IView> _views = new List<IView>();

        #region Implementation of IController

        public void Register(IView view)
        {
            _views.Add(view);
        }

        #endregion
    }
}