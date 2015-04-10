using M16.StoreInteraction.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.StoreInteraction.Forms.Plugin.iOS;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

[assembly: Dependency(typeof(StoreInteractionImplementation))]
namespace M16.StoreInteraction.Forms.Plugin.iOS
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

		private const string ForPublisherName = "itms-apps://itunes.apple.com/artist/";
		private const string FromAppId = "itms-apps://itunes.apple.com/app/";
		private const string FromSearch = "itms-apps://itunes.apple.com/WebObjects/MZStore.woa/wa/search?term=";

		/// <summary>
		/// Opens for publisher.
		/// </summary>
		/// <param name="publisherName">Publisher name.</param>
		public void OpenForPublisher (string publisherName)
		{
			LaunchForString (ForPublisherName + publisherName);
		}

		/// <summary>
		/// Opens for app.
		/// </summary>
		/// <param name="app">App.</param>
		public void OpenForApp (string app)
		{
			LaunchForString (FromAppId + app);
		}

		/// <summary>
		/// Opens for search.
		/// </summary>
		/// <param name="searchTerms">Search terms.</param>
		public void OpenForSearch (string searchTerms)
		{
			LaunchForString (FromSearch + searchTerms);
		}

		private bool LaunchForString (string route)
		{ 
			//var url = new MonoTouch.ObjCRuntime.Libraries.Foundation.NSUrl (route);
			var url = new NSUrl(route);
			if (UIApplication.SharedApplication.CanOpenUrl (url)) {
				UIApplication.SharedApplication.OpenUrl (url);
				return true;
			}
			return false;
		}

    }
}
