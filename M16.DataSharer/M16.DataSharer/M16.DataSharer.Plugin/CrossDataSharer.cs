using M16.DataSharer.Plugin.Abstractions;
using System;

namespace M16.DataSharer.Plugin
{
    /// <summary>
    /// Cross platform M16.DataSharer implemenations
    /// </summary>
    public class CrossDataSharer
    {
        static Lazy<IDataSharer> Implementation = new Lazy<IDataSharer>(() => CreateDataSharer(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IDataSharer Current
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

        static IDataSharer CreateDataSharer()
        {
#if PORTABLE
            return null;
#else
        return new DataSharerImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
