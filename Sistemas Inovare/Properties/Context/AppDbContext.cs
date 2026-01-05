//using Microsoft.EntityFrameworkCore;
//using Bando_de_Dados_Elton.Models;

//namespace Bando_de_Dados_Elton.Properties.Context
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//        {
//        }

//        public DbSet<CondominioViewModel> Condominio { get; set; }
//        public DbSet<EquipeViewModel> Equipe { get; set; }
//        public DbSet<IgrejaViewModel> Igreja { get; set; }
//        public DbSet<LiderancaViewModel> Lideranca { get; set; }
//        public DbSet<SegmentoViewModel> Segmento { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Configurações adicionais se necessário
//        }
//    }
//}
using Microsoft.EntityFrameworkCore;
using Sistemas_Inovare.Models;

namespace Sistemas_Inovare.Properties.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<ItensVenda> ItensVenda { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<Venda> Venda { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir chave primária para EquipeViewModel
            modelBuilder.Entity<Categorias>()
                .HasKey(c => c.Id);

            // Definir chave primária para CondominioViewModel (supondo um campo Id_Condominio)
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Id_Condominio); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para IgrejaViewModel (supondo um campo Id_Igreja)
            modelBuilder.Entity<Empresas>()
                .HasKey(i => i.Id_Igreja); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para LiderancaViewModel (supondo um campo Id_Lideranca)
            modelBuilder.Entity<Estoque>()
                .HasKey(l => l.Id_Liderança); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para SegmentoViewModel (supondo um campo Id_Segmento)
            modelBuilder.Entity<FormaPagamento>()
                .HasKey(s => s.Id_Segmento); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para SegmentoViewModel (supondo um campo Id_Segmento)
            modelBuilder.Entity<ItensVenda>()
                .HasKey(s => s.Id_Segmento); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para SegmentoViewModel (supondo um campo Id_Segmento)
            modelBuilder.Entity<Produto>()
                .HasKey(s => s.Id_Segmento); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para SegmentoViewModel (supondo um campo Id_Segmento)
            modelBuilder.Entity<usuarios>()
                .HasKey(s => s.Id_Segmento); // Ajuste o nome do campo conforme necessário

            // Definir chave primária para SegmentoViewModel (supondo um campo Id_Segmento)
            modelBuilder.Entity<Venda>()
                .HasKey(s => s.Id_Segmento); // Ajuste o nome do campo conforme necessário

            base.OnModelCreating(modelBuilder);
        }
    }
}


