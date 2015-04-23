using M16.DataSharer.Plugin.Abstractions;
using System;
using Windows.ApplicationModel.DataTransfer;


namespace M16.DataSharer.Plugin
{
  /// <summary>
  /// Implementation for M16.DataSharer
  /// </summary>
  public class DataSharerImplementation : IDataSharer, IDisposable
  {
      DataTransferManager dataTransferManager;
      private string _title;
      private string _text;


      public DataSharerImplementation()
      {
          dataTransferManager = DataTransferManager.GetForCurrentView();
          dataTransferManager.DataRequested += ShareTextHandler;
      }

      public void ShareText(string text, string title = null)
      {
          _title = title ?? "Share text";
          _text = text;
          DataTransferManager.ShowShareUI();
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