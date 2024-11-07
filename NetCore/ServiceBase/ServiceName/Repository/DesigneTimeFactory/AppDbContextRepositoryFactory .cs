using LSG.Framework.EF.DbContext.DbContextConfigurator.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using LSG.Framework.EF.DbContext.DbContextConfigurator;
using CompanyName.ProjectName.ServiceName.Repository.DbContext;

namespace CompanyName.ProjectName.ServiceName.Repository.DesigneTimeFactory
{
    public class AppDbContextRepositoryDesignTimeFactory : IDesignTimeDbContextFactory<AppDbContextRepository>
    {
        public AppDbContextRepository CreateDbContext(string[] args)
        {
            //var configurator = new SqlServerDbContextConfigurator("Server = PCASUSLUIGI\\PCASUSSQLSERVER; Database = myDataBase3; User Id = sa; Password = neuroma9000; TrustServerCertificate = true;"); // Implementazione di base o fittizia per il design-time

            var configurator = new MySqlDbContextConfigurator("Server=192.168.43.117;database=db_test10;uid=admin;password=Neuroma9000!"); // Implementazione di base o fittizia per il design-time
            
            return new AppDbContextRepository(configurator);
        }
    }
}
