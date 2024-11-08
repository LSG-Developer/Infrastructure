using LSG.Framework.EF.Base.Repository;
using LSG.Framework.EF.DbContext.DbContextConfigurator.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace CompanyName.ProjectName.ServiceName.Repository.DbContext
{
    public class AppDbContextRepository : BaseDbContextRepository, IAppDbContextRepository
    {
        public DbSet<Person> Persons { get; set; }

        public AppDbContextRepository(IDbContextConfigurator configurator) : base(configurator){
        }

        void IAppDbContextRepository.AddPerson(){
            Persons.Add(new Person { Name = "John Doe", Surname = "Santagada", Age = 30,Address= "via del capo",PersonId=1});
        }

        void IAppDbContextRepository.DeletePerson(Int16 id){

            var personToRemove = Persons.FirstOrDefault(p => p.PersonId == id);

            if (personToRemove != null)
            {
                Persons.Remove(personToRemove);
            }    
        }


        ICollection<Person> IAppDbContextRepository.GetPersons()
        {
            return Persons.ToList();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurazioni personalizzate possono essere aggiunte qui
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Surname)
                    .IsRequired()  // Ad esempio, se vuoi rendere la proprietà obbligatoria
                    .HasMaxLength(100); // e limitare la lunghezza massima a 100 caratteri

                entity.Property(e => e.PersonId)
                    .IsRequired();  // Ad esempio, se vuoi rendere la proprietà obbligatoria

            });
        }
    }
}

