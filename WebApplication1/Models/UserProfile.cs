using System.ComponentModel.DataAnnotations;

namespace Deshawns.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}