# StoreInteraction plugin for Xamarin
Sample usage:
```  
var appButton = new Button { Text = "OneDrive in the Xstore" };
var pubButton = new Button { Text = "Go to Rovio" };
var searchButton = new Button { Text = "Search" };

// OneDrive in the App Store: https://itunes.apple.com/mx/app/onedrive/id477537958?mt=8
// OneDrive in the Windows Phone Store: http://www.windowsphone.com/es-mx/store/app/onedrive/ad543082-80ec-45bb-aa02-ffe7f4182ba8
// OneDrive in the Google Play store: https://play.google.com/store/apps/details?id=com.microsoft.skydrive
appButton.Clicked += (s, a) =>
{
	CrossStoreInteraction.OpenForApp(
		iOS: "id477537958",
		windowsPhone: "ad543082-80ec-45bb-aa02-ffe7f4182ba8",
		android: "com.microsoft.skydrive");
};

// Rovio in the App Store: https://itunes.apple.com/mx/artist/rovio-entertainment-ltd/id298910979?mt=8
// Rovio in the Windows Phone Store: http://www.windowsphone.com/es-MX/store/publishers?publisherId=Rovio%2BEntertainment%2BLtd
// Rovio in the Google Play store: https://play.google.com/store/apps/developer?id=Rovio+Entertainment+Ltd.
pubButton.Clicked += (s, a) =>
{
	CrossStoreInteraction.OpenForPublisher(
		iOS: "rovio-entertainment-ltd/id298910979",
		android: "Rovio+Entertainment+Ltd.",
		windowsPhone: "Rovio Entertainment Ltd" // Remove special url encoded 
		);
};


searchButton.Clicked += (s, a) =>
{
	CrossStoreInteraction.OpenForSearch("futbol");
};


MainPage = new ContentPage
{
	Content = new StackLayout
	{
		VerticalOptions = LayoutOptions.Center,
		Children = {
			appButton,
			pubButton,
			searchButton
		}
	}
};
```  

