using Microsoft.EntityFrameworkCore;

namespace LSG.Framework.DbContextConfigurator
{
    public interface IDbContextConfigurator
    {
        void ConnectionDbConfig(DbContextOptionsBuilder optionsBuilder, string tag);
    }
}