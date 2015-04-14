using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M16.MediaPicker.Forms.Plugin.Abstractions.Args
{
    /// <summary>
    /// Class MediaPickerErrorArgs.
    /// </summary>
    public class MediaPickerErrorArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaPickerErrorArgs" /> class.
        /// </summary>
        /// <param name="ex">The ex.</param>
        public MediaPickerErrorArgs(Exception ex)
        {
            Error = ex;
        }

        /// <summary>
        /// Gets the error.
        /// </summary>
        /// <value>The error.</value>
        public Exception Error { get; private set; }
    }
}