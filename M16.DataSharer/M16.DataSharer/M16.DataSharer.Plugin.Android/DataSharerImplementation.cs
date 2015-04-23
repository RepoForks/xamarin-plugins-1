using Android.Content;
using M16.DataSharer.Plugin.Abstractions;
using System;


namespace M16.DataSharer.Plugin
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class DataSharerImplementation : IDataSharer
    {
        public void ShareText(string text, string title = null)
        {
            var ctx = Android.App.Application.Context;
            Intent sendIntent = new Intent();
            sendIntent.SetAction(Intent.ActionSend);
            sendIntent.PutExtra(Intent.ExtraText, text);
            sendIntent.SetType("text/plain");
            ctx.StartActivity(sendIntent);
        }

    }
}