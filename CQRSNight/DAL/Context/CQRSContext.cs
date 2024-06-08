using CQRSNight.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.DAL.Context
{
    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9B3JVRI;initial Catalog=CQRSDb;integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}