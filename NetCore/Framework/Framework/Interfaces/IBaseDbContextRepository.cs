

namespace LSG.Infrastructure.Framework.Interfaces
{
    public interface IBaseDbContextRepository
    {
        public bool EnsureCreated();
        public void Save();
        public bool IsServerAvailable();
    }
}
