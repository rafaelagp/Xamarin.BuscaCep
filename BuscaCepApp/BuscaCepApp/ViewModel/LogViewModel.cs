using System.Collections.Generic;
using BuscaCepApp.Model;

namespace BuscaCepApp.ViewModel
{
    public class LogViewModel
    {
        public IEnumerable<Endereco> Enderecos { get; set; }

        public LogViewModel()
        {
            Enderecos = new List<Endereco>()
            {
                new Endereco()
                {
                    Id = 1,
                    Cep = "CEP",
                    Logradouro = "Rua",
                    Bairro = "Bairro",
                    Localidade = "Cidade",
                    Uf = "UF"
                },
                new Endereco()
                {
                    Id = 2,
                    Cep = "CEP 2",
                    Logradouro = "Rua 2",
                    Bairro = "Bairro 2",
                    Localidade = "Cidade 2",
                    Uf = "UF 2"
                }
            };
        } 
    }
}
