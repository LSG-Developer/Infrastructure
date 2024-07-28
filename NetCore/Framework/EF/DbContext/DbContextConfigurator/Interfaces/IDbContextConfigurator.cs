using Microsoft.EntityFrameworkCore;

namespace LSG.Framework.EF.DbContext.DbContextConfigurator.Interfaces
{
    public interface IDbContextConfigurator
    {
        void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder);
    }
}