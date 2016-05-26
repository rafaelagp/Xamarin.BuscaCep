using Windows.Storage;
using BuscaCepApp.Service;
using BuscaCepApp.WinPhone.Persistence;
using SQLite;
using Xamarin.Forms;
using Path = System.IO.Path;

[assembly: Dependency(typeof(SQLiteWinPhone))]
namespace BuscaCepApp.WinPhone.Persistence
{
    public class SQLiteWinPhone : ISQLite
    {
        public SQLiteWinPhone()
        {

        }

        public SQLiteAsyncConnection GetConnection()
        {
            var nomeArquivoBd = "BuscaCep.db3";
            var caminhoArquivoBd = Path.Combine(ApplicationData.Current.LocalFolder.Path, nomeArquivoBd);
            var conexao = new SQLiteAsyncConnection(caminhoArquivoBd);

            return conexao;
        }
    }
}