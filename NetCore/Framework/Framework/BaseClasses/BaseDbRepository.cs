using System;
using System.Diagnostics.CodeAnalysis;
using System.Data;
using System.Data.Common;
using LSG.Infrastructure.Framework.Interfaces;

namespace LSG.Infrastructure.Framework.BaseClasses
{
    public abstract class BaseDbRepository : ServiceBase,IRepository 
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


        public void SetGuid(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose() {
            //_connection.Close();
            GC.SuppressFinalize(this);
        }

        ~BaseDbRepository(){
            Dispose();
        }


    }
}
