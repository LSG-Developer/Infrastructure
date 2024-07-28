
using System.Data;
using LSG.Framework.DbSql.Base.Repository.Interfaces;

namespace LSG.Framework.DbSql.Base.Repository
{
    public abstract class BaseDbRepository : IRepository
    {
        protected internal IDbConnection _connection;

        protected internal BaseDbRepository(IDbConnection connection, string connectionString)
        {
            _connection = connection;
            _connection.ConnectionString = connectionString;
            _connection.Open();
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public void SetGuid(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _connection.Close();
            GC.SuppressFinalize(this);
        }

        ~BaseDbRepository()
        {
            Dispose();
        }


    }
}
