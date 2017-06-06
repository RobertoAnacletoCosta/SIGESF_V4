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
            new AgenteSuprido { AgenteSupridoId=1,Nome="Maurosandro Silva",Matricula="308.23.001",CPF="222.222.222-22" },
            new AgenteSuprido { AgenteSupridoId=2,Nome="Zelito Correia",Matricula="308.23.002",CPF="111.111.111-11" },
            new AgenteSuprido { AgenteSupridoId=3,Nome="Mauro Tavares",Matricula="308.23.003",CPF="333.333.333-33" },
            new AgenteSuprido { AgenteSupridoId=4,Nome="Roberto Costa",Matricula="308.23.004",CPF="444.444.444-44" },
            new AgenteSuprido { AgenteSupridoId=5,Nome="Jonatas Silveira",Matricula="308.23.005",CPF="555.555.555-55" }
            );

            //context.ConcessoesSF.AddOrUpdate(c => c.Proc_Proad,
            //new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=1,Proc_Proad="0155", DataConcessao=DateTime.Parse("01/05/2017")
            //,SF_Apropriacao = "0555",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("05/05/2017")
            //,PrazoPrestContas=DateTime.Parse("10/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("15/05/2017")
            //,Finalidade=("Aquisiçã de diversos materiais de consumo"),AgenteSupridoId=1},
            //new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=2,Proc_Proad="0157", DataConcessao=DateTime.Parse("02/05/2017")
            //,SF_Apropriacao = "0666",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("07/05/2017")
            //,PrazoPrestContas=DateTime.Parse("12/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("17/05/2017")
            //,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=2},
            //new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=3,Proc_Proad="0159", DataConcessao=DateTime.Parse("04/05/2017")
            //,SF_Apropriacao = "0777",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("09/05/2017")
            //,PrazoPrestContas=DateTime.Parse("14/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("19/05/2017")
            //,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=3},
            //new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=4,Proc_Proad="0161", DataConcessao=DateTime.Parse("06/05/2017")
            //,SF_Apropriacao = "0888",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("11/05/2017")
            //,PrazoPrestContas=DateTime.Parse("16/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("21/05/2017")
            //,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=3},
            //new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=5,Proc_Proad="0163", DataConcessao=DateTime.Parse("08/05/2017")
            //,SF_Apropriacao = "0999",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("13/05/2017")
            //,PrazoPrestContas=DateTime.Parse("18/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("23/05/2017")
            //,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=3}
            //);

         //   context.DetalhesSF.AddOrUpdate(d => d.DetConcAplicId,
         //   new DetalheConcessaoAplicacaoSF { DetConcAplicId=1,ConcessaoSuprimentoFundosId=1
         //   ,NaturezaDespesaId=1,ValorConcedido=Decimal.Parse("100,00"),ValorAplicado=Decimal.Parse("110,00")
         //   ,DevolucaoSaque=Decimal.Parse("120,00"),ValorNaoUtilizado = Decimal.Parse("130,00") },
	        //new DetalheConcessaoAplicacaoSF { DetConcAplicId=2,ConcessaoSuprimentoFundosId=2
         //   ,NaturezaDespesaId=2,ValorConcedido=Decimal.Parse("200,00"),ValorAplicado=Decimal.Parse("210,00")
         //   ,DevolucaoSaque=Decimal.Parse("220,00"),ValorNaoUtilizado = Decimal.Parse("230,00") },
	        //new DetalheConcessaoAplicacaoSF { DetConcAplicId=3,ConcessaoSuprimentoFundosId=3
         //   ,NaturezaDespesaId=3,ValorConcedido=Decimal.Parse("300,00"),ValorAplicado = Decimal.Parse("310,00")
         //   ,DevolucaoSaque=Decimal.Parse("320,00"),ValorNaoUtilizado = Decimal.Parse("330,00") },
	        //new DetalheConcessaoAplicacaoSF { DetConcAplicId=4,ConcessaoSuprimentoFundosId=4
         //   ,NaturezaDespesaId=4,ValorConcedido=Decimal.Parse("400,00"),ValorAplicado=Decimal.Parse("410,00")
         //   ,DevolucaoSaque=Decimal.Parse("420,00"),ValorNaoUtilizado = Decimal.Parse("430,00") },
	        //new DetalheConcessaoAplicacaoSF { DetConcAplicId=5,ConcessaoSuprimentoFundosId=5
         //   ,NaturezaDespesaId=5,ValorConcedido=Decimal.Parse("500,00"),ValorAplicado=Decimal.Parse("510,00")
         //   ,DevolucaoSaque=Decimal.Parse("520,00"),ValorNaoUtilizado = Decimal.Parse("530,00") }
         //   );

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
