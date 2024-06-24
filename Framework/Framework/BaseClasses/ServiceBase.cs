
using LSG.Infrastructure.Framework.Factory;


namespace LSG.Infrastructure.Framework.BaseClasses
{
    public abstract class ServiceBase 
    {
        public virtual T CastleFactory<T>()
        {
            T repository = CastleWinsorFactory<T>.Create();
            return repository;
        }
    }
}
