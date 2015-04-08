using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Messier16.StoreInteractions.Abstractions;

[assembly: Dependency(typeof(Messier16.StoreInteractions.iOS.StoreInteractions))]
namespace Messier16.StoreInteractions.iOS
{
    public class StoreInteractions : IStoreInteractions
    {
        private const string ForPublisherName = "https://itunes.apple.com/artist/";
        private const string FromAppId = "https://itunes.apple.com/app/";
        public bool OpenForPublisher(string publisherName)
        {
            // https://itunes.apple.com/artist/id284888248
            return LaunchForString(ForPublisherName + publisherName);
        }

        public bool OpenForApp(string app)
        {
            return LaunchForString(FromAppId + app);
        }

        public bool OpenForQuery(string query)
        {
            throw new NotImplementedException();
        }

        private bool LaunchForString(string route)
        { 
            var url = new Foundation.NSUrl(route);
            if (UIApplication.SharedApplication.CanOpenUrl(url))
            {
                UIApplication.SharedApplication.OpenUrl(url);
                return true;
            }
            return false;
        }

        public static void Init() { }

    }
}