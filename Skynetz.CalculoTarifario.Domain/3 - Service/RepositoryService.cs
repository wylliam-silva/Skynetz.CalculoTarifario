using Skynetz.CalculoTarifario.Domain._1___Model;
using Skynetz.CalculoTarifario.Domain._2___DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynetz.CalculoTarifario.Domain._3___Service
{
    public class RepositoryService
    {
        private RepositoryFaleMais<FaleMais> repositorioFaleMais = null;
        public RepositoryFaleMais<FaleMais> RepositorioFaleMais
        {
            get
            {
                if (repositorioFaleMais == null)
                {
                    repositorioFaleMais = new RepositoryFaleMais<FaleMais>();
                }

                return repositorioFaleMais;
            }
        }
    }
}
