using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace EventAggregationExplore.ViewModel
{
    public class SubjectViewModel : ViewModelBase
    {
        #region [--LeftLabelCommand--]

        private ICommand _leftLabelCommand;

        public ICommand LeftLabelCommand
        {
            get { return _leftLabelCommand = _leftLabelCommand ?? new RelayCommand(OnLeftLabelPicked); }
        }

        private void OnLeftLabelPicked()
        {
            // TODO: Send out Event
            MessageBox.Show("L");
        }

        #endregion [--LeftLabelCommand--]    


        #region [--RightLabelCommand--]

        private ICommand _rightLabelCommand;

        public ICommand RightLabelCommand
        {
            get { return _rightLabelCommand = _rightLabelCommand ?? new RelayCommand(OnRightLabelPicked); }
        }

        private void OnRightLabelPicked()
        {
            // TODO: Send out Event
            MessageBox.Show("R");           
        }

        #endregion [--RightLabelCommand--]    


    }
}