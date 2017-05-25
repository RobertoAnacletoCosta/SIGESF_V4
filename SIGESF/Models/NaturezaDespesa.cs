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
        [Key, ForeignKey("ItemDeConcessao")]
        public int NaturezaDespesaId { get; set; }
        public string CodigoDespesa { get; set; }
        public string Descricao { get; set; }
        public virtual ItemDeConcessao ItemDeConcessao { get; set; }
        //public virtual ICollection<ItemDeConcessao> ItensSF { get; set; }
    }
}