using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LSG.Framework.DbContextConfigurator;

namespace LSG.EFRepository.DbContextConfigurator
{

    public class SqlServerDbContextConfigurator : IDbContextConfigurator
    {
        private string _connectionString;

        public SqlServerDbContextConfigurator(string stringConnection){
            _connectionString = stringConnection;
        }

        public void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
