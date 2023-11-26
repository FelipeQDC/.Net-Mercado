using System.ComponentModel.DataAnnotations;

namespace Desafio.ViewModels
{
    public class ProdutoPostViewModel
    {
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public string Descricao { get; set; } = string.Empty;
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public string Categoria { get; set; } = string.Empty;
        [Required]
        public int Quantidade { get; set; }
    }
}