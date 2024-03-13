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

    public TaskEntity? Create(TaskEntity newTask)
    {
        _context.Tasks.Add(newTask);
        _context.SaveChanges();

        return newTask;
    }

    public void Update(int id, TaskEntity task)
    {
        var taskToUpdate = _context.Tasks.Find(id);
        if (taskToUpdate is null)
        {
            throw new InvalidOperationException("Task does not exist");
        }
        
        taskToUpdate.Name = task.Name;
        taskToUpdate.IsUrgent = task.IsUrgent;
        taskToUpdate.Due = task.Due;

        _context.SaveChanges();
    }
}