using System;
using System.ComponentModel;
using System.Windows.Input;
using BuscaCepApp.Api;
using BuscaCepApp.Model;

namespace BuscaCepApp.ViewModel
{
    public class EnderecoViewModel : INotifyPropertyChanged
    {
        public ICommand BuscarCommand { get; set; }

        public string Cep { get; set; }

        private Endereco _endereco;
        public Endereco Endereco
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
                Endereco = endereco;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
