using Messier16.StoreInteractions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Tasks;
using Windows.System;
using Xamarin.Forms;

[assembly: Dependency(typeof(Messier16.StoreInteractions.WinPhone.StoreInteractions))]
namespace Messier16.StoreInteractions.WinPhone
{
    public class StoreInteractions : IStoreInteractions
    {
        
        public void OpenForPublisher(string publisherName)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?publisher=" + publisherName));
        }

        public void OpenForApp(string app)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:navigate?appid=" + app));
        }

        public void OpenForQuery(string query)
        {
            Launcher.LaunchUriAsync(new Uri("ms-windows-store:search?keyword=" + query + "&contenttype=app"));
        }
        public static void Init() { }
    }
}
