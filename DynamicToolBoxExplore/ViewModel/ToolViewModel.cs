using GalaSoft.MvvmLight;

namespace DynamicToolBoxExplore.ViewModel
{
    public abstract class ToolViewModel : ViewModelBase
    {
         public abstract string Name { get; }
    }

    class RLabelViewModel : ToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "R"; }
        }

        #endregion
    }

    class MLabelViewModel : ToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "M"; }
        }

        #endregion
    }

    class LLabelViewModel : ToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "L"; }
        }

        #endregion
    }
}