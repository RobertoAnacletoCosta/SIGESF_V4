using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class DetalheConcessaoAplicacaoSF
    {
        [Key]
        public int DetConcAplicId { get; set; }
        public virtual ConcessaoSuprimentoFundos ConcessaoSuprimentoFundos { get; set; }
        public int ConcessaoSuprimentoFundosId { get; set; }
        public virtual NaturezaDespesa NaturezasDespesas { get; set; }
        public int NaturezaDespesaId { get; set; }

        [Display(Name = "Valor concedido")]
        public decimal ValorConcedido { get; set; }

        [Display(Name = "Valor aplicado")]
        public decimal? ValorAplicado { get; set; }

        [Display(Name = "Devolução de saque")]
        public decimal? DevolucaoSaque { get; set; }

        [Display(Name = "Valor não utilizado")]
        public decimal? ValorNaoUtilizado { get; set; }
    }
}