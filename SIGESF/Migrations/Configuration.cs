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
            context.AgentesSupridos.AddOrUpdate(a => a.Nome,
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

            //context.SolicitacoesSF.AddOrUpdate(s => s.SolicitacaoSuprimentoFundosId,
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 1, Proc_Proad = "000.111/2017"
            //, DataSolicitacaoSF = DateTime.Parse("01/05/2017"), Finalidade = "Manutenção da Unidade." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 2, Proc_Proad = "000.222/2017"
            //, DataSolicitacaoSF = DateTime.Parse("02/05/2017"), Finalidade = "Pagamento de materiais e serviços." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 3, Proc_Proad = "000.333/2017"
            //, DataSolicitacaoSF = DateTime.Parse("03/05/2017"), Finalidade = "Manutenção da Unidade." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 4, Proc_Proad = "000.444/2017"
            //, DataSolicitacaoSF = DateTime.Parse("04/05/2017"), Finalidade = "Pagamento de materiais e serviços." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 5, Proc_Proad = "000.555/2017"
            //, DataSolicitacaoSF = DateTime.Parse("05/05/2017"), Finalidade = "Manutenção da Unidade." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 6, Proc_Proad = "000.666/2017"
            //, DataSolicitacaoSF = DateTime.Parse("06/05/2017"), Finalidade = "Pagamento de materiais e serviços." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 7, Proc_Proad = "000.777/2017"
            //, DataSolicitacaoSF = DateTime.Parse("07/05/2017"), Finalidade = "Manutenção da Unidade." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 8, Proc_Proad = "000.888/2017"
            //, DataSolicitacaoSF = DateTime.Parse("08/05/2017"), Finalidade = "Pagamento de materiais e serviços." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 9, Proc_Proad = "000.999/2017"
            //, DataSolicitacaoSF = DateTime.Parse("09/05/2017"), Finalidade = "Manutenção da Unidade." },
            //new SolicitacaoSuprimentoFundos { AgenteSupridoId = 10, Proc_Proad = "001.010/2017"
            //, DataSolicitacaoSF = DateTime.Parse("10/05/2017"), Finalidade = "Pagamento de materiais e serviços." }
            //);

            //context.DetalheSolicitacoes.AddOrUpdate(ds => ds.DetalheSolicitacaoId,
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 1, NaturezaDespesaId = 1, ValorSolicitado = 100 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 1, NaturezaDespesaId = 2, ValorSolicitado = 150 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 2, NaturezaDespesaId = 1, ValorSolicitado = 200 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 2, NaturezaDespesaId = 3, ValorSolicitado = 250 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 2, NaturezaDespesaId = 4, ValorSolicitado = 300 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 3, NaturezaDespesaId = 1, ValorSolicitado = 250 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 3, NaturezaDespesaId = 3, ValorSolicitado = 450 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 4, NaturezaDespesaId = 3, ValorSolicitado = 350 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 4, NaturezaDespesaId = 4, ValorSolicitado = 500 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 5, NaturezaDespesaId = 2, ValorSolicitado = 380 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 5, NaturezaDespesaId = 3, ValorSolicitado = 280 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 5, NaturezaDespesaId = 5, ValorSolicitado = 100 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 6, NaturezaDespesaId = 1, ValorSolicitado = 150 },
            //new DetalheSolicitacaoSuprimentoFundos { SolicitacaoSuprimentoFundosId = 6, NaturezaDespesaId = 4, ValorSolicitado = 360 }
            //);

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
