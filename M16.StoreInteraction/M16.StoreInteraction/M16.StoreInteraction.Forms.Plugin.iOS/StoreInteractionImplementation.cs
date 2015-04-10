using M16.StoreInteraction.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.StoreInteraction.Forms.Plugin.iOS;
using MonoTouch.UIKit;

[assembly: Dependency(typeof(StoreInteractionImplementation))]
namespace M16.StoreInteraction.Forms.Plugin.iOS
{
    /// <summary>
    /// M16.StoreInteraction Implementation
    /// </summary>
    public class StoreInteractionImplementation : IStoreInteraction
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }


        private const string ForPublisherName = "https://itunes.apple.com/artist/";
        private const string FromAppId = "https://itunes.apple.com/app/";
        public void OpenForPublisher(string publisherName)
        {
            // No exception but, it does nothing
            // throw new NotImplementedException();
        }

        public void OpenForApp(string app)
        {
            // No exception but, it does nothing
            // throw new NotImplementedException();
            throw new NotImplementedException();
        }

        public void OpenForQuery(string query)
        {
            // No exception but, it does nothing
            // throw new NotImplementedException();
        }

        private void LaunchForString(string route)
        {
            var url = new MonoTouch.Foundation.NSUrl(route);
            if (UIApplication.SharedApplication.CanOpenUrl(url))
            {
                UIApplication.SharedApplication.OpenUrl(url);
            }
        }

    }
}
