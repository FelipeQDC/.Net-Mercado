using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd_DesafioAPI.Classes
{
    internal class transacoes
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantidades { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Valor { get; set; }
        public string status { get; set; } = string.Empty;
    }
}
