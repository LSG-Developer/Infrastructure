using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LSG.Framework.DbContextConfigurator;

namespace LSG.EFRepository.DbContextConfigurator
{

    public class SqlServerDbContextConfigurator : IDbContextConfigurator
    {
        private string _connectionString;

        public SqlServerDbContextConfigurator(){

        }

        protected internal void Configuring(string fileTag)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = configBuilder.Build();

            // Accesso diretto ai dati nel file JSON
            string? connectionString = configuration.GetConnectionString(fileTag)
         ?? throw new InvalidOperationException("Connection string 'fileTag' not found.");

            _connectionString = connectionString;
        }

        public void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder, string dbConnectionTag)
        {
            Configuring(dbConnectionTag);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
