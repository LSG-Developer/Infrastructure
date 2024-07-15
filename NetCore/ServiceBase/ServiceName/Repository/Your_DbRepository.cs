using LSG.Infrastructure.Framework.BaseClasses;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    [ExcludeFromCodeCoverage]
    public class Your_DbRepository : BaseDbRepository, Your_IDbRepository
    {
        public Your_DbRepository() : base(){
        }

        public new void Init(IDbConnection conn, string connectionString)
        {
            base.InitConnection(conn, connectionString);
            base.OpenConnection();
        }

        public string GetMessage()
        {
            return "Hello";
        }

    }
}
