using System;
using BuscaCepApp.Droid.Persistence;
using BuscaCepApp.Service;
using SQLite;
using Xamarin.Forms;
using Path = System.IO.Path;

[assembly: Dependency(typeof(SQLiteAndroid))]
namespace BuscaCepApp.Droid.Persistence
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteAndroid()
        {

        }

        public SQLiteAsyncConnection GetConnection()
        {
            var nomeArquivoBd = "BuscaCep.db3";
            var caminhoDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var caminhoArquivoBd = Path.Combine(caminhoDocumentos, nomeArquivoBd);
            var conexao = new SQLiteAsyncConnection(caminhoArquivoBd);

            return conexao;
        }
    }
}