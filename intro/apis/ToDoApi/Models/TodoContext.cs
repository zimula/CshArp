using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace TodoApi.Models;

//database context: entity framework functionality from existing library. 
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<Todoitem> TodoItems { get; set; } = null!;
}
