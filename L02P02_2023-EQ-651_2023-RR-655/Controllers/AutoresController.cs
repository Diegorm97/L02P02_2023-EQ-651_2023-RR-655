using L02P02_2023_EQ_651_2023_RR_655.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L02P02_2023_EQ_651_2023_RR_655.Controllers
{ 
public class autoresController : Controller


{
    private readonly libreriaDbContext _context;
    public autoresController(libreriaDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var autores = await _context.autores.ToListAsync();
        return View(autores);
    }
}
}
