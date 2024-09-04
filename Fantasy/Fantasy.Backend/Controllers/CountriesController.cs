using Fantasy.Backend.Data;
using Fantasy.Backend.UnitsOfWork.Interfaces;
using Fantasy.Shared.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fantasy.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : GenericController<Country>
{
    public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
    {
    }
}