using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor.Models;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Category>().HasData(
            new Category(1, "Action", 1),
            new Category(2, "SciFi", 2),
            new Category(3, "History", 3)
        );
    }
}