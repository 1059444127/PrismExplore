using System.Windows;
using System.Windows.Input;
using EventAggregationExplore.Event;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;

namespace EventAggregationExplore.ViewModel
{
    public class SubjectViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator = ServiceLocator.Current.GetInstance<EventAggregator>();

        #region [--LeftLabelCommand--]

        private ICommand _leftLabelCommand;

        public ICommand LeftLabelCommand
        {
            get { return _leftLabelCommand = _leftLabelCommand ?? new RelayCommand(OnLeftLabelPicked); }
        }

        private void OnLeftLabelPicked()
        {
            _eventAggregator.GetEvent<UIElementActivityEvent>().Publish("LeftLabelButton Clicked");
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
            _eventAggregator.GetEvent<UIElementActivityEvent>().Publish("RightLabelButton Clicked");
        }

        #endregion [--RightLabelCommand--]    


    }
}