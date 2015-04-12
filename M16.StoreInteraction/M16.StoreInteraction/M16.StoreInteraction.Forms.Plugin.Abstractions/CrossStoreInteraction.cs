using System;
using Xamarin.Forms;

namespace M16.StoreInteraction.Forms.Plugin.Abstractions
{
    /// <summary>
    /// This class helps you to use the StoreInteraction pluging, hiding the call to the Dependency Service.
    /// Internally it uses the <code>OnPlatform</code>
    /// </summary>
    public static class CrossStoreInteraction
    {
        static Lazy<IStoreInteraction> _lol =
            new Lazy<IStoreInteraction>(CreateObject, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// TBA
        /// </summary>
        /// <param name="iOS"></param>
        /// <param name="android"></param>
        /// <param name="windowsPhone"></param>
        public static void OpenForPublisher(string iOS = null, string android = null, string windowsPhone = null)
        {
            _lol.Value.OpenForPublisher(Device.OnPlatform<string>(iOS: iOS, Android: android, WinPhone: windowsPhone));
        }

        /// <summary>
        /// TBA
        /// </summary>
        /// <param name="iOS"></param>
        /// <param name="android"></param>
        /// <param name="windowsPhone"></param>
        public static void OpenForApp(string iOS = null, string android = null, string windowsPhone = null)
        {
            _lol.Value.OpenForApp(Device.OnPlatform<string>(iOS: iOS, Android: android, WinPhone: windowsPhone));
        }

        /// <summary>
        /// TBA
        /// </summary>
        /// <param name="searchTerms"></param>
        public static void OpenForSearch(string searchTerms)
        {
            if (TargetPlatform.WinPhone != Device.OS)
                searchTerms = searchTerms.Replace(' ', '+');
            _lol.Value.OpenForSearch(searchTerms);
        }

        static IStoreInteraction CreateObject()
        {
            return DependencyService.Get<IStoreInteraction>();
        }

    }
}

