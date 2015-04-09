using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Messier16.StoreInteractions.Abstractions;
using Xamarin.Forms;

[assembly: Dependency(typeof(Messier16.StoreInteractions.iOS.StoreInteractions))]
namespace Messier16.StoreInteractions.iOS
{
    public class StoreInteractions : IStoreInteractions
    {
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
            var url = new Foundation.NSUrl(route);
            if (UIApplication.SharedApplication.CanOpenUrl(url))
            {
                UIApplication.SharedApplication.OpenUrl(url);
            }            
        }

        public static void Init() { }

    }
}