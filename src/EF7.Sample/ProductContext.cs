using Microsoft.Data.Entity;

namespace EF7.Sample
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            base.OnConfiguring(options);
			options.UseSqlServer("MyConnectionString");
        }
    }
}
