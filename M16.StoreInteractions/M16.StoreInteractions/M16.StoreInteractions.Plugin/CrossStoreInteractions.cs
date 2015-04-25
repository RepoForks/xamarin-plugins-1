using M16.StoreInteractions.Plugin.Abstractions;
using System;

namespace M16.StoreInteractions.Plugin
{
    /// <summary>
    /// Cross platform M16.StoreInteractions implemenations
    /// </summary>
    public class CrossStoreInteractions
    {
        static Lazy<IStoreInteractions> Implementation = new Lazy<IStoreInteractions>(() => CreateStoreInteractions(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IStoreInteractions Current
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

        static IStoreInteractions CreateStoreInteractions()
        {
#if PORTABLE
            return null;
#else
            return new StoreInteractionsImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}
