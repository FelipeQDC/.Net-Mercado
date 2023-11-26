
using System.ComponentModel.DataAnnotations;

namespace Desafio.ViewModels
{
    
    public class PedidoViewModel
    {
        public List<produto> produtos {  get; set; }
    
    }
    public class produto
    {
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        public int Quantidade { get; set; }
    }
}

