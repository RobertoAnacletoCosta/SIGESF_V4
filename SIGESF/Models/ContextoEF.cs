using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public class ContextoEF : DbContext
    {
        public ContextoEF() : base("name=DefaultConnection")
        {

        }
        public DbSet<AgenteSuprido> AgentesSupridos { get; set; }
        public DbSet<ConcessaoSuprimentoFundos> Concessoes { get; set; }
        public DbSet<NaturezaDespesa> NaturezasDespesas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<SIGESF.Models.ItemDeConcessao> ItemDeConcessaos { get; set; }
    }
}
