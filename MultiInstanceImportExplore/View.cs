using System.ComponentModel.Composition;

namespace MultiInstanceImportExplore
{
    [Export(typeof(IView)), PartCreationPolicy(CreationPolicy.NonShared)]
    public class View : IView
    {
        [Import] private IController _controller;

        public View()
        {
            
        }
    }
}