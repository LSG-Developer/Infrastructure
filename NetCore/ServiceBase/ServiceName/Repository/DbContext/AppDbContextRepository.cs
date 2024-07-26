using Microsoft.EntityFrameworkCore;
using LSG.Framework.DbContextConfigurator;
using LSG.EFRepository.Repository;

namespace CompanyName.ProjectName.ServiceName.Repository.DbContext
{
    public class AppDbContextRepository : BaseDbContextRepository, IAppDbContextRepository
    {
        public DbSet<Person> Persons { get; set; }

        public AppDbContextRepository(IDbContextConfigurator configurator, string fileTag) : base(configurator, fileTag)
        {

        }

        public void AddPerson()
        {
            Persons.Add(new Person { Name = "John Doe",/*Surname = "Santagada",*/ Age = 30});
        }


        public ICollection<Person> GetPersons()
        {
            return Persons.ToList();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurazioni personalizzate possono essere aggiunte qui
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Person>(entity =>
            //{
            //    entity.Property(e => e.Surname)
            //        .IsRequired()  // Ad esempio, se vuoi rendere la proprietà obbligatoria
            //        .HasMaxLength(100); // e limitare la lunghezza massima a 100 caratteri
            //});
        }
    }
}

