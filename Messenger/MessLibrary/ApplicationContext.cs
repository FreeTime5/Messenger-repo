using Microsoft.EntityFrameworkCore;

namespace MessLibrary
{
    public class ProgramContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<MessageInfo> Messages { get; set; } = null!;

        public ProgramContext() 
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=messenger;Username=postgres;Password=I21EV0405postgre");
        }
    }
}