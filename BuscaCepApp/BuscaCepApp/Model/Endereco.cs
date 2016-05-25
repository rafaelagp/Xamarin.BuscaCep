﻿using System.ComponentModel;

namespace BuscaCepApp.Model
{
    public class Endereco : INotifyPropertyChanged
    {
        private string _cep;
        public string Cep
        {
            get { return _cep; }
            set
            {
                _cep = value;
                OnPropertyChanged(nameof(_cep));   
            }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
                OnPropertyChanged(nameof(_logradouro));
            }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
                OnPropertyChanged(nameof(_bairro));
            }
        }

        private string _localidade;
        public string Localidade
        {
            get { return _localidade; }
            set
            {
                _localidade = value;
                OnPropertyChanged(nameof(_localidade));
            }
        }

        private string _uf;
        public string Uf
        {
            get { return _uf; }
            set
            {
                _uf = value;
                OnPropertyChanged(nameof(_uf));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
