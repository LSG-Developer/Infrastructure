
using Microsoft.EntityFrameworkCore;
using LSG.Framework.EF.DbContext.DbContextConfigurator.Interfaces;
using LSG.Framework.EF.Base.Repository.Interfaces;

namespace LSG.Framework.EF.Base.Repository
{
    public abstract class BaseDbContextRepository : Microsoft.EntityFrameworkCore.DbContext, IBaseDbContextRepository
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
