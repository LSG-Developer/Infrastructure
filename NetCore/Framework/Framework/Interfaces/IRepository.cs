

using System;
using System.Data;

namespace LSG.Infrastructure.Framework.Interfaces
{
    public interface IRepository : IDisposable
    {
        void SetGuid(Guid id);
        public void InitConnection(IDbConnection connection, string connectionString);
    }
}
