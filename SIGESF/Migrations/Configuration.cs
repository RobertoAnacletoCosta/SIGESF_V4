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
            new AgenteSuprido { Nome = "Maurosandro Silva", Matricula = "308.23.001", CPF = "222.222.222-22" },
            new AgenteSuprido { Nome = "Zelito Correia", Matricula = "308.23.002", CPF = "111.111.111-11" },
            new AgenteSuprido { Nome = "Mauro Tavares", Matricula = "308.23.003", CPF = "333.333.333-33" },
            new AgenteSuprido { Nome = "Roberto Costa", Matricula = "308.23.004", CPF = "444.444.444-44" },
            new AgenteSuprido { Nome = "Jonatas Silveira", Matricula = "308.23.005", CPF = "555.555.555-55" },
            new AgenteSuprido { Nome = "Rodrigo Alvares", Matricula = "308.23.006", CPF = "666.666.666-66" },
            new AgenteSuprido { Nome = "Sebastião Souza", Matricula = "308.23.007", CPF = "777.777.777-77" },
            new AgenteSuprido { Nome = "Bernardo Moraes", Matricula = "308.23.008", CPF = "888.888.888-88" },
            new AgenteSuprido { Nome = "Diogo Ferreira", Matricula = "308.23.009", CPF = "222.111.111-11" },
            new AgenteSuprido { Nome = "Fernando Conrinthians", Matricula = "308.23.010", CPF = "321.111.111-11" },
            new AgenteSuprido { Nome = "Gilson Fogo", Matricula = "308.23.011", CPF = "232.111.111-11" },
            new AgenteSuprido { Nome = "Selma Vieira", Matricula = "308.23.012", CPF = "555.111.111-11" },
            new AgenteSuprido { Nome = "Gleice Rizzi", Matricula = "308.23.013", CPF = "543.111.111-11" },
            new AgenteSuprido { Nome = "Cleiton Moreira", Matricula = "308.23.014", CPF = "556.111.111-11" },
            new AgenteSuprido { Nome = "Maria Sandra", Matricula = "308.23.015", CPF = "777.111.111-11" },
            new AgenteSuprido { Nome = "Vitória Regina", Matricula = "308.23.016", CPF = "777.111.112-22" },
            new AgenteSuprido { Nome = "Darciana Rapidinha", Matricula = "308.23.017", CPF = "777.111.113-33" },
            new AgenteSuprido { Nome = "Marco Barros", Matricula = "308.23.018", CPF = "777.111.114-44" },
            new AgenteSuprido { Nome = "Pedro Henrique", Matricula = "308.23.019", CPF = "777.111.115-55" },
            new AgenteSuprido { Nome = "João Parreira", Matricula = "308.23.020", CPF = "777.111.116-66" },
            new AgenteSuprido { Nome = "Thiago Costa", Matricula = "308.23.021", CPF = "777.111.117-77" },
            new AgenteSuprido { Nome = "Leila Costa", Matricula = "308.23.022", CPF = "777.111.118-88" },
            new AgenteSuprido { Nome = "Marcio Vieira", Matricula = "308.23.023", CPF = "777.111.119-99" },
            new AgenteSuprido { Nome = "Alisson Barroso", Matricula = "308.23.024", CPF = "987.111.119-99" },
            new AgenteSuprido { Nome = "Evandro Leitão", Matricula = "308.23.025", CPF = "987.654.321-76" }
            );

            context.NaturezaDespesa.AddOrUpdate(n => n.Descricao,
            new NaturezaDespesa { Descricao = "339030 - Material de Consumo" },
            new NaturezaDespesa { Descricao = "339036 - Outros Serviços de Terceiros Pessoa Física" },
            new NaturezaDespesa { Descricao = "339039 - Outros Serviços de Terceiros Pessoa Jurídica" },
            new NaturezaDespesa { Descricao = "449052 - Equipamentos e Material Permanente" },
            new NaturezaDespesa { Descricao = "339157 - Despesas Tributárias e Contributivas" }
            );
        }
    }
}
