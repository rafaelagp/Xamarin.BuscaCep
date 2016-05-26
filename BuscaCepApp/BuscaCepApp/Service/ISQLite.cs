using SQLite;

namespace BuscaCepApp.Service
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
