namespace Tasks_Api.Models;

public class Tasks
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Due { get; set; }
}