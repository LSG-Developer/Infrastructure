

using System;

namespace LSG.Infrastructure.Framework.Interfaces
{
    public interface IService : IDisposable
    {
        void SetGuid(Guid guid);
    }
}
