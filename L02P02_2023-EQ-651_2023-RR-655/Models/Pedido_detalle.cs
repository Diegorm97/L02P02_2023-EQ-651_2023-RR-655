using System.ComponentModel.DataAnnotations;

namespace L02P02_2023_EQ_651_2023_RR_655.Models
{
    public class Pedido_detalle
    {
        [Key]
        
        public int Id { get; set; }
        
        public int id_pedido { get; set; }
        public int id_libro { get; set; }
        public DateTime created_at { get; set; }


    }
}
