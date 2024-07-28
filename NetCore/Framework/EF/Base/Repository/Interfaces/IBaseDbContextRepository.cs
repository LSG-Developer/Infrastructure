namespace LSG.Framework.EF.Base.Repository.Interfaces
{
    public interface IBaseDbContextRepository
    {
        public bool EnsureCreated();
        public void Save();
        public bool IsServerAvailable();
    }
}
