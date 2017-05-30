using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class NaturezaDespesa
    {
        [Key]
        public int NaturezaDespesaId { get; set; }

        //Na descrição: Ex.: 339030 - Material de consumo
        public string Descricao { get; set; }

        public virtual ICollection<DetalheConcessaoAplicacaoSF> DetalhesSF { get; set; }
    }
}