
using LSG.Infrastructure.Framework.Interfaces;

namespace CompanyName.ProjectName.ServiceName.Repository.DbContext
{
    internal interface IAppDbContextRepository : IDisposable, IBaseDbContextRepository
    {
        public void AddPerson();

        public ICollection<Person> GetPersons();

    }
}
