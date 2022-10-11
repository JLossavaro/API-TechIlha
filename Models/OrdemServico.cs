using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTechIlha.Models
{
    public class OrdemServico
    {

        [Key]
        public int Id { get; set; }
        public int Imei { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }



        public string? DataFinal { get; set; }
        public string Data { get; set; }
        public bool isAuthorized { get; set; }
        public bool isPayed { get; set; } = false;

        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int? TipoServicoId { get; set; }



    }
}
