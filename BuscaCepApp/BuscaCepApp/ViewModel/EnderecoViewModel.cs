using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using BuscaCepApp.Api;
using Xamarin.Forms;

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
            BuscarCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(Cep) || Cep.Length < 8 || Cep.Length > 8)
                    Endereco = "CEP inválido.";
                else
                {
                    var endereco = await ViaCepApi.GetAsync(Cep);
                    Endereco = string.IsNullOrEmpty(endereco?.Cep) ? "CEP não encontrado!" : endereco.ToString();
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
