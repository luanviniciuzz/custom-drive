using Drive.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Drive.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FileModel> Files { get; set; }

        //OnModelCreating serve para carregar automaticamente todas as
        //configurações de mapeamento (EntityTypeConfiguration)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
