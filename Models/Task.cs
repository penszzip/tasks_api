using System.ComponentModel.DataAnnotations;
namespace Tasks_Api.Models;

public class TaskEntity
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }
    public DateTime Due { get; set; }
}