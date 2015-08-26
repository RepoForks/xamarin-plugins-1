
using MonoTouch.UIKit;

namespace Messier16.Forms.Plugin.Parse
{
  public class Messages
  {
    public Messages()
    {

    }

    public void ShowMessage(string text)
    {
      var uiAlert = new UIAlertView(string.Empty, text, null, "OK");
      uiAlert.Show();
    }
  }
}
