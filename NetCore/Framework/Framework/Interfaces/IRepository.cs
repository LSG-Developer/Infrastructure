

using System;

namespace LSG.Infrastructure.Framework.Interfaces
{
    public interface IRepository : IDisposable
    {
        void SetGuid(Guid id);
    }
}
