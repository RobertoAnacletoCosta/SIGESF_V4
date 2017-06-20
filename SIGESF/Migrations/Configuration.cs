namespace SIGESF.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SIGESF.Models.ContextoEF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SIGESF.Models.ContextoEF context)
        {
            context.AgentesSupridos.AddOrUpdate(s => s.Nome,
            new AgenteSuprido { AgenteSupridoId=1,Nome="Maurosandro Silva",Matricula="308.23.0001",CPF="222.222.222-22" },
            new AgenteSuprido { AgenteSupridoId=2,Nome="Zelito Correia",Matricula="308.23.0002",CPF="111.111.111-11" },
            new AgenteSuprido { AgenteSupridoId=3,Nome="Mauro Tavares",Matricula="308.23.0003",CPF="333.333.333-33" },
            new AgenteSuprido { AgenteSupridoId=4,Nome="Roberto Costa",Matricula="308.23.0004",CPF="444.444.444-44" },
            new AgenteSuprido { AgenteSupridoId=5,Nome="Jonatas Silveira",Matricula="308.23.0005",CPF="555.555.555-55" },
            new AgenteSuprido { AgenteSupridoId=6,Nome="Abel Lemes", Matricula = "308.23.0006", CPF = "666.666.666-66" },
            new AgenteSuprido { AgenteSupridoId=7,Nome="Barnabé Silva", Matricula = "308.23.0007", CPF = "777.777.777-77" },
            new AgenteSuprido { AgenteSupridoId=8,Nome="Getulio Freire", Matricula = "308.23.0008", CPF = "888.888.888-88" },
            new AgenteSuprido { AgenteSupridoId=9,Nome="Hélio Ribeiro", Matricula = "308.23.0009", CPF = "999.999.999-99" },
            new AgenteSuprido { AgenteSupridoId=10,Nome="Ivan Fortes", Matricula = "308.23.0010", CPF = "555.555.555-55" }
            );

            context.NaturezasDespesas.AddOrUpdate(n => n.Descricao,
            new NaturezaDespesa { Descricao = "339030 - Material de Consumo" },
            new NaturezaDespesa { Descricao = "339036 - Outros Serviços de Terceiros Pessoa Física" },
            new NaturezaDespesa { Descricao = "339039 - Outros Serviços de Terceiros Pessoa Jurídica" },
            new NaturezaDespesa { Descricao = "449052 - Equipamentos e Material Permanente" },
            new NaturezaDespesa { Descricao = "339157 - Despesas Tributárias e Contributivas" }
            );

        }
    }
}
