using EntityFrameworkCore.Models.Blogging;

namespace EntityFrameworkCore.Examples;

internal static class Example001 {
    public static void Run() {
        // Note: This sample requires the database to be created before running.
        var db = new BloggingDbContext();

        Console.WriteLine("Database created: " + db.DatabasePath);
        Console.WriteLine();

        // Create
        Console.WriteLine("Creating a new blog.");
        db.Add(new Blog() { Url = "https://blogs.msdn.com/adonet" });
        db.SaveChangesAsync();
        Console.WriteLine();

        // Read
        Console.WriteLine("Reading blogs.");
        IEnumerable<Blog> blogs = db.Blogs.OrderBy(blog => blog.BlogId);

        foreach (Blog blog in blogs) {
            Console.WriteLine(blog);
        }

        Console.WriteLine();

        // Update
        {
            Console.WriteLine("Updating a blog.");
            Blog? blog = db.Blogs.FirstOrDefault(blog => blog.BlogId == 1);

            if (blog == null) return;

            blog.Posts.Add(new Post() { Title = "Hello World", Content = "I wrote an app using EF Core!" });
            db.SaveChangesAsync();
            Console.WriteLine();
        }

        // Delete
        {
            Console.WriteLine("Deleting a blog.");
            Blog? blog = db.Blogs.FirstOrDefault(blog => blog.BlogId == 2);

            if (blog == null) return;
            db.Remove(blog);
            db.SaveChangesAsync();
        }
    }
}