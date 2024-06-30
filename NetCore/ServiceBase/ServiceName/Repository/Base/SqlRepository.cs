using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Data;

namespace CompanyName.ProjectName.ServiceName.Repository.Base
{
    public abstract class SqlRepository
    {
        protected IDbConnection _connection;

        protected SqlRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
