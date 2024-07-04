using System;
using System.Diagnostics.CodeAnalysis;
using System.Data;
using System.Data.Common;

namespace CompanyName.ProjectName.ServiceName.Repository.Base
{
    public abstract class BaseRepository
    {
        protected internal IDbConnection _connection;

        protected internal BaseRepository(){
            //_connection.ConnectionString = connection_string;
            //_connection.Open();
        }

        protected internal void Dispose()
        {
            //_connection.Close();
        }

        protected internal string MessageTest()
        {
            return "Hello from Web";
        }
    }
}
