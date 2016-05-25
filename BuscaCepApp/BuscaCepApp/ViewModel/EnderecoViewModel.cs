using System;
using System.ComponentModel;
using System.Windows.Input;
using BuscaCepApp.Model;

namespace BuscaCepApp.ViewModel
{
    public class EnderecoViewModel : INotifyPropertyChanged
    {
        public ICommand BuscarCommand { get; set; }

        private IObserver<Endereco> _endereco;
        public IObserver<Endereco> Endereco
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
                
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
