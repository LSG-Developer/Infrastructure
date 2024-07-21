using Microsoft.EntityFrameworkCore;
using LSG.Framework.DbContextConfigurator;
using LSG.EFRepository.Repository;

namespace CompanyName.ProjectName.ServiceName.Repository.DbContext
{
    public class AppDbContextRepository : BaseDbContextRepository, IAppDbContextRepository
    {
        public DbSet<Person> Persons { get; set; }

        public AppDbContextRepository(IDbContextConfigurator configurator, string fileTag) : base(configurator, fileTag){
          
        }
      
        public void AddPerson()
        {
            Persons.Add(new Person { Name = "John Doe", Age = 30 });
        }


        public ICollection<Person> GetPersons() {
            return Persons.ToList();
        }
    }
}

