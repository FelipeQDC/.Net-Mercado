namespace DesafioApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public string Category { get; set; } = string.Empty;

    }
}