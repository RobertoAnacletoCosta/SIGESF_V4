using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class ItemDeConcessao
    {
        [Key]
        public int ItemDeConcessaoId { get; set; }
        public virtual NaturezaDespesa NaturezaDespesa { get; set; }
        public int NaturezaDespesaId { get; set; }
        public virtual ConcessaoSuprimentoFundos ConcessaoSuprimentoFundos { get; set; }
        public int ConcessaoSuprimentoFundosId { get; set; }
        public decimal Valor { get; set; }
    }
}