using SIGESF.Models;
using System;

namespace SIGESF.ViewModels
{
    public class RelatorioGeralConcessaoViewModel
    {
        public string NumSFApropriacao { get; set; }
        public string PROAD { get; set; }
        public string Nome { get; set; }
        public Unidade UnidadeLotacao { get; set; }
        public DateTime DataConcessao { get; set; }
        public int PrazoAplicacao { get; set; }
        public DateTime DataFinalAplicacao { get; set; }
        public DateTime PrazoPrestContas { get; set; }
        public Boolean PrestadoContas { get; set; }
        public DateTime DataPrestContas { get; set; }
        public string Finalidade { get; set; }
        public string NaturezaDesesa { get; set; }
        public decimal ValorConcedido { get; set; }
        public decimal ValorAplicado { get; set; }
        public decimal DevolucaoSaque { get; set; }
        public decimal ValorNaoUtilizado { get; set; }


    }
    
}