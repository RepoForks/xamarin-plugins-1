using M16.DataSharer.Plugin.Abstractions;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;


namespace M16.DataSharer.Plugin
{
    /// <summary>
    /// Implementation for M16.DataSharer
    /// </summary>
    public class DataSharerImplementation : IDataSharer
    {
        public void ShareText(string text, string title = null)
        {
            var obj = new MonoTouch.Foundation.NSObject[] { new NSString(text) };
            var viewController = new UIActivityViewController(obj, null);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewControllerAsync(viewController, true);
        }
    }
}