using System;
using Messier16.StoreInteractions.Abstractions;
using Android.Content;
using Xamarin.Forms;

[assembly: Dependency(typeof(Messier16.StoreInteractions.Droid.StoreInteractions))]
namespace Messier16.StoreInteractions.Droid
{
    public class StoreInteractions : IStoreInteractions
    {
        private const string FromPackageName = "market://details?id=";
        private const string FromPublisherName = "market://search?q=pub:";
        private const string FromQuery = "market://search?q=";
        private const string FromQueryEnd = "&c=apps";

        public bool OpenForPublisher(string publisherName)
        {
            StartIntentForUri(FromPublisherName + publisherName);
            return true;
        }

        public bool OpenForApp(string appId)
        {
            StartIntentForUri(FromPackageName + appId);
            return true;
        }

        public bool OpenForQuery(string query)
        {
            StartIntentForUri(FromQuery + query + FromQueryEnd);
            return true;
        }

        private void StartIntentForUri(string route)
        {
            Intent intent = new Intent(Intent.ActionView);
            intent.SetData(Android.Net.Uri.Parse(route));
            intent.SetFlags(ActivityFlags.NewTask);
            Xamarin.Forms.Forms.Context.StartActivity(intent);

        }


        public static void Init() { }

    }
}

