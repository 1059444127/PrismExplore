namespace MessengerChannel
{
    public class MessengerChannelHub
    {
        #region [--Singleton--]

        private static readonly MessengerChannelHub _instance = new MessengerChannelHub();

        private MessengerChannelHub()
        {
            
        }

        public MessengerChannelHub Instance
        {
            get { return _instance; }
        }

        #endregion
    }
}