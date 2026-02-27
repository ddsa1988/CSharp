using App.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Data;

public class WarehouseDbContext : DbContext {
    public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Component> Components { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectComponent> ProjectComponents { get; set; }
}