using System.ComponentModel.DataAnnotations;

namespace L02P02_2023_EQ_651_2023_RR_655.Models
{
    public class Pedido_encabezado
    {
        [Key]

        public int Id { get; set; }

        public int id_cliente { get; set; }

        public int cantidad_libros { get; set; }

        public double total { get; set; }

    }
}
