namespace EFInheritanceTest.MVC.Models;

public class Workshop : Place
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    public string? PhoneNumber { get; set; }
}
