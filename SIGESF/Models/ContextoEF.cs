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
        public ContextoEF() : base("name=StrConnection")
        {

        }
        public DbSet<AgenteSuprido> AgentesSupridos { get; set; }
        public DbSet<ConcessaoSuprimentoFundos> ConcessoesSF { get; set; }
        public DbSet<DetalheConcessaoAplicacaoSF> DetalhesSF { get; set; }
        public DbSet<NaturezaDespesa> NaturezasDespesas { get; set; }
        //public DbSet<SolicitacaoSuprimentoFundos> SolicitacoesSF { get; set; }
        //public DbSet<DetalheSolicitacaoSuprimentoFundos> DetalheSolicitacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<SIGESF.Models.SolicitacaoSuprimentoFundos> SolicitacaoSuprimentoFundos { get; set; }

        public System.Data.Entity.DbSet<SIGESF.Models.DetalheSolicitacaoSuprimentoFundos> DetalheSolicitacaoSuprimentoFundos { get; set; }
    }
}
