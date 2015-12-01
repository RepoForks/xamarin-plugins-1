using M16.ColorAppBars.Plugin.Abstractions;
using System;
using M16.ColorAppBars.Plugin;

namespace Battery.Plugin
{
    /// <summary>
    /// Cross platform Battery implemenations
    /// </summary>
    public class CrossColoredAppBar
    {
        static Lazy<IColorAppBar> Implementation = new Lazy<IColorAppBar>(() => CreateBattery(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IColorAppBar Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IColorAppBar CreateBattery()
        {
#if PORTABLE
            return null;
#else
            return new ColorAppBarImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }


    }
}
