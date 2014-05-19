using SQLite.Net;

namespace Panoply.Common.Contracts
{
    public interface IDbConnectionService
    {
        SQLiteConnection Connection { get; }
        string ConnectionString { get; }
    }
}
