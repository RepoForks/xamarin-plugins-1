using M16.StoreInteraction.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.StoreInteraction.Forms.Plugin.WindowsPhone;
using Windows.System;

[assembly: Dependency(typeof(StoreInteractionImplementation))]
namespace M16.StoreInteraction.Forms.Plugin.WindowsPhone
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

        public void OpenForPublisher(string publisherName)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?publisher=" + publisherName));
        }

        public void OpenForApp(string app)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:navigate?appid=" + app));
        }

        public void OpenForQuery(string query)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?keyword=" + query + "&contenttype=app"));
        }

    }
}
