using LSG.Framework.EF.DbContext.DbContextConfigurator.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LSG.Framework.EF.DbContext.DbContextConfigurator
{
    public class MySqlDbContextConfigurator : IDbContextConfigurator
    {
        private string? _connectionString;

        public MySqlDbContextConfigurator(string stringConnection)
        {
            _connectionString = stringConnection;
        }

        void IDbContextConfigurator.ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
