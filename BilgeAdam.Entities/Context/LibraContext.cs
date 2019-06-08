using BilgeAdam.Entities.Models;
using System.Data.Entity;

namespace BilgeAdam.Entities.Context
{
    public class LibraContext : DbContext
    {
        public LibraContext() : base("lcnn")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LibraContext>());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Shelve> Shelves { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
