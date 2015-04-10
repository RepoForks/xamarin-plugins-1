using M16.StoreInteraction.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.StoreInteraction.Forms.Plugin.WindowsPhone;
using Windows.System;

[assembly: Dependency(typeof(StoreInteractionImplementation))]
namespace M16.StoreInteraction.Forms.Plugin.WindowsPhone
{
    /// <summary>
    /// StoreInteraction Implementation
    /// </summary>
    public class StoreInteractionImplementation : IStoreInteraction
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

		/// <summary>
		/// Opens for publisher.
		/// </summary>
		/// <returns>The for publisher.</returns>
		/// <param name="publisherName">Publisher name.</param>
        public void OpenForPublisher(string publisherName)
        {
           Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?publisher=" + publisherName));
        }

		/// <summary>
		/// Opens for app.
		/// </summary>
		/// <returns>The for app.</returns>
		/// <param name="app">App.</param>
        public void OpenForApp(string app)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:navigate?appid=" + app));
        }

		/// <summary>
		/// Opens for search.
		/// </summary>
		/// <returns>The for search.</returns>
		/// <param name="searchTerms">Search terms.</param>
		public void OpenForSearch(string searchTerms)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?keyword=" + query + "&contenttype=app"));
        }

    }
}
