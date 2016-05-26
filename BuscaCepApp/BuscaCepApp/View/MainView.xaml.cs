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
            
            #if DEBUG
            CepEntry.Text = "20550165";
            #endif
        }
    }
}
