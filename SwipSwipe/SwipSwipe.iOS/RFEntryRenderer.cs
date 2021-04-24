using Foundation;
using SwipSwipe;
using SwipSwipe.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RFEntry), typeof(RFEntryRenderer))]
namespace SwipSwipe.iOS
{
    class RFEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
                Control.TextColor = UIColor.White;
            }
        }
    }
}