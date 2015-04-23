using M16.DataSharer.Plugin.Abstractions;
using System;
using Windows.ApplicationModel.DataTransfer;

namespace M16.DataSharer.Plugin
{
    public class DataSharerImplementation : IDataSharer,IDisposable
    {

        public void ShareText(string text, string title = null)
        {
            _title = title ?? "Share text";
            _text = text;
            DataTransferManager.ShowShareUI();
        }



        DataTransferManager dataTransferManager;
        private string _title;
        private string _text;
        
        public DataSharerImplementation()
        {
            dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += ShareTextHandler;
        }

        private void ShareTextHandler(DataTransferManager sender, DataRequestedEventArgs e)
        {
            DataRequest request = e.Request;
            request.Data.Properties.Title = _title;
            //request.Data.Properties.Description = "A demonstration that shows how to share text.";
            request.Data.SetText(_text);
        }

        public void Dispose()
        {
            dataTransferManager.DataRequested -= ShareTextHandler;
        }
    }
}
