using Microsoft.EntityFrameworkCore;
using APIRESTFul.Domain.Models;

namespace APIRESTFul.Domain.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "Fruits and Vegetables" }, // Id set manually due to in-memory provider
                new Category { Id = 101, Name = "Dairy" }
            );

            //builder.Entity<Products>().ToTable("Products");
            builder.Entity<Products>().HasKey(p => p.Id);
            builder.Entity<Products>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Products>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Products>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Products>().Property(p => p.UnitOfMeasurement).IsRequired();

            builder.Entity<Products>().HasData
            (
                new Products{
                    Id = 100,
                    Name = "Apple",
                    QuantityInPackage = 1,
                    UnitOfMeasurement = EUnitOfMeasurement.Unity,
                    CategoryId = 100
                },
                new Products
                {
                    Id = 101,
                    Name = "Milk",
                    QuantityInPackage = 2,
                    UnitOfMeasurement = EUnitOfMeasurement.Liter,
                    CategoryId = 101,
                }
            );
        }
    }
}
