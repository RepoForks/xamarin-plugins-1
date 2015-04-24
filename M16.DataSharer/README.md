## Why?
I was looking for a simple idea for a plugin that could be easily implemented and hasn't yet been done so I came up with this idea.

Then an idea for an app that could make use of a plugin like this came to me and BOOM, here it is.

### What can it do?
This plugin allows you to invoke the device's default share UI to share text ~~and media~~ between apps.


### Usage
As of today the plugin exposes a single method:
```
void ShareText(string text, string title = null);
```
Calling to this method will invoke the default share UI that will enable you user to select an application to share the `text` with.


### References
[Android Developers - Sharing simple data](https://developer.android.com/training/sharing/send.html)  
[iOS developer library - Share](https://developer.apple.com/library/ios/documentation/General/Conceptual/ExtensibilityPG/ShareSheet.html)  
[Another iOS page](https://developer.apple.com/library/ios/documentation/iPhone/Conceptual/iPhoneOSProgrammingGuide/Inter-AppCommunication/Inter-AppCommunication.html#//apple_ref/doc/uid/TP40007072-CH6-SW2)  
[Share sheet page - iOS](http://www.knowyourmobile.com/mobile-phones/apple-ios-8/22816/how-use-ios-8-extensions)
[W Dev center - Sharing and receiving data](https://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh871363.aspx)

> Written with [StackEdit](https://stackedit.io/).

