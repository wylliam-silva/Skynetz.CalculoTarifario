using Skynetz.CalculoTarifario.Domain._3___Service;
using Skynetz.CalculoTarifario.Domain._4___Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Skynetz.CalculoTarifario
{
    public partial class _Default : Page
    {
        public RepositoryService repository = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            repository = new RepositoryService();
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            int origem = Convert.ToInt32(idOrigem.Value);
            int destino = Convert.ToInt32(idDestino.Value);
            int minutos = Convert.ToInt32(idMinutos.Value);
            int plano = Convert.ToInt32(idPlano.Value);

            var resultado = repository.RepositorioFaleMais.ObterTarifa((Enumerador.ddd)origem, (Enumerador.ddd)destino, minutos, (Enumerador.Plano)plano);

            idTabelaResultado.Visible = true;

            idOrigemResultado.InnerText = $"{resultado.Origem}";
            idDestinoResultado.InnerText = $"{resultado.Destino}";
            idTempoResultado.InnerText = $"{resultado.Tempo}";
            idPlanoFaleMaisResultado.InnerText = $"{resultado.PlanoFaleMais}";
            idComPlanoFaleMaisResultado.InnerText = $"R$ {resultado.ComFaleMais.ToString("0.##")}";
            idSemPlanoFaleMaisResultado.InnerText = $"R$ {resultado.SemFaleMais.ToString("0.##")}";
        }
    }
}