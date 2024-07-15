
using LSG.Infrastructure.Framework.Interfaces;
using System.Data;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    public interface Your_IDbRepository :IDisposable
    {
        string  GetMessage();
        public void Init(IDbConnection conn, string connectionString);
    }
}
