using System;

namespace M16.StoreInteraction.Forms.Plugin.Abstractions
{
    /// <summary>
    /// M16.StoreInteraction Interface
    /// </summary>
    public interface IStoreInteraction
    {
        /// <summary>
        /// Opens the device's default app store for the given <paramref name="publisherName"/>
        /// <remarks>Currently not working on iOS</remarks>
        /// </summary>
        /// <param name="publisherName">The publisher name (do not encode this string)</param>
        void OpenForPublisher(string publisherName);

        /// <summary>
        /// Opens the device's default app store for the given <paramref name="appId"/>
        /// <remarks>Currently not working on iOS</remarks>
        /// </summary>
        /// <param name="appId">The application id (do not encode this string)</param>
        void OpenForApp(string appId);

        /// <summary>
        /// Opens the device's default app store for the given <paramref name="query"/>
        /// <remarks>Currently not working on iOS</remarks>
        /// </summary>
        /// <param name="query">The keywords to search in the app store (do not encode this string)</param>
        void OpenForQuery(string query);
    }
}
