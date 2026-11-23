using EntityFrameworkCore.Models.Blogging;

namespace EntityFrameworkCore.Examples;

internal static class Example001 {
    public static void Run() {
        var db = new BloggingDbContext();

        Console.WriteLine("Database created: " + db.DatabasePath);
    }
}