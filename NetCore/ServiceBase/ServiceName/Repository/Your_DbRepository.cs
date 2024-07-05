using CompanyName.ProjectName.ServiceName.Repository.Base;
using System;
using System.Data;
using System.Data.SqlClient;
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
