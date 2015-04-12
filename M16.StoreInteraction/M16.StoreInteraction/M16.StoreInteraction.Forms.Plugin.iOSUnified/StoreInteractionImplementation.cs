using M16.StoreInteraction.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.StoreInteraction.Forms.Plugin.iOSUnified;
using UIKit;

[assembly: Dependency (typeof(StoreInteractionImplementation))]
namespace M16.StoreInteraction.Forms.Plugin.iOSUnified
{
	/// <summary>
	/// StoreInteraction Implementation
	/// </summary>
	public class StoreInteractionImplementation : IStoreInteraction
	{
		/// <summary>
		/// Used for registration with dependency service
		/// </summary>
		public static void Init ()
		{
		}

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
            // Do nothing, the following method blows up execution on device
			//LaunchForString (FromSearch + searchTerms);
		}

		/// <summary>
		/// Launchs for string.
		/// </summary>
		/// <returns><c>true</c>, if for string was launched, <c>false</c> otherwise.</returns>
		/// <param name="route">Route.</param>
		private bool LaunchForString (string route)
		{ 
			using (var url = new Foundation.NSUrl (route)) {

				if (UIApplication.SharedApplication.CanOpenUrl (url)) {
					UIApplication.SharedApplication.OpenUrl (url);
					return true;
				}
			}
			return false;
		}
	}
}
