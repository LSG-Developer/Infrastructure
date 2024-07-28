using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LSG.Framework.DbContextConfigurator;

namespace LSG.EFRepository.DbContextConfigurator
{
    public class MySqlDbContextConfigurator : IDbContextConfigurator
    {
        private string? _connectionString;

        public MySqlDbContextConfigurator(string stringConnection)
        {
            _connectionString = stringConnection;
        }

        public void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
