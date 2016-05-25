
using BuscaCepApp.ViewModel;
using Xamarin.Forms;

namespace BuscaCepApp.View
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new EnderecoViewModel();
        }
    }
}
