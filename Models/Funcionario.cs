using System.ComponentModel.DataAnnotations;

namespace ApiTechIlha.Models
{
    public class Funcionario
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? email { get; set; }
        public int? fone { get; set; }
        public string? image { get; set; }
        public string? role { get; set; }

    }
}
