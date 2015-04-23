using System;

namespace M16.DataSharer.Plugin.Abstractions
{
    /// <summary>
    /// Interface for M16.DataSharer
    /// </summary>
    public interface IDataSharer
    {
        void ShareText(string text, string title = null);
    }
}
