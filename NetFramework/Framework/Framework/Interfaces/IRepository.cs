﻿

using System;

namespace LSG.Framework.Factory.Infrastructure.Framework.Interfaces
{
    public interface IRepository : IDisposable
    {
        void SetGuid(Guid id);
    }
}
