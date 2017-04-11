using System;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DynamicToolBoxExplore.ViewModel
{
    public abstract class ToolViewModel : ViewModelBase
    {
        public abstract string Name { get; }

        #region [--ToolCommand--]

        private ICommand _toolCommand;

        public ICommand ToolCommand
        {
            get { return _toolCommand = _toolCommand ?? new RelayCommand(OnClicked); }
        }

        protected abstract void OnClicked();

        #endregion [--ToolCommand--]    

    }

    class RLabelViewModel : ToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "R"; }
        }

        protected override void OnClicked()
        {
            MessageBox.Show("RLabel Picked");
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

        protected override void OnClicked()
        {
            MessageBox.Show("MLabel Picked");
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

        protected override void OnClicked()
        {
            MessageBox.Show("LLabel Picked");
        }

        #endregion
    }
}