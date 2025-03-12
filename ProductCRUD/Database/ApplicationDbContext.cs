using Microsoft.EntityFrameworkCore;
using ProductCRUD.Models;

namespace ProductCRUD.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
       
        public DbSet<Product> Products { get; set; }
    }
}
