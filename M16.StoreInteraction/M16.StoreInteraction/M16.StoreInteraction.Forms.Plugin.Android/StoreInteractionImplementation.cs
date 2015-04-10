using M16.StoreInteraction.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.StoreInteraction.Forms.Plugin.Droid;

[assembly: Dependency(typeof(StoreInteractionImplementation))]
namespace M16.StoreInteraction.Forms.Plugin.Droid
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
            throw new NotImplementedException();
        }

        public void OpenForApp(string appId)
        {
            throw new NotImplementedException();
        }

        public void OpenForQuery(string query)
        {
            throw new NotImplementedException();
        }
    }
}
