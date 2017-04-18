using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DynamicToolBoxExplore.ViewModel
{
    public abstract class ToolViewModel : ViewModelBase
    {
        public abstract string Name { get; }
    }

    public abstract class SingleToolViewModel : ToolViewModel
    {
        #region [--ToolCommand--]

        private ICommand _toolCommand;

        public ICommand ToolCommand
        {
            get { return _toolCommand = _toolCommand ?? new RelayCommand(OnClicked); }
        }

        #endregion [--ToolCommand--]  
        
        protected virtual void OnClicked()
        {
            MessageBox.Show(string.Format("{0}Label Picked", Name));
        }
    }

    class DownLabelToolViewModel : SingleToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "Down"; }
        }

        #endregion
    }

    class UpLabelToolViewModle : SingleToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "Up"; }
        }

        #endregion
    }

    public class GroupToolViewModel : ToolViewModel
    {
        private string _name;

        public GroupToolViewModel(string name)
        {
            _name = name;
            Tools = new ObservableCollection<ToolViewModel>();
        }

        public ObservableCollection<ToolViewModel> Tools { get; private set; }

        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return _name; }
        }

        #endregion
    }


    class RLabelViewModel : SingleToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "R"; }
        }

        #endregion
    }

    class MLabelViewModel : SingleToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "M"; }
        }

        #endregion
    }

    class LLabelViewModel : SingleToolViewModel
    {
        #region Overrides of ToolViewModel

        public override string Name
        {
            get { return "L"; }
        }

        #endregion
    }
}