namespace Sistemas_Inovare.Models
{
    public class ItensVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }


}
