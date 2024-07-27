using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using LSG.Framework.DbContextConfigurator;
using CompanyName.ProjectName.ServiceName.Repository.DbContext;
using System;
using LSG.EFRepository.DbContextConfigurator;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContextRepository>
{
    public AppDbContextRepository CreateDbContext(string[] args)
    {
        // Configurare le opzioni del DbContext direttamente
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContextRepository>();

        // Qui fornisci la configurazione necessaria, ad esempio:
        // Configura la stringa di connessione o altre opzioni
        optionsBuilder.UseSqlServer();

        // Crea un'istanza di IDbContextConfigurator che è utilizzata dal tuo DbContext
        var configurator = new SqlServerDbContextConfigurator("Server=PCASUSLUIGI\\PCASUSSQLSERVER;Database=myDataBase2;User Id=sa;Password=neuroma9000;TrustServerCertificate=true;");

        // Restituisci un'istanza del tuo DbContext con la configurazione di design-time
        return new AppDbContextRepository(configurator);
    }
}
