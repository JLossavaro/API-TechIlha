using System.ComponentModel.DataAnnotations;

namespace ApiTechIlha.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public string image { get; set; }

    }
}
