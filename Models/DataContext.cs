using Microsoft.EntityFrameworkCore;

namespace ArtTime.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Artista> Artista { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}