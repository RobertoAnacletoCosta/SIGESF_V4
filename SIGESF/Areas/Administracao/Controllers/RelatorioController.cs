using SIGESF.Models;
using SIGESF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Administracao.Controllers
{
    public class RelatorioController : Controller
    {

        private ContextoEF db = new ContextoEF();

        public ActionResult RelatorioGeralConcessao()
        {

            var ConsultaGeralConcessao = (

                from c in db.ConcessoesSF
                join a in db.AgentesSupridos
                on c.AgenteSupridoId equals a.AgenteSupridoId
                join d in db.DetalhesSF
                on c.ConcessaoSuprimentoFundosId equals d.ConcessaoSuprimentoFundosId
                join nd in db.NaturezaDespesa
                on d.NaturezaDespesaId equals nd.NaturezaDespesaId

                select new RelatorioGeralConcessaoViewModel
                {

                    Nome = a.Nome,
                    Matricula = a.Matricula,
                    PROAD = c.Proc_Proad,
                    NumSFApropriacao = c.SF_Apropriacao,
                    NaturezaDesesa = nd.Descricao,
                    ValorConcedido = d.ValorConcedido,
                    ValorAplicado = d.ValorAplicado,
                    DevolucaoSaque = d.DevolucaoSaque,
                    ValorNaoUtilizado = d.ValorNaoUtilizado

                }
               ).ToList();

            return View(ConsultaGeralConcessao);
        }
    }
}