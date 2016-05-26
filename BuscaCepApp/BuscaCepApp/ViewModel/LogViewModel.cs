using System.Collections.Generic;
using BuscaCepApp.Model;
using BuscaCepApp.Service;

namespace BuscaCepApp.ViewModel
{
    public class LogViewModel
    {
        public IEnumerable<Endereco> Enderecos { get; set; }

        public LogViewModel()
        {
          Enderecos = new EnderecoService().Listar();
        } 
    }
}
