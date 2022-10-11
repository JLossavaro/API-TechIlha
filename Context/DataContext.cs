using ApiTechIlha.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTechIlha.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
         => Database.EnsureCreated();

        public DbSet<User> usuarios { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Movimentacoes> movimentacoes { get; set; }
        public DbSet<Produto> produtos { get; set; }

        public DbSet<Funcionario> funcionarios { get; set; }

        public DbSet<OrdemServico> OS { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<OrdemServico>(x =>
            {
                x.ToSqlQuery("");
            });
            */

            builder.Entity<User>().HasData(new List<User>()
            {
                 new() {id= 1,Username = "julio_admin", Email="julio.admin@bol.br", Password="admin123", Name="Julio", Surname="Lossavaro", Role="Administrator" },
                 new() {id= 2,Username = "julio_user", Email="julio.user@bol.br", Password="user123", Name="Julio", Surname="Lossavaro", Role="Standard"},
            });
        }


        public DbSet<ApiTechIlha.Models.Venda>? Venda { get; set; }


        public DbSet<ApiTechIlha.Models.OrdemServico>? OrdemServico { get; set; }


        public DbSet<ApiTechIlha.Models.TipoServico>? TipoServico { get; set; }
    }
}
