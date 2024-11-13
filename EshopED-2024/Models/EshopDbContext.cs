using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models;

public class EshopDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }  

    public EshopDbContext(DbContextOptions<EshopDbContext> options): base(options)
    {
    }
}
