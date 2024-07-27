
using LSG.Infrastructure.Framework.Interfaces;
using Microsoft.EntityFrameworkCore;
using LSG.Framework.DbContextConfigurator;

namespace LSG.EFRepository.Repository
{
    public abstract class BaseDbContextRepository : DbContext, IBaseDbContextRepository
    {
        private readonly IDbContextConfigurator _configurator;

        protected BaseDbContextRepository(IDbContextConfigurator configurator)
        {
            _configurator = configurator;
        }

        public bool EnsureCreated()
        {
            return Database.EnsureCreated();
        }

        public bool IsServerAvailable()
        {
            try
            {
                // Prova a connettersi al database
                return Database.CanConnect();
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _configurator.ConnectionDbConfig(optionsBuilder);
        }
    }
}
