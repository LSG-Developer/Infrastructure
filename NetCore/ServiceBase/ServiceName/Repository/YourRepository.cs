using CompanyName.ProjectName.ServiceName.Repository.Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    [ExcludeFromCodeCoverage]
    public class YourRepository : BaseRepository, IYourRepository
    {
        public YourRepository() : base(){

        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public string GetMessage()
        {
            return base.MessageTest();
        }

        public void SetGuid(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
