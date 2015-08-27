
using Android.App;
using Android.Widget;

namespace Messier16.Forms.Plugin.Xparse
{
  public class CrossParse
  {
    public CrossParse()
    {

    }

    public void ShowMessage(string text)
    {
      Toast.MakeText(Application.Context, text, ToastLength.Long).Show();
    }
  }
}
