using LSG.Infrastructure.Framework.BaseClasses;
using System.Diagnostics.CodeAnalysis;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    [ExcludeFromCodeCoverage]
    public class Your_DbRepository : BaseDbRepository, Your_IDbRepository
    {
        public Your_DbRepository() : base(){

        }
        public string GetMessage()
        {
            return "Hello";
        }
    }
}
