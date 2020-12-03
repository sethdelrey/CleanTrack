using CleanTrack.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanTrack.Data
{
    public class AdminContext : DbContext
    {
        public DbSet<CleaningSession> Sessions { get; set; }

        public AdminContext(DbContextOptions<AdminContext> options)
            : base(options)
        { }

        public AdminContext()
            : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CleanTrack;Integrated Security=True");
        }
    }
}
