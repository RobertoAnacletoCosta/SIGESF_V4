using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class DetalheSolicitacaoSuprimentoFundos
    {
        [Key]
        public int DetalheSolicitacaoId { get; set; }
        public virtual SolicitacaoSuprimentoFundos SolicitacaoSuprimentoFundos { get; set; }
        public int SolicitacaoSuprimentoFundosId { get; set; }
        public virtual NaturezaDespesa NaturezasDespesas { get; set; }
        public int NaturezaDespesaId { get; set; }

        [Display(Name = "Valor solicitado")]
        public decimal ValorSolicitado { get; set; }
    }
}