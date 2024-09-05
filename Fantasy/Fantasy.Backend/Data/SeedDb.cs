using Fantasy.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace Fantasy.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();//Verifica si la BD existe y sino la crea, tambien verifica las migraciones
        await CheckCountriesAsync();
        await CheckTeamsAsync();
    }

    private async Task CheckCountriesAsync()
    {
        if (!_context.Countries.Any())
        {
            var countriesSQLScript = File.ReadAllText("Data\\Countries.sql");
            await _context.Database.ExecuteSqlRawAsync(countriesSQLScript);
        }
    }

    private async Task CheckTeamsAsync()
    {
        if (!_context.Teams.Any())
        {
            foreach (var country in _context.Countries)
            {
                _context.Teams.Add(new Team { Name = country.Name, Country = country! });
                if (country.Name == "Dominican Republic")
                {
                    _context.Teams.Add(new Team { Name = "Aguilas Cibaeñas", Country = country! });
                    _context.Teams.Add(new Team { Name = "Tigeres del Licey", Country = country! });
                    _context.Teams.Add(new Team { Name = "Leones del Escogido", Country = country! });
                    _context.Teams.Add(new Team { Name = "Gigantes del Cibao", Country = country! });
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}