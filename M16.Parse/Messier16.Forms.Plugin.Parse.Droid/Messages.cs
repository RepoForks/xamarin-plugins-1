
using Android.App;
using Android.Widget;

namespace Messier16.Forms.Plugin.Parse
{
  public class Messages
  {
    public Messages()
    {

    }

    public void ShowMessage(string text)
    {
      Toast.MakeText(Application.Context, text, ToastLength.Long).Show();
    }
  }
}
