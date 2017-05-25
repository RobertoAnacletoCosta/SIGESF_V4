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

        public virtual AgenteSuprido AgenteSuprido { get; set; }

        public int AgenteSupridoId { get; set; }

        //[Required(ErrorMessage = "Informe o prazo de Aplicação do Suprimento de Fundos")]
        [Display(Name = "Prazo de Aplicação")]
        public DateTime PrazoAplicacao { get; set; }

        [Required(ErrorMessage = "Informe o prazo de Prestação de Contas")]
        [Display(Name = "Prestado Contas")]
        public Boolean PrestadoContas { get; set; }

        public virtual ICollection<ItemDeConcessao> ItensSF { get; set; }
    }
}