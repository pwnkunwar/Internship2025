using Microsoft.EntityFrameworkCore;
using ProductCRUD.Models;

namespace ProductCRUD.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
