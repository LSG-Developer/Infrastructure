using System;
using System.Diagnostics.CodeAnalysis;
using System.Data;
using System.Data.Common;
using LSG.Infrastructure.Framework.BaseClasses;

namespace CompanyName.ProjectName.ServiceName.Repository.Base
{
    public abstract class BaseDbRepository : ServiceBase,IDisposable 
    {
        protected internal IDbConnection? _connection;

        protected internal BaseDbRepository(){
            }
        private bool disposed = false;

        protected internal void InitConnection(IDbConnection connection,string connectionString)
        {
            _connection = connection;
            _connection.ConnectionString = connectionString;
        }

        public void Dispose() {
            _connection.Close();
            GC.SuppressFinalize(this);
        }

        ~BaseDbRepository(){
            Dispose();
        }


    }
}
