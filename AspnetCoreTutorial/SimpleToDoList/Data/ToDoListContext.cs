using Microsoft.EntityFrameworkCore;
using SimpleToDoList.Entities;

namespace SimpleToDoList.Data;

public class ToDoListContext : DbContext {
    public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options) { }

    public DbSet<ToDo> ToDoList { get; set; }
}