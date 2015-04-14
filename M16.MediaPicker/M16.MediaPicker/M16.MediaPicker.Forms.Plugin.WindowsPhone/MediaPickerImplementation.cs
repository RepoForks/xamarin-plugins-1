using M16.MediaPicker.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using M16.MediaPicker.Forms.Plugin.WindowsPhone;

[assembly: Dependency(typeof(MediaPickerImplementation))]
namespace M16.MediaPicker.Forms.Plugin.WindowsPhone
{
    /// <summary>
    /// M16.MediaPicker Implementation
    /// </summary>
    public class MediaPickerImplementation : IMediaPicker
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        public bool IsCameraAvailable
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsPhotosSupported
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsVideosSupported
        {
            get { throw new NotImplementedException(); }
        }

        public System.Threading.Tasks.Task<MediaFile> SelectPhotoAsync(CameraMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<MediaFile> TakePhotoAsync(CameraMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<MediaFile> SelectVideoAsync(VideoMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<MediaFile> TakeVideoAsync(VideoMediaStorageOptions options)
        {
            throw new NotImplementedException();
        }

        public EventHandler<Abstractions.Args.MediaPickerArgs> OnMediaSelected
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public EventHandler<Abstractions.Args.MediaPickerErrorArgs> OnError
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
