using Microsoft.EntityFrameworkCore;
using Tasks_Api.Models;

namespace Tasks_Api.Data;

public class TaskDbContext : DbContext
{
    public TaskDbContext (DbContextOptions<TaskDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskEntity> Tasks { get; set; }
}