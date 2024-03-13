using Tasks_Api.Services;
using Tasks_Api.Models;
using Microsoft.AspNetCore.Mvc;

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
}