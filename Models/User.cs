namespace Persistent.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public record UserCreateDto(string Name, string Email);
public record UserUpdateDto(string? Name, string? Email);
