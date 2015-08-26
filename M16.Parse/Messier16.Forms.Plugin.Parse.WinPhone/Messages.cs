
using System.Windows;

namespace Messier16.Forms.Plugin.Parse
{
  public class Messages
  {
    public Messages()
    {

    }

    public void ShowMessage(string text)
    {
      MessageBox.Show(string.Empty, text, MessageBoxButton.OK);
    }
  }
}
