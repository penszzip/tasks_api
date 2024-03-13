using Microsoft.EntityFrameworkCore;
using Tasks_Api.Data;
using Tasks_Api.Models;

namespace Tasks_Api.Services;

public class TasksService
{

    private readonly TaskDbContext _context;

    public TasksService(TaskDbContext context)
    {
        _context = context;
    }

    public IEnumerable<TaskEntity> GetAll()
    {
        return _context.Tasks
            .ToList();
    }

    public TaskEntity? GetById(int id)
    {
        return _context.Tasks
            .SingleOrDefault(p => p.Id == id);
    }
}