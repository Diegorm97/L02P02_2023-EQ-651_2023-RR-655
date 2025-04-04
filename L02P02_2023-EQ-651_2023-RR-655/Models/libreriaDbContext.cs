using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace L02P02_2023_EQ_651_2023_RR_655.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions options) : base(options)

        {

        }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Autores> autores { get; set; }
        public DbSet<Categorias> categorias { get; set; }
        public DbSet<Libros> libros { get; set; }
        public DbSet<Pedido_encabezado> pedido_encabezados { get; set; }
        public DbSet<Pedido_detalle> pedido_detalles { get; set; }
        public DbSet<Comentarios_libros> comentarios_libros { get; set; }

    }

}
