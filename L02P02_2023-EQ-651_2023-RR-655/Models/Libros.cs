using System.ComponentModel.DataAnnotations;

namespace L02P02_2023_EQ_651_2023_RR_655.Models
{
    public class Libros
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string url_imagen { get;set; }
        public int id_autor {  get; set; }
        public int id_categoria { get; set; }
        public double precio { get; set; }
        public string estado { get; set; }
    }
}
