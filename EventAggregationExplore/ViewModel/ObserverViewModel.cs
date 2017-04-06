using System;
using System.Collections.ObjectModel;
using EventAggregationExplore.Event;
using GalaSoft.MvvmLight;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;

namespace EventAggregationExplore.ViewModel
{
    public class ObserverViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;

        public ObserverViewModel()
        {
            _eventAggregator = ServiceLocator.Current.GetInstance<EventAggregator>();
            _eventAggregator.GetEvent<UIElementActivityEvent>().Subscribe(HandleEvent);
        }

        private void HandleEvent(string e)
        {
            _events.Add(e);
        }

        private readonly ObservableCollection<string> _events = new ObservableCollection<string>();
        public ObservableCollection<string> Events {get {return _events;}} 
    }
}