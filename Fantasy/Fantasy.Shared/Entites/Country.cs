using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entites;

public class Country
{
    public int Id { get; set; }

    [Required]
    [MaxLength(110)]
    public string Name { get; set; } = null!;

    public ICollection<Team>? Teams { get; set; }

    public int TeamsCount => Teams == null ? 0 : Teams.Count;
}