using System.ComponentModel.DataAnnotations;

namespace L02P02_2023_EQ_651_2023_RR_655.Models
{
    public class Clientes
    {
        [Key]

        public int Id { get; set; }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string direccion {  get; set; }
        public DateTime created_at { get; set; }
    }
}
