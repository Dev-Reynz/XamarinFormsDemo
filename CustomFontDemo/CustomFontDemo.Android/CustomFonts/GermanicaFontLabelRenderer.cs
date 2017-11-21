using Android.Graphics;
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