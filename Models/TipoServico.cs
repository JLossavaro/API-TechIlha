using System.ComponentModel.DataAnnotations;

namespace ApiTechIlha.Models
{
    public class TipoServico
    {
        [Key]
        public int id { get; set; }
        public string servicoNome { get; set; }
    }
}
