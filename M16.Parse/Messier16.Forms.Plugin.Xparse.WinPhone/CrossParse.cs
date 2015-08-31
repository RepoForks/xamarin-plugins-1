
using Parse;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

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
        /// Subscribe to a channel
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static async Task SubscribeAsync(string channel = "")
        {
            await ParsePush.SubscribeAsync(channel);
        }

        /// <summary>
        /// Subscribe to the given channels
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static async Task SubscribeAsync(IEnumerable<string> channels)
        {
            await ParsePush.SubscribeAsync(channels);
        }

        /// <summary>
        /// Unsubscribe to a channel
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static async Task UnsubscribeAsync(string channel = "")
        {
            await ParsePush.UnsubscribeAsync(channel);
        }

        /// <summary>
        /// Unsubscribe to the given channels
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static async Task UnsubscribeAsync(IEnumerable<string> channels)
        {
            await ParsePush.UnsubscribeAsync(channels);
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
