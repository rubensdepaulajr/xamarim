using SQLite.Net.Interop;

namespace CrudSQLite
{
    public interface IConfig
    {
        string DiretorioSqLite { get; }
        ISQLitePlatform Plataforma { get; }
    }
}