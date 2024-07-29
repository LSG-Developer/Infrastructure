using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Data;

namespace CompanyName.ProjectName.ServiceName.Repository.DbSql
{
    [ExcludeFromCodeCoverage]
    public class Your_DbRepositoryStub : Your_IDbRepository
    {
        private bool disposedValue;

        public string GetMessage()
        {
            return "Hello from Test!";
        }

        public void SetGuid(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~YourRepositoryStub()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void Init(IDbConnection connection, string connectionString)
        {
            throw new NotImplementedException();
        }

        public void get_person_name()
        {
            throw new NotImplementedException();
        }
    }
}
