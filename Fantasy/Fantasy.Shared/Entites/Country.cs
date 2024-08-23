using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entites;

public class Country
{
    public int Id { get; set; }

    [Required]
    [MaxLength(110)]
    public string Name { get; set; } = null!;
}