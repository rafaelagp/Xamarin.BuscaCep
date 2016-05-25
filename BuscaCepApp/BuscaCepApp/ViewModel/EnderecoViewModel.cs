using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using BuscaCepApp.Api;

namespace BuscaCepApp.ViewModel
{
    public class EnderecoViewModel : INotifyPropertyChanged
    {
        public ICommand BuscarCommand { get; set; }
        public string Cep { get; set; }

        private string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                _endereco = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Endereco)));
            }
        }

        public EnderecoViewModel()
        {
            BuscarCommand = new Xamarin.Forms.Command(async () =>
            {
                var endereco = await ViaCepApi.GetAsync(Cep);
                
                var enderecoString = new StringBuilder();
                enderecoString.AppendLine("CEP: " + endereco.Cep);
                enderecoString.AppendLine(endereco.Logradouro);
                enderecoString.AppendLine(endereco.Bairro);
                enderecoString.AppendLine(endereco.Localidade + ", " + endereco.Uf);
                Endereco = enderecoString.ToString();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
