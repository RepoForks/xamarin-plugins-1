using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Messier16.Forms.Plugin.Xparse
{
    public static class CrossParse
    {
        public static event PushReceived OnPushReceived;

        public delegate void PushReceived(object sender, CrossParsePushNotificationEventArgs e);

        /// <summary>
        /// Suscribe to a channel
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public static async Task SuscribeAsync(string channel = "")
        {
            NotImplementedInReferenceAssembly();
        }

        /// <summary>
        /// Initializes the ParseClient
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="key"></param>
        public static void InitializeClient(string applicationId, string key)
        {
            NotImplementedInReferenceAssembly();
        }

        public static void AddParsePushNotificationReceivedListener()
        {
            NotImplementedInReferenceAssembly();
        }

        public static void RemoveParsePushNotificationReceivedListener()
        {
            NotImplementedInReferenceAssembly();
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the Xam.Plugins.Settings NuGet package from your main application project in order to reference the platform-specific implementation.");
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
