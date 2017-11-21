using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomFontDemo.CustomFont;
using CustomFontDemo.Droid.CustomFonts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(GermanicaFontLabel),typeof(GermanicaFontLabelRenderer))]
namespace CustomFontDemo.Droid.CustomFonts
{
    public class GermanicaFontLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;

            if (Element.Text.Length > 0)
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "PlainGermanica.ttf");
        }
    }
}