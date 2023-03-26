using Microsoft.EntityFrameworkCore;

namespace CarWorkshopMVC.Entieties
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarWorkshopEntity> CarWorkshops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarWorkshopMVC;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
