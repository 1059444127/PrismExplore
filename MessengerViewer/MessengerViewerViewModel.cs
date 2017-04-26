using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace MessengerViewer
{
    public class MessengerViewerViewModel : ViewModelBase
    {
        #region [--AllowMessage--]

        private bool _allowMessage = true;

        public bool AllowMessage
        {
            get { return _allowMessage; }
            set
            {
                if (_allowMessage == value) return;
                _allowMessage = value;
                RaisePropertyChanged(() => AllowMessage);
            }
        }

        #endregion [--AllowMessage--]

        private ObservableCollection<string> _messages = new ObservableCollection<string>();
        public ObservableCollection<string> Messages {get { return _messages; }} 
    }
}