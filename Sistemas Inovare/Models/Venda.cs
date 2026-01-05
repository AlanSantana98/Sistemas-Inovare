namespace Sistemas_Inovare.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<VendaItem> Itens { get; set; } = new();
        public decimal Total => Itens.Sum(i => i.Quantidade * i.PrecoUnitario);
    }


}
