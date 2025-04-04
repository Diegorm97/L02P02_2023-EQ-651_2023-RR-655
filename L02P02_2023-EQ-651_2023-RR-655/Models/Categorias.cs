using System.ComponentModel.DataAnnotations;

namespace L02P02_2023_EQ_651_2023_RR_655.Models
{
    public class Categorias
    {
        [Key]

        public int Id { get; set; }

        public string categoria { get; set; }
    }
}
