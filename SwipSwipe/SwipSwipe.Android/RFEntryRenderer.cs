using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SwipSwipe;
using Xamarin.Forms.Platform.Android;
using SwipSwipe.Droid;
using Android.Text;
using Android.Graphics.Drawables;
using Android.Content.Res;

[assembly: ExportRenderer (typeof(RFEntry), typeof(RFEntryRenderer))]
namespace SwipSwipe.Droid
{
    class RFEntryRenderer : EntryRenderer
    {
        public RFEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                Control.Background = gd;
                Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            }
        }
    }
}