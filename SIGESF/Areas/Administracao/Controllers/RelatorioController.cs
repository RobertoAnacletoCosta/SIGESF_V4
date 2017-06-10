using SIGESF.Models;
using SIGESF.ViewModels;
using System.Linq;
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
                join nd in db.NaturezasDespesas
                on d.NaturezaDespesaId equals nd.NaturezaDespesaId
                orderby c.SF_Apropriacao

                select new RelatorioGeralConcessaoViewModel
                {

                    NumSFApropriacao = c.SF_Apropriacao,
                    PROAD = c.Proc_Proad,
                    Nome = a.Nome,
                    UnidadeLotacao = a.Unidades,
                    DataConcessao = c.DataConcessao,
                    PrazoAplicacao = c.PrazoAplicacao,
                    DataFinalAplicacao = c.DataFinalAplicacao,
                    PrazoPrestContas = c.PrazoPrestContas,
                    PrestadoContas = c.PrestadoContas,
                    DataPrestContas = c.DataPrestContas,
                    Finalidade = c.Finalidade,
                    NaturezaDesesa = nd.Descricao,
                    ValorConcedido = d.ValorConcedido,
                    ValorAplicado = d.ValorAplicado,
                    DevolucaoSaque = d.DevolucaoSaque,
                    ValorNaoUtilizado = d.ValorNaoUtilizado

                }
               ).ToList();

            return View(ConsultaGeralConcessao);
        }

        public ActionResult RelatorioGeralAgentesSupridos()
        {
            var ConsultaGeralAgentesSupridos = (

                    from a in db.AgentesSupridos
                    
                    select new RelatorioGeralAgentesSupridosViewModel
                    {
                        Nome = a.Nome,
                        Matricula = a.Matricula,
                        CPF = a.CPF,
                        UnidadeLotacao = a.Unidades
                    }
                    ).ToList();

            return View(ConsultaGeralAgentesSupridos);
        }

        public ActionResult RelatorioSolicitacoesSF()
        {

            return View();
        }
    }
}