
using MonoTouch.UIKit;
using Parse;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messier16.Forms.Plugin.Xparse
{
    public static class CrossParse
    {

        static void ParsePush_ParsePushNotificationReceived(object sender, ParsePushNotificationEventArgs e)
        {
            if (OnPushReceived != null)
                OnPushReceived(sender, new CrossParsePushNotificationEventArgs(e.Payload));
        }

        public static event PushReceived OnPushReceived;

        public delegate void PushReceived(object sender, CrossParsePushNotificationEventArgs e);

        /// <summary>
        /// Suscribe to a channel
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static async Task SuscribeAsync(string channel = "")
        {
            await ParsePush.SubscribeAsync(channel);
        }

        public static void AddParsePushNotificationReceivedListener()
        {

            ParsePush.ParsePushNotificationReceived += ParsePush_ParsePushNotificationReceived;
        }

        public static void RemoveParsePushNotificationReceivedListener()
        {
            ParsePush.ParsePushNotificationReceived -= ParsePush_ParsePushNotificationReceived;
        }

        /// <summary>
        /// Initializes the ParseClient
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="key"></param>
        public static void InitializeClient(string applicationId, string key)
        {
            ParseClient.Initialize(applicationId, key);
        }

    }

    public class CrossParsePushNotificationEventArgs : EventArgs
    {
        public CrossParsePushNotificationEventArgs(IDictionary<string, object> payload)
        {
            Payload = payload;
        }

        public IDictionary<string, object> Payload
        {
            get;
            private set;
        }
    }
}
