using MerchantAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
