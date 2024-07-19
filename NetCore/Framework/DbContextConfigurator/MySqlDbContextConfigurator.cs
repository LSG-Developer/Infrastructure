using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LSG.Framework.DbContextConfigurator;

namespace LSG.EFRepository.DbContextConfigurator
{
    public class MySqlDbContextConfigurator : IDbContextConfigurator
    {
        private string _connectionString;

        public MySqlDbContextConfigurator(){
        }

        protected internal void Configuration(string fileTag)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = configBuilder.Build();

            string? connectionString = configuration.GetConnectionString(fileTag)

         ?? throw new InvalidOperationException("Connection string 'fileTag' not found.");

            _connectionString = connectionString;
        }

        public void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder, string dbConnectionTag)
        {
            Configuration(dbConnectionTag);

            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }
    }
}
