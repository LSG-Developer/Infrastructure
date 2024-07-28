
using LSG.Framework.Factory.Infrastructure.Framework.Factory;


namespace LSG.Framework.Factory.Infrastructure.Framework.BaseClasses
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
