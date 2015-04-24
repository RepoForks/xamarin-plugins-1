using System;

namespace M16.DataSharer.Plugin.Abstractions
{
    /// <summary>
    /// Interface for M16.DataSharer
    /// </summary>
    public interface IDataSharer
    {
		/// <summary>
		/// Invoke this method to share the <paramref name="text"/>, the following parameter <paramref name="title"/> is not required for all platforms.
		/// </summary>
		/// <param name="text">Text to share.</param>
		/// <param name="title">Title.</param>
        void ShareText(string text, string title = null);
    }
}
