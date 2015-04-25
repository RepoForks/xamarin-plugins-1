## Why?
My very first plugin made just to practice. I got inspired by another plugin that allowed you to rate an app after certain actions. 

This plugin is intended to make access to the application store easy for you.

### What can it do?
This plugin lets you open the default app store for your device within your application using Xamarin.Forms. 

With this plugin you can:

 - Open the store showing a specific application
 - Open the store showing all apps for a specific publisher
 - Open the store showing search results 

### Sample usage
To make things easier for you, the static class `CrossStoreInteraction` wraps the call to the `DependencyService` and provides three methods:
##### Open store for app
Lets say we want to open OneDrive's application page in our device store, we can access it online through these http links:  
App Store - http://itunes.apple.com/mx/app/onedrive/id477537958  
Windows Phone Store - http://www.windowsphone.com/es-mx/store/app/onedrive/ad543082-80ec-45bb-aa02-ffe7f4182ba8  
Google Play - https://play.google.com/store/apps/details?id=com.microsoft.skydrive  
All we must do in code is:
``` 
 CrossStoreInteraction.OpenForApp(
	 iOS: "id477537958",
	 windowsPhone: "ad543082-80ec-45bb-aa02-ffe7f4182ba8",
	 android: "com.microsoft.skydrive");
 ```  

##### Open store for publisher
 Lets say we want to see Rovio's applications in our device store, we can access it online through these links:  
App Store - https://itunes.apple.com/mx/artist/rovio-entertainment-ltd/id298910979  
Windows Phone Store - http://www.windowsphone.com/es-MX/store/publishers?publisherId=Rovio%2BEntertainment%2BLtd  
Google Play - https://play.google.com/store/apps/developer?id=Rovio+Entertainment+Ltd.  
All we must do in code is:
```
CrossStoreInteraction.OpenForPublisher(
	iOS: "rovio-entertainment-ltd/id298910979",
	android: "Rovio+Entertainment+Ltd.",
	windowsPhone: "Rovio Entertainment Ltd" );
 ``` 
##### Open for search
This is the easiest one, may be we want to search for "mexican football" (yeah, I love mexican football), all we have to do is call:
```  
CrossStoreInteraction.OpenForSearch("mexican football");
```

#### Reference links

[Android Developers](http://developer.android.com/distribute/tools/promote/linking.html)  
[GeekChamp](http://www.geekchamp.com/tips/how-to-use-the-marketplace-tasks-in-windows-phone-8)  
[StackOverflow 2](http://stackoverflow.com/questions/24589262/what-is-the-equivalent-to-marketplacedetailtask-contentidentifier-for-windows)  
[MSDN 1](https://msdn.microsoft.com/en-us/library/windows/apps/hh394017(v=vs.105).aspx)  
[MSDN 2](https://msdn.microsoft.com/en-us/library/windows/apps/hh974767.aspx)  
[Bjango](http://bjango.com/articles/ituneslinks/)  
[StackOverflow 3](http://stackoverflow.com/questions/893604/how-to-link-to-the-itunes-store-from-iphone-app)  
[iTunes link maker](http://linkmaker.itunes.apple.com/mx)  


> Written with [StackEdit](https://stackedit.io/).
