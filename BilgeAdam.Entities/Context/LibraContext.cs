using BilgeAdam.Entities.Models;
using System.Data.Entity;

namespace BilgeAdam.Entities.Context
{
    public class LibraContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Shelve> Shelves { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
