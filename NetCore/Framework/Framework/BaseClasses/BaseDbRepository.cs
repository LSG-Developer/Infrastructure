using System;
using System.Diagnostics.CodeAnalysis;
using System.Data;
using System.Data.Common;
using LSG.Infrastructure.Framework.Interfaces;
using System.Xml.Linq;

namespace LSG.Infrastructure.Framework.BaseClasses
{
    public abstract class BaseDbRepository : ServiceBase, IRepository
    {
        protected internal IDbConnection? _connection;

        protected internal BaseDbRepository(IDbConnection connection, string connectionString)
        {
            _connection = connection;
            _connection.ConnectionString = connectionString;

        }

        public void OpenConnection()
        {
            _connection.Open();
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
