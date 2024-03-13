using Tasks_Api.Services;
using Tasks_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Tasks_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    TasksService _service;
    
    public TasksController(TasksService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<TaskEntity> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<TaskEntity> GetById(int id)
    {
        var task = _service.GetById(id);

        if (task is not null)
        {
            return task;
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult Create(TaskEntity newTask)
    {
        var taskCreated = _service.Create(newTask);
        return CreatedAtAction(nameof(GetById), new { id = taskCreated!.Id }, taskCreated);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, TaskEntity task)
    {
        var taskToUpdate = _service.GetById(id);

        if(taskToUpdate is not null)
        {
            _service.Update(id, task);
            return NoContent();    
        }
        else
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var task = _service.GetById(id);

        if (task is not null)
        {
            _service.DeleteById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}