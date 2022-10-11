namespace ApiTechIlha.Models
{
    public class Movimentacoes
    {
        public Movimentacoes(string categoria, double valor)
        {
            this.date = DateTime.Now.ToString("d/M/yyyy");
            this.valor = valor;
            this.categoria = categoria;
        }
        public int id { get; set; }
        public string categoria { get; set; }
        public double valor { get; set; }

        public string date { get; set; }

    }
}
