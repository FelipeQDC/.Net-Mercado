namespace DesafioApi.Models
{
    public class Transacões
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantidades { get; set; } 
        public DateTime DateTime { get; set; }
        public decimal Valor { get; set; }
        public string status { get; set; } = string.Empty;

    }
}
