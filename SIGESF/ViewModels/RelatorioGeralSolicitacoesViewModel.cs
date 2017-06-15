using SIGESF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.ViewModels
{
    public class RelatorioGeralSolicitacoesViewModel
    {
        [Display(Name = "Nome do Suprido")]
        public string Nome { get; set; }
        [Display(Name = "Nº Processo PROAD")]
        public string PROAD { get; set; }
        [Display(Name = "Unidade")]
        public Unidade UnidadeLotacao { get; set; }
        [Display(Name = "Data de solicitação")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataSolicitacaoSF { get; set; }
        [Display(Name = "Finalidade da concessão")]
        public string Finalidade { get; set; }
        [Display(Name = "Natureza de despesa")]
        public string NaturezaDesesa { get; set; }
        [Display(Name = "Valor solicitado")]
        public decimal ValorSolicitado { get; set; }
    }
}