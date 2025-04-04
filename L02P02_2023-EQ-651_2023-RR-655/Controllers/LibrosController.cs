using L02P02_2023_EQ_651_2023_RR_655.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02P02_2023_EQ_651_2023_RR_655.Controllers
{
    public class LibrosController : Controller
    {
        private readonly libreriaDbContext _context;

        public LibrosController(libreriaDbContext context)
        {
            _context = context;
        }
        [Route("Libros/Index/{idAutor}")]
        public IActionResult Index(int idAutor)
        {
            var autor = _context.autores.FirstOrDefault(a => a.Id == idAutor);
            var libros = _context.libros.Where(l => l.id_autor == idAutor).ToList();

            if (autor == null) return NotFound();

            var viewModel = new AutorLibrosViewModel
            {
                Autor = autor,
                Libros = libros
            };

            return View(viewModel);
        }

    }

    }