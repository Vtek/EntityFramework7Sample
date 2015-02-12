using System.Data.Entity;

namespace EF6.Sample
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext()
            : base("MyConnectionString")
        {
            
        }
    }
}
