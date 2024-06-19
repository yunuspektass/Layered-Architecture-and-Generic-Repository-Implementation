using System.Configuration;
using System.Data.Entity;
using Project.ENTITIES.Models;
using Project.MAP;
using Project.MAP.Options;

namespace Project.DAL.Context;

public class MyContext : DbContext
{
    public MyContext() : base("MyConnection")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Configurations.Add(new AppUserMap());
        modelBuilder.Configurations.Add(new OrderMap());
        modelBuilder.Configurations.Add(new ProductMap());
        modelBuilder.Configurations.Add(new OrderDetailMap());
        modelBuilder.Configurations.Add(new UserProfileMap());
        modelBuilder.Configurations.Add(new CategoryMap());
        modelBuilder.Configurations.Add(new ShipperMap());
    }
    public DbSet<Product> Products { get; set; }
    
    public DbSet<Category> Categories { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    public DbSet<Shipper> Shippers { get; set; }
    
    public DbSet<AppUser> AppUsers { get; set; }
    
    public DbSet<AppUserProfile> UserProfiles { get; set; }

}