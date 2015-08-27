using System;
using System.Collections.Generic;

namespace Messier16.Forms.Plugin.Xparse
{
    public class CrossParse
    {
        public CrossParse()
        {

        }

        public event PushReceived OnPushReceived;

        public delegate void PushReceived(IDictionary<string, object> pushInfo);

        public async void SuscribeAsync(string channel = "")
        {
            NotImplementedInReferenceAssembly();
        }

        public void InitializeClient(string applicationId, string key)
        {
            NotImplementedInReferenceAssembly();
        }

        public void ShowMessage(string text)
        {
            NotImplementedInReferenceAssembly();
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the Xam.Plugins.Settings NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
