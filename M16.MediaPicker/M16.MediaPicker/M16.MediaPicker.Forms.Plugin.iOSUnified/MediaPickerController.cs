﻿using System;
using System.Collections.Generic;
using System.Text;

namespace M16.MediaPicker.Forms.Plugin.iOSUnified
{
    using System;
    using System.Threading.Tasks;
    using M16.MediaPicker.Forms.Plugin.Abstractions;
    using Foundation;
    using UIKit;

    /// <summary>
    /// Class MediaPickerController. This class cannot be inherited.
    /// </summary>
    public sealed class MediaPickerController : UIImagePickerController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaPickerController"/> class.
        /// </summary>
        /// <param name="mpDelegate">The mp delegate.</param>
        internal MediaPickerController(MediaPickerDelegate mpDelegate)
        {
            base.Delegate = mpDelegate;
        }

        /// <summary>
        /// Gets or sets the delegate.
        /// </summary>
        /// <value>The delegate.</value>
        /// <exception cref="NotSupportedException"></exception>
        public override NSObject Delegate
        {
            get
            {
                return base.Delegate;
            }
            set
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Gets the result asynchronous.
        /// </summary>
        /// <returns>Task&lt;MediaFile&gt;.</returns>
        public Task<MediaFile> GetResultAsync()
        {
            return ((MediaPickerDelegate)Delegate).Task;
        }
    }
}
