using BuscaCepApp.ViewModel;
using Xamarin.Forms;

namespace BuscaCepApp.View
{
    public partial class LogView : ContentPage
    {
        public LogView()
        {
            InitializeComponent();
            BindingContext = new LogViewModel();
        }
    }
}
