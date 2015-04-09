using Messier16.StoreInteractions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Tasks;
using Windows.System;

[assembly: Dependency(typeof(Messier16.StoreInteractions.WinPhone.StoreInteractions))]
namespace Messier16.StoreInteractions.WinPhone
{
    public class StoreInteractions : IStoreInteractions
    {
        public bool OpenForPublisher(string publisherName)
        {
            // Docs: https://msdn.microsoft.com/en-us/library/windows/apps/dn770213(v=vs.105).aspx
            Launcher.LaunchUriAsync(new Uri("zune:search?publisher=Abundantcode"));
        }

        public bool OpenForApp(string app)
        {
            MarketplaceDetailTask marketplaceDetailTask = new MarketplaceDetailTask();
            marketplaceDetailTask.ContentIdentifier = "34a64bd8-3bc5-4438-91c4-1f0c072e8524";
            marketplaceDetailTask.Show();
            return true;
        }

        public bool OpenForQuery(string query)
        {
            var search = new MarketplaceSearchTask();
            search.SearchTerms = query;
            return true;
        }
    }
}
