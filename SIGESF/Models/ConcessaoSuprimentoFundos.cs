using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class ConcessaoSuprimentoFundos
    {

        public int ConcessaoSuprimentoFundosId { get; set; }

        [Display(Name = "Nº Proc PROAD")]
        public string Proc_Proad { get; set; }

        [Display(Name = "Data de Concessão")]
        public DateTime DataConcessao { get; set; }

        [Display(Name = "Nº SF de Apropriação")]
        public DateTime SF_Apropriacao { get; set; }

        [Display(Name = "Prazo de Aplicação")]
        public int PrazoAplicacao { get; set; }

        [Display(Name = "Data Final de Aplicação")]
        public DateTime DataFinalAplicacao { get; set; }

        [Display(Name = "Prazo da Prestação de Contas")]
        public DateTime PrazoPrestContas { get; set; }

        [Display(Name = "Prestado Contas?")]
        public Boolean PrestadoContas { get; set; }

        [Display(Name = "Data Prestação de Contas")]
        public DateTime DataPrestContas { get; set; }

        [Display(Name = "Finalidade da concessão")]
        public string Finalidade { get; set; }

        public virtual AgenteSuprido AgenteSuprido { get; set; }
        public int AgenteSupridoId { get; set; }

        public virtual ICollection<DetalheConcessaoAplicacaoSF> DetalhesSF { get; set; }
    }
}