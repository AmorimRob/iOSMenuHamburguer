using ScrollsToTop.Controles;
using ScrollsToTop.CustomRenderers.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomScrollView), typeof(CustomScrollViewRenderer))]
namespace ScrollsToTop.CustomRenderers.iOS.CustomRenderers
{
    public class CustomScrollViewRenderer : ScrollViewRenderer
    {
        public CustomScrollViewRenderer() => ScrollsToTop = false;
    }
}
