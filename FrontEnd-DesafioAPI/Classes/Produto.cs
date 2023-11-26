using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrontEnd_DesafioAPI.Classes
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
