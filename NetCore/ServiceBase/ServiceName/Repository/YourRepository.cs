using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace CompanyName.ProjectName.ServiceName.Repository
{
    [ExcludeFromCodeCoverage]
    public class YourRepository :  IYourRepository
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public string GetMessage()
        {
            //string stringConnection = "Server=localhost;Database=TestDb;User Id=sqlaccess;Password=sqlaccess;";
            //SqlConnection conn = new SqlConnection(stringConnection);
            //SqlCommand command = new SqlCommand("INSERT INTO Tabella ([Campo]) VALUES ('USA');", conn);
            //conn.Open();
            //command.ExecuteScalar();
            return "Hello from database";
        }

        public void SetGuid(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
