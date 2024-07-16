using LSG.Infrastructure.Framework.BaseClasses;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    [ExcludeFromCodeCoverage]
    public class Your_DbRepository : BaseDbRepository, Your_IDbRepository
    {
        public Your_DbRepository(IDbConnection conn, string connectionString) : base(conn, connectionString){
        }

        public string GetMessage()
        {
            return "Hello";
        }

    }
}
