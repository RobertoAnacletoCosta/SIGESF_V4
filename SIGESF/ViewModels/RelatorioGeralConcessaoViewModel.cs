using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIGESF.ViewModels
{
    public class RelatorioGeralConcessaoViewModel
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string PROAD { get; set; }
        public string NumSFApropriacao { get; set; }
        public string NaturezaDesesa { get; set; }
        public decimal ValorConcedido { get; set; }
        public decimal ValorAplicado { get; set; }
        public decimal DevolucaoSaque { get; set; }
        public decimal ValorNaoUtilizado { get; set; }


    }
    
}