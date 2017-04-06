using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace EventAggregationExplore.ViewModel
{
    public class ObserverViewModel : ViewModelBase
    {
        private readonly ObservableCollection<string> _events = new ObservableCollection<string>();
        public ObservableCollection<string> Events {get {return _events;}} 
    }
}