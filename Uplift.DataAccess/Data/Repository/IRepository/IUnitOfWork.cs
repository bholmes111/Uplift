using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        public ICategoryRepository Category { get; }

        public IFrequencyRepository Frequency { get; }

        public IServiceRepository Service { get; }

        void Save();
    }
}
