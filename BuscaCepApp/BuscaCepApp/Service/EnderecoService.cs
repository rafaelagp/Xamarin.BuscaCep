using System.Collections.Generic;
using BuscaCepApp.Model;
using SQLite;
using Xamarin.Forms;

namespace BuscaCepApp.Service
{
    public class EnderecoService
    {
        private readonly SQLiteAsyncConnection _repositorio;

        public EnderecoService()
        {
            _repositorio = DependencyService.Get<ISQLite>().GetConnection();
            _repositorio.CreateTableAsync<Endereco>();
        }

        public IEnumerable<Endereco> Listar()
        {
            var resultado = _repositorio.Table<Endereco>().ToListAsync().Result;
            return resultado;
        }

        public void Inserir(Endereco endereco)
        {
            _repositorio.InsertAsync(endereco);
        }
    }
}
