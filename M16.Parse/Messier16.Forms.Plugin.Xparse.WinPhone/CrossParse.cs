
using Parse;
using System.Collections.Generic;
using System.Windows;

namespace Messier16.Forms.Plugin.Xparse
{
    public class CrossParse
    {
        public CrossParse()
        {
            ParsePush.ParsePushNotificationReceived += ParsePush_ParsePushNotificationReceived;
        }

        void ParsePush_ParsePushNotificationReceived(object sender, ParsePushNotificationEventArgs e)
        {
            if (OnPushReceived != null)
                OnPushReceived(e.Payload);
        }

        public event PushReceived OnPushReceived;

        public delegate void PushReceived(IDictionary<string,object> pushInfo);

        public async void SuscribeAsync(string channel = "")
        {
            await ParsePush.SubscribeAsync(channel);
        }

        public void InitializeClient(string applicationId, string key)
        {
            ParseClient.Initialize(applicationId, key);
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(string.Empty, text, MessageBoxButton.OK);
        }
    }
}
