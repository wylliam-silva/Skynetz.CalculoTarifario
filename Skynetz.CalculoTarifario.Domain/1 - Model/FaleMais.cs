using Skynetz.CalculoTarifario.Domain._1___Model.Tarifas;
using Skynetz.CalculoTarifario.Domain._4___Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynetz.CalculoTarifario.Domain._1___Model
{
    public class FaleMais
    {
        public string Origem { get; set;}
        public string Destino { get; set; }
        public decimal ValorMinuto { get; set; }

        public void CalcularTarifaSemFaleMais(Enumerador.ddd origem, Enumerador.ddd destino, int minutos, ref Resultado retorno)
        {
            decimal valorTarifa = 0.00M;

            var baseCalculoTarifa = ObterBaseCalculo(origem, destino, ref retorno);

            valorTarifa = minutos * baseCalculoTarifa;

            retorno.SemFaleMais = valorTarifa;
        }

        protected decimal ObterBaseCalculo(Enumerador.ddd origem, Enumerador.ddd destino, ref Resultado retorno)
        {
            decimal baseCalculoTarifa = 0.00M;

            switch (origem)
            {
                case Enumerador.ddd._011:
                    var ddd011 = new _011();

                    retorno.Origem = "011";

                    if (destino.Equals(Enumerador.ddd._016))
                    {
                        baseCalculoTarifa = ddd011._016;
                        retorno.Destino = "016";
                    }
                    else if (destino.Equals(Enumerador.ddd._017))
                    {
                        baseCalculoTarifa = ddd011._017;
                        retorno.Destino = "017";
                    }
                    else if (destino.Equals(Enumerador.ddd._018))
                    {
                        baseCalculoTarifa = ddd011._018;
                        retorno.Destino = "018";
                    }
                        
                    break;
                case Enumerador.ddd._016:
                    var ddd016 = new _016();

                    retorno.Origem = "016";

                    if (destino.Equals(Enumerador.ddd._011))
                    {
                        baseCalculoTarifa = ddd016._011;
                        retorno.Destino = "011";
                    }
                        
                    break;
                case Enumerador.ddd._017:
                    var ddd017 = new _017();

                    retorno.Origem = "017";

                    if (destino.Equals(Enumerador.ddd._011))
                    {
                        baseCalculoTarifa = ddd017._011;
                        retorno.Destino = "011";
                    }
                        
                    break;
                case Enumerador.ddd._018:
                    var ddd018 = new _018();

                    retorno.Origem = "018";

                    if (destino.Equals(Enumerador.ddd._011))
                    {
                        baseCalculoTarifa = ddd018._011;
                        retorno.Destino = "011";
                    }
                        
                    break;
                default:
                    break;
            }

            return baseCalculoTarifa;
        }

    }
}
