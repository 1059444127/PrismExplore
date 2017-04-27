using System.Collections;
using System.Collections.Generic;

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

        private IList<object> _tokens = new List<object>();

        public object RequestToken()
        {
            var token = new object();
            _tokens.Add(token);
            
            //TODO: publish tokens

        }
    }
}