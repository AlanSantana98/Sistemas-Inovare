namespace Sistemas_Inovare.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaItem> VendaItens { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }


}
