using Foundation;
using M16.DataSharer.Plugin.Abstractions;
using System;
using UIKit;


namespace M16.DataSharer.Plugin
{
  /// <summary>
  /// Implementation for M16.DataSharer
  /// </summary>
  public class DataSharerImplementation : IDataSharer
  {
      public void ShareText(string text, string title = null)
      {
          var obj = new NSObject[] { new NSString(text) };
          //UIActivityViewController viewController = new UIActivityViewController(,)
          var viewController = new UIActivityViewController(obj, null);
          UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewControllerAsync(viewController, true);
      }
  }
}