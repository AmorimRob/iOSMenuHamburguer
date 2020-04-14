using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollsToTop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPageDetail : ContentPage
    {
        public RootPageDetail()
        {
            InitializeComponent();

            BindingContext = new DetailViewModel();
        }
    }
}
