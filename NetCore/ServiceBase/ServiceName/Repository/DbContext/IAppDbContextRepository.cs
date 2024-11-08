
using LSG.Framework.EF.Base.Repository.Interfaces;

namespace CompanyName.ProjectName.ServiceName.Repository.DbContext
{
    internal interface IAppDbContextRepository : IDisposable, IBaseDbContextRepository
    {
        public void AddPerson();

        public ICollection<Person> GetPersons();

        public void DeletePerson(Int16 id);

    }
}
