using almaarmudgoz.Models.Base; 
using almaarmudgoz.Models;
using Microsoft.EntityFrameworkCore;

namespace almaarmudgoz.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> optionsBuilder) : base(optionsBuilder)
        {

        }
        public DbSet<Slide> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}

