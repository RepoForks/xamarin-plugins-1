using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace M16.MediaPicker.Forms.Plugin.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    public static class CrossMediaPicker
    {
        static Lazy<IMediaPicker> _lol =
            new Lazy<IMediaPicker>(CreateObject, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public static IMediaPicker Current { get { return _lol.Value; } }


        static IMediaPicker CreateObject()
        {
            return DependencyService.Get<IMediaPicker>();
        }

    }

}
