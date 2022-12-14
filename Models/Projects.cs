using System.ComponentModel.DataAnnotations;

namespace webapp.Models;

public class Projects
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public string? Owner { get; set; }
}