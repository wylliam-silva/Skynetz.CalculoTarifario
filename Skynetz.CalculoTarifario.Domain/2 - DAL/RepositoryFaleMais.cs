using Skynetz.CalculoTarifario.Domain._4___Util;
using Skynetz.CalculoTarifario.Domain._1___Model;
using Skynetz.CalculoTarifario.Infrastructure._1___Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynetz.CalculoTarifario.Domain._2___DAL
{
    public class RepositoryFaleMais<T> : RepositoryBase<T>
    {
        public Resultado ObterTarifa(Enumerador.ddd origem, Enumerador.ddd destino, int minutos, Enumerador.Plano plano)
        {
            Resultado retorno = new Resultado();

            retorno.Tempo = minutos;

            switch (plano)
            {
                case Enumerador.Plano.FaleMais30:
                    var faleMais30 = new FaleMais30();
                    
                    faleMais30.CalcularTarifaComFaleMais(origem, destino, minutos, ref retorno);
                    faleMais30.CalcularTarifaSemFaleMais(origem, destino, minutos, ref retorno);

                    retorno.PlanoFaleMais = "FaleMais 30";
                    break;
                case Enumerador.Plano.FaleMais60:
                    var faleMais60 = new FaleMais60();

                    faleMais60.CalcularTarifaComFaleMais(origem, destino, minutos, ref retorno);
                    faleMais60.CalcularTarifaSemFaleMais(origem, destino, minutos, ref retorno);

                    retorno.PlanoFaleMais = "FaleMais 60";
                    break;
                case Enumerador.Plano.FaleMais120:
                    var faleMais120 = new FaleMais120();

                    faleMais120.CalcularTarifaComFaleMais(origem, destino, minutos, ref retorno);
                    faleMais120.CalcularTarifaSemFaleMais(origem, destino, minutos, ref retorno);

                    retorno.PlanoFaleMais = "FaleMais 120";
                    
                    break;
                default:
                    break;
            }

            return retorno;
        }
    }
}
