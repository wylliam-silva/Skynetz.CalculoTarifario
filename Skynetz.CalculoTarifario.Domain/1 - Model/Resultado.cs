using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynetz.CalculoTarifario.Domain._1___Model
{
    public class Resultado
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int Tempo { get; set; }
        public string PlanoFaleMais { get; set; }
        public decimal ComFaleMais { get; set; }
        public decimal SemFaleMais { get; set; }
    }
}
