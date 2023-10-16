using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Siticone.Desktop.UI.WinForms;
using System.Threading.Channels;

namespace MessLibrary
{
    public class ProgramContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<MessageInfo> Messages { get; set; } = null!;

        public ProgramContext() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=messenger;Username=postgres;Password=I21EV0405postgre");
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }
       
    }
}