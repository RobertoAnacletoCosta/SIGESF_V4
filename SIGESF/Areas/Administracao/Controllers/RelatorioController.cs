using Rotativa;
using SIGESF.Models;
using SIGESF.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Areas.Administracao.Controllers
{
    public class RelatorioController : Controller
    {

        private ContextoEF db = new ContextoEF();

        public ActionResult GerarRelatorioAgentesSupridos()
        {
            var modelo = ObterAgentesSupridos();

            var pdf = new ViewAsPdf
            {
                ViewName = "AgentesSupridosParaImpressao",
                Model = modelo
            };

            return pdf;
        }

        public ActionResult GerarRelatorioConcessoes()
        {
            var modelo = ObterConcessao();

            var pdf = new ViewAsPdf
            {
                ViewName = "ConcessoesParaImpressao",
                Model = modelo
            };

            return pdf;
        }

        public ActionResult GerarRelatorioSolicitacoes()
        {
            var modelo = ObterSolicitacoes();

            var pdf = new ViewAsPdf
            {
                ViewName = "SolicitacoesParaImpressao",
                Model = modelo
            };

            return pdf;
        }

        public ActionResult RelatorioGeralConcessao()
        {

            var ConsultaGeralConcessao = ObterConcessao();

            return View(ConsultaGeralConcessao);
        }

        public ActionResult RelatorioGeralAgentesSupridos()
        {
            var ConsultaGeralAgentesSupridos = ObterAgentesSupridos();
            return View(ConsultaGeralAgentesSupridos);
        }

        public ActionResult RelatorioGeralSolicitacoes()
        {
            var ConsultaGeralSolicitacao = ObterSolicitacoes();
            return View(ConsultaGeralSolicitacao);
        }

        public IEnumerable<RelatorioGeralAgentesSupridosViewModel> ObterAgentesSupridos()
        {

            var ConsultaGeralAgentesSupridos = (

                    from a in db.AgentesSupridos

                    select new RelatorioGeralAgentesSupridosViewModel
                    {
                        Nome = a.Nome,
                        Matricula = a.Matricula,
                        CPF = a.CPF,
                        UnidadeLotacao = a.UnidadeLotacao
                    }
                    ).ToList();

            return ConsultaGeralAgentesSupridos;

        }

        public IEnumerable<RelatorioGeralConcessaoViewModel> ObterConcessao()
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
                    UnidadeLotacao = a.UnidadeLotacao,
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

            return ConsultaGeralConcessao;
        }

        public IEnumerable<RelatorioGeralSolicitacoesViewModel> ObterSolicitacoes()
        {

            var ConsultaGeralSolicitacao = (

                from s in db.SolicitacoesSF
                join a in db.AgentesSupridos
                on s.AgenteSupridoId equals a.AgenteSupridoId
                join ds in db.DetalheSolicitacoes
                on s.SolicitacaoSuprimentoFundosId equals ds.SolicitacaoSuprimentoFundosId
                join nd in db.NaturezasDespesas
                on ds.NaturezaDespesaId equals nd.NaturezaDespesaId
                orderby s.Proc_Proad

                select new RelatorioGeralSolicitacoesViewModel
                {
                    Nome = a.Nome,
                    PROAD = s.Proc_Proad,
                    DataSolicitacaoSF = s.DataSolicitacaoSF,
                    UnidadeLotacao = a.UnidadeLotacao,
                    Finalidade = s.Finalidade,
                    NaturezaDesesa = nd.Descricao,
                    ValorSolicitado = ds.ValorSolicitado
                }
               ).ToList();

            return ConsultaGeralSolicitacao;
        }
    }
}