namespace DesafioApi.Models
{

    public class ProdutoLista
    {
        public int Id { get; set; }
        public string Comprador { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

    }
}
