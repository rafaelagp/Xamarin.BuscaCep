using System.ComponentModel;

namespace BuscaCepApp.Model
{
    public class Endereco : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set
            {
                _cep = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_cep)));   
            }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_logradouro)));
            }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_bairro)));
            }
        }

        private string _localidade;
        public string Localidade
        {
            get { return _localidade; }
            set
            {
                _localidade = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_localidade)));
            }
        }

        private string _uf;
        public string Uf
        {
            get { return _uf; }
            set
            {
                _uf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_uf)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
