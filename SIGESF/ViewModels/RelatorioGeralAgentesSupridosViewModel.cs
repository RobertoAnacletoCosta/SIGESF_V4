using SIGESF.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SIGESF.ViewModels
{
    public class RelatorioGeralAgentesSupridosViewModel
    {
        [Display(Name = "Nome do Suprido")]
        public string Nome { get; set; }
        [Display(Name = "Número da matricula")]
        public string Matricula { get; set; }
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        [Display(Name = "Unidade")]
        public Unidade UnidadeLotacao { get; set; }
    }
}