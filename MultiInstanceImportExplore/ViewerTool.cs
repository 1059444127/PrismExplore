using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace MultiInstanceImportExplore
{
    public abstract class ViewTool
    {
        [Import]
        protected IList<IView> Views;

        public int GetViewCount()
        {
            return Views.Count;
        }
    }
}