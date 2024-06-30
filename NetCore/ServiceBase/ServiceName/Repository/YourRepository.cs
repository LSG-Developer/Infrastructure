using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    [ExcludeFromCodeCoverage]
    public class YourRepository :  IYourRepository
    {
        public YourRepository() 
        {

        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public string GetMessage()
        {
            return "Hello from database";
        }

        public void SetGuid(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
