

using System;

namespace LSG.Framework.Factory.Infrastructure.Framework.Interfaces
{
    public interface IService : IDisposable
    {
        void SetGuid(Guid guid);
    }
}
