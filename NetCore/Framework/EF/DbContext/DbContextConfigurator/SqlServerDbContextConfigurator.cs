using LSG.Framework.EF.DbContext.DbContextConfigurator.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LSG.Framework.EF.DbContext.DbContextConfigurator
{

    public class SqlServerDbContextConfigurator : IDbContextConfigurator
    {
        private string _connectionString;

        public SqlServerDbContextConfigurator(string stringConnection)
        {
            _connectionString = stringConnection;
        }

        public void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
