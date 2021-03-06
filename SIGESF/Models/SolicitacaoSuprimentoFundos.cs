﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class SolicitacaoSuprimentoFundos
    {
        public int SolicitacaoSuprimentoFundosId { get; set; }

        [Display(Name = "Nº Proc PROAD")]
        public string Proc_Proad { get; set; }

        [Display(Name = "Data da Solicitação")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataSolicitacaoSF { get; set; }

        [Display(Name = "Finalidade da concessão")]
        public string Finalidade { get; set; }

        public virtual AgenteSuprido AgenteSuprido { get; set; }
        public int AgenteSupridoId { get; set; }

        public virtual ICollection<DetalheSolicitacaoSuprimentoFundos> DetalheSolicitacoes { get; set; }
    }
}