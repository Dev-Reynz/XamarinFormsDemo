using Android.Graphics;
using CustomFontDemo.CustomFont;
using CustomFontDemo.Droid.CustomFonts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(MuseoFontLabel), typeof(MuseoFontLabelRenderer))]
namespace CustomFontDemo.Droid.CustomFonts
{
    public class MuseoFontLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;

            if (Element.Text.Length > 0)
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "MuseoSansCyrl_0.otf");
        }
    }
}