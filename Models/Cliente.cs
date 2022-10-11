using System.ComponentModel.DataAnnotations;

namespace ApiTechIlha.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public int CPF { get; set; }
        public string Nome { get; set; }
        public int? Telefone { get; set; }
        public string? Endereco { get; set; }
    }
}
