using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Models.Blogging;

internal class BloggingDbContext : DbContext {
    public readonly string DatabasePath;

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public BloggingDbContext() {
        string directoryPath = Path.Combine(AppContext.BaseDirectory, "Database");
        DatabasePath = Path.Combine(directoryPath, "Blogging.db");

        if (!Directory.Exists(directoryPath)) {
            Directory.CreateDirectory(directoryPath);
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite($"Data Source={DatabasePath}");
    }
}