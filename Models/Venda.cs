
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiTechIlha.Models
{
    public class Venda
    {


        [Key]
        public int id { get; set; }
        [Required]
        public int idProduto { get; set; }

        [Required]
        public int quantidade { get; set; }

        public string nomeProduto { get; set; }

        public string data { get; set; }

        public double valor { get; set; }


        public double valorTotal { get; set; }




    }
}
