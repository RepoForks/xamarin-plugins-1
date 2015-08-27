
using MonoTouch.UIKit;

namespace Messier16.Forms.Plugin.Xparse
{
  public class CrossParse
  {
    public CrossParse()
    {

    }

    public void ShowMessage(string text)
    {
      var uiAlert = new UIAlertView(string.Empty, text, null, "OK");
      uiAlert.Show();
    }
  }
}
