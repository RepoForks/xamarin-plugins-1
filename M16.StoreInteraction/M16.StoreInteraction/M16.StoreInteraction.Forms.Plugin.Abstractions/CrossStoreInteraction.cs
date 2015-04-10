using System;
using Xamarin.Forms;

namespace M16.StoreInteraction.Forms.Plugin.Abstractions
{
	public static class CrossStoreInteraction
	{
		static Lazy<IStoreInteraction> _lol =
			new Lazy<IStoreInteraction> (CreateObject, System.Threading.LazyThreadSafetyMode.PublicationOnly);


		static void OpenForPublisher(string iOS = null, string android = null, string windowsPhone = null)
		{
			_lol.Value.OpenForPublisher(Device.OnPlatform<string>(iOS:iOS, Android: android, WinPhone: windowsPhone));
		}

		static void OpenForApp(string iOS = null, string android = null, string windowsPhone = null)
		{
			_lol.Value.OpenForApp(Device.OnPlatform<string>(iOS:iOS, Android: android, WinPhone: windowsPhone));
		}

		static void OpenForSearch(string searchTerms)
		{
			_lol.Value.OpenForSearch(searchTerms);
		}

		static IStoreInteraction CreateObject ()
		{
			return DependencyService.Get<IStoreInteraction> ();
		}

	}
}

