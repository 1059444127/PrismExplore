using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MessengerControlPanel
{
    public class MessengerControlPanelViewModel : ViewModelBase
    {
        #region [--MessengerCommand--]

        private ICommand _messengerCommand;

        public ICommand MessengerCommand
        {
            get { return _messengerCommand = _messengerCommand ?? new RelayCommand(SendMessage); }
        }

        private void SendMessage()
        {
            
        }

        #endregion [--MessengerCommand--]    

    }
}