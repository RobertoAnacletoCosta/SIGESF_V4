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
            new AgenteSuprido { Nome = "Maurosandro Silva", Matricula = "308.23.001", CPF = "22222222222" },
            new AgenteSuprido { Nome = "Zelito Correia", Matricula = "308.23.002", CPF = "11111111111" },
            new AgenteSuprido { Nome = "Mauro Tavares", Matricula = "308.23.003", CPF = "33333333333" },
            new AgenteSuprido { Nome = "Roberto Costa", Matricula = "308.23.004", CPF = "44444444444" },
            new AgenteSuprido { Nome = "Jonatas Silveira", Matricula = "308.23.005", CPF = "55555555555" },
            new AgenteSuprido { Nome = "Rodrigo Alvares", Matricula = "308.23.006", CPF = "66666666666" },
            new AgenteSuprido { Nome = "Sebastião Souza", Matricula = "308.23.007", CPF = "77777777777" },
            new AgenteSuprido { Nome = "Bernardo Moraes", Matricula = "308.23.008", CPF = "88888888888" },
            new AgenteSuprido { Nome = "Diogo Ferreira", Matricula = "308.23.009", CPF = "22211111111" },
            new AgenteSuprido { Nome = "Fernando Conrinthians", Matricula = "308.23.010", CPF = "32111111111" },
            new AgenteSuprido { Nome = "Gilson Fogo", Matricula = "308.23.011", CPF = "23211111111" },
            new AgenteSuprido { Nome = "Selma Vieira", Matricula = "308.23.012", CPF = "55511111111" },
            new AgenteSuprido { Nome = "Gleice Rizzi", Matricula = "308.23.013", CPF = "54311111111" },
            new AgenteSuprido { Nome = "Cleiton Moreira", Matricula = "308.23.014", CPF = "55611111111" },
            new AgenteSuprido { Nome = "Maria Sandra", Matricula = "308.23.015", CPF = "77711111111" },
            new AgenteSuprido { Nome = "Vitória Regina", Matricula = "308.23.016", CPF = "77711111222" },
            new AgenteSuprido { Nome = "Darciana Rapidinha", Matricula = "308.23.017", CPF = "77711111333" },
            new AgenteSuprido { Nome = "Marco Barros", Matricula = "308.23.018", CPF = "77711111444" },
            new AgenteSuprido { Nome = "Pedro Henrique", Matricula = "308.23.019", CPF = "77711111555" },
            new AgenteSuprido { Nome = "João Parreira", Matricula = "308.23.020", CPF = "77711111666" },
            new AgenteSuprido { Nome = "Thiago Costa", Matricula = "308.23.021", CPF = "77711111777" },
            new AgenteSuprido { Nome = "Leila Costa", Matricula = "308.23.022", CPF = "77711111888" },
            new AgenteSuprido { Nome = "Marcio Vieira", Matricula = "308.23.023", CPF = "77711111999" },
            new AgenteSuprido { Nome = "Alisson Barroso", Matricula = "308.23.024", CPF = "98711111999" },
            new AgenteSuprido { Nome = "Evandro Leitão", Matricula = "308.23.025", CPF = "98765432176" }
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
