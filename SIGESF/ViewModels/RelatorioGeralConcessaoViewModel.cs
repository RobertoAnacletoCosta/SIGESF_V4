using SIGESF.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SIGESF.ViewModels
{
    public class RelatorioGeralConcessaoViewModel
    {
        [Display(Name = "Nº SF Apropriação")]
        public string NumSFApropriacao { get; set; }
        [Display(Name = "Nº Processo PROAD")]
        public string PROAD { get; set; }
        [Display(Name = "Nome do Suprido")]
        public string Nome { get; set; }
        [Display(Name = "Unidade")]
        public Unidade UnidadeLotacao { get; set; }
        [Display(Name = "Data de concessão")]
        public DateTime DataConcessao { get; set; }
        [Display(Name = "Prazo aplicação em dias")]
        public int PrazoAplicacao { get; set; }
        [Display(Name = "Data final aplicação")]
        public DateTime DataFinalAplicacao { get; set; }
        [Display(Name = "Prazo prestação de contas")]
        public DateTime PrazoPrestContas { get; set; }
        [Display(Name = "Prestado contas?")]
        public Boolean PrestadoContas { get; set; }
        [Display(Name = "Data prestação contas")]
        public DateTime? DataPrestContas { get; set; }
        [Display(Name = "Finalidade da concessão")]
        public string Finalidade { get; set; }
        [Display(Name = "Natureza de despesa")]
        public string NaturezaDesesa { get; set; }
        [Display(Name = "Valor concedido")]
        public decimal ValorConcedido { get; set; }
        [Display(Name = "Valor aplicado")]
        public decimal ValorAplicado { get; set; }
        [Display(Name = "Devolução de saque")]
        public decimal DevolucaoSaque { get; set; }
        [Display(Name = "Valor não utilizado")]
        public decimal ValorNaoUtilizado { get; set; }
    }
    
}