using Skynetz.CalculoTarifario.Domain._1___Model.Tarifas;
using Skynetz.CalculoTarifario.Domain._4___Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynetz.CalculoTarifario.Domain._1___Model
{
    public class FaleMais30: FaleMais
    {
        public void CalcularTarifaComFaleMais(Enumerador.ddd origem, Enumerador.ddd destino, int minutos, ref Resultado retorno)
        {
            decimal valorTarifa = 0.00M;

            var baseCalculoTarifa = base.ObterBaseCalculo(origem, destino, ref retorno);

            if (minutos > 30)
            {
                var minutosExcedentes = minutos - 30;
                valorTarifa = minutosExcedentes * baseCalculoTarifa;
                valorTarifa += (valorTarifa / 100M) * 10M;
            }

            base.CalcularTarifaSemFaleMais(origem, destino, minutos, ref retorno);
            retorno.ComFaleMais = valorTarifa;
        }

    }
}
