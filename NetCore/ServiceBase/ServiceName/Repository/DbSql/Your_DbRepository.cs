using Azure;
using LSG.Infrastructure.Framework.BaseClasses;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CompanyName.ProjectName.ServiceName.Repository.DbSql
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

        public void get_person_name()
        {
            using (IDbCommand command = this._connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetPersonByAge";

                var parameter = command.CreateParameter();
                parameter.ParameterName = "@Age";
                parameter.Value = 30;
                parameter.DbType = DbType.Int32;
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Id"));
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        int retrievedAge = reader.GetInt32(reader.GetOrdinal("Age"));

                        Console.WriteLine($"Id: {id}, Name: {name}, Age: {retrievedAge}");
                    }
                    else
                    {
                        Console.WriteLine("No person found with the given age.");
                    }
                }
            }
        }
    }
}
