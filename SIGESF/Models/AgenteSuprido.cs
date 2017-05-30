using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class AgenteSuprido
    {
        [Key]
        [Column(Order = 1)]
        public int AgenteSupridoId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        [Display(Name = "Nome completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Matricula")]
        [StringLength(11, ErrorMessage = "Máximo de 11 caracteres")]
        [Display(Name = "Número da matricula")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o CPF")]
        [StringLength(11, ErrorMessage = "Máximo de 11 caracteres")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Unidade")]
        [Display(Name = "Unidade")]
        public Unidade Unidades { get; set; }
        public virtual ICollection<ConcessaoSuprimentoFundos> ConcessoesSF { get; set; }
    }
}