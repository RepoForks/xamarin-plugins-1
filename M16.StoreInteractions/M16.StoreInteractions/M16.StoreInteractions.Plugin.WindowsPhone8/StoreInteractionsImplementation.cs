using M16.StoreInteractions.Plugin.Abstractions;
using System;
using Windows.System;


namespace M16.StoreInteractions.Plugin
{
    /// <summary>
    /// Implementation for M16.StoreInteractions
    /// </summary>
    public class StoreInteractionsImplementation : IStoreInteractions
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
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?keyword=" + searchTerms + "&contenttype=app"));
        }
    }
}