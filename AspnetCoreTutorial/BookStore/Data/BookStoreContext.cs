using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class BookStoreContext : DbContext {
    public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

    public DbSet<Book> Book { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<Publisher> Publisher { get; set; }
}