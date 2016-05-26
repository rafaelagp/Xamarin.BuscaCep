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
            LogToolbarButton.Clicked += async (sender, args) =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LogView());
            };
            
            //#if DEBUG
            //CepEntry.Text = "20550165";
            //#endif
        }
    }
}
