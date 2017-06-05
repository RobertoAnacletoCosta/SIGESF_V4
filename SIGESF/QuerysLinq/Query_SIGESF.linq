<Query Kind="Program" />

public class AgenteSuprido
    {
        public int AgenteSupridoId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string CPF { get; set; }
    }
	
public class ConcessaoSuprimentoFundos
    {
        public int ConcessaoSuprimentoFundosId { get; set; }
	    public string Proc_Proad { get; set; }
		public DateTime? DataConcessao { get; set; }
        public string SF_Apropriacao { get; set; }
        public int PrazoAplicacao { get; set; }
        public DateTime? DataFinalAplicacao { get; set; }
		public DateTime? PrazoPrestContas { get; set; }
		public Boolean PrestadoContas { get; set; }
        public DateTime? DataPrestContas { get; set; }
        public string Finalidade { get; set; }
        public int AgenteSupridoId { get; set; }
    }
	
public class DetalheConcessaoAplicacaoSF
    {
        public int DetConcAplicId { get; set; }
        public int ConcessaoSuprimentoFundosId { get; set; }
        public int NaturezaDespesaId { get; set; }
        public decimal ValorConcedido { get; set; }
        public decimal ValorAplicado { get; set; }
        public decimal DevolucaoSaque { get; set; }
        public decimal ValorNaoUtilizado { get; set; }
    }
	
public class NaturezaDespesa
    {
        public int NaturezaDespesaId { get; set; }
        //Na descrição: Ex.: 339030 - Material de consumo
        public string Descricao { get; set; }
    }
	
public enum Unidade
    {
        Coordenadoria_Comunicaçâo_Social=0,
        Coordenadoria_Desenvolvimento_Sistemas=1,
        Coordenadoria_Engenharia_Manutenção=2,
        Coordenadoria_Patrimonio_Transportes=3,
        Coordenadoria_Saúde_Qualidade_Vida=4,
        Coordenadoria_Infraestrutura_Comunicação=5,
        Escola_Judicial=6,
        VT_Água_Boa=7,
        VT_Alto_Araguaia=8,
        VT_Alta_Floresta=9,
        VT_Barra_do_Garças=10,
        VT_Cáceres=11,
        VT_Campo_Novo_do_Parecis=12,
        VT_Colider=13,
        VT_Confresa=14,
        VT_Diamantino=15,
        VT_Jaciara=16,
        VT_Juara=17,
        VT_Juína=18,
        VT_Lucas_do_Rio_Verde=19,
        VT_Mirassol_D_Oeste=20,
        VT_Nova_Mutum=21,
        VT_Peixoto_de_Azevedo=22,
        VT_Pontes_e_Lacerda=23,
        VT_Primavera_do_Leste=24,
        VT_Rondonópolis=25,
        VT_Sapezal=26,
        VT_Sinop=27,
        VT_Sorriso=28,
        VT_Tangará_da_Serra=29,
        VT_Várzea_Grande=30,
    }
	
void Main()
{
	List<AgenteSuprido> agentesSupridos = new List<AgenteSuprido>
    {
        new AgenteSuprido { AgenteSupridoId=1,Nome="Maurosandro Silva",Matricula="308.23.001",CPF="222.222.222-22" },
        new AgenteSuprido { AgenteSupridoId=2,Nome="Zelito Correia",Matricula="308.23.002",CPF="111.111.111-11" },
        new AgenteSuprido { AgenteSupridoId=3,Nome="Mauro Tavares",Matricula="308.23.003",CPF="333.333.333-33" },
        new AgenteSuprido { AgenteSupridoId=4,Nome="Roberto Costa",Matricula="308.23.004",CPF="444.444.444-44" },
        new AgenteSuprido { AgenteSupridoId=5,Nome="Jonatas Silveira",Matricula="308.23.005",CPF="555.555.555-55" }
    };

    List<ConcessaoSuprimentoFundos> concessoesSuprimentosFundos = new List<ConcessaoSuprimentoFundos>
	 {
	new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=1,Proc_Proad="0155", DataConcessao=DateTime.Parse("01/05/2017")
	 	,SF_Apropriacao = "0555",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("05/05/2017")
		,PrazoPrestContas=DateTime.Parse("10/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("15/05/2017")
		,Finalidade=("Aquisiçã de diversos materiais de consumo"),AgenteSupridoId=1},
	new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=2,Proc_Proad="0157", DataConcessao=DateTime.Parse("02/05/2017")
	 	,SF_Apropriacao = "0666",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("07/05/2017")
		,PrazoPrestContas=DateTime.Parse("12/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("17/05/2017")
		,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=2},
	new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=3,Proc_Proad="0159", DataConcessao=DateTime.Parse("04/05/2017")
	 	,SF_Apropriacao = "0777",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("09/05/2017")
		,PrazoPrestContas=DateTime.Parse("14/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("19/05/2017")
		,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=3},
	new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=4,Proc_Proad="0161", DataConcessao=DateTime.Parse("06/05/2017")
	 	,SF_Apropriacao = "0888",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("11/05/2017")
		,PrazoPrestContas=DateTime.Parse("16/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("21/05/2017")
		,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=3},
	new ConcessaoSuprimentoFundos { ConcessaoSuprimentoFundosId=5,Proc_Proad="0163", DataConcessao=DateTime.Parse("08/05/2017")
	 	,SF_Apropriacao = "0999",PrazoAplicacao=30,DataFinalAplicacao=DateTime.Parse("13/05/2017")
		,PrazoPrestContas=DateTime.Parse("18/05/2017"),PrestadoContas=false,DataPrestContas=DateTime.Parse("23/05/2017")
		,Finalidade=("Aquisiçã de diversos materiais"),AgenteSupridoId=3}
	 };
	
	List<DetalheConcessaoAplicacaoSF> detalhesConcessoesAplicacoesSF = new List<DetalheConcessaoAplicacaoSF>
	{
	new DetalheConcessaoAplicacaoSF { DetConcAplicId=1,ConcessaoSuprimentoFundosId=1,NaturezaDespesaId=1
		,ValorConcedido=Decimal.Parse("100,00"),ValorAplicado=Decimal.Parse("110,00")
		,DevolucaoSaque=Decimal.Parse("120,00"),ValorNaoUtilizado=Decimal.Parse("130,00")},
	new DetalheConcessaoAplicacaoSF { DetConcAplicId=2,ConcessaoSuprimentoFundosId=2,NaturezaDespesaId=2
		,ValorConcedido=Decimal.Parse("200,00"),ValorAplicado=Decimal.Parse("210,00")
		,DevolucaoSaque=Decimal.Parse("220,00"),ValorNaoUtilizado=Decimal.Parse("230,00")},
	new DetalheConcessaoAplicacaoSF { DetConcAplicId=3,ConcessaoSuprimentoFundosId=3,NaturezaDespesaId=3
		,ValorConcedido=Decimal.Parse("300,00"),ValorAplicado=Decimal.Parse("310,00")
		,DevolucaoSaque=Decimal.Parse("320,00"),ValorNaoUtilizado=Decimal.Parse("330,00") },
	new DetalheConcessaoAplicacaoSF { DetConcAplicId=4,ConcessaoSuprimentoFundosId=4,NaturezaDespesaId=4
		,ValorConcedido=Decimal.Parse("400,00"),ValorAplicado=Decimal.Parse("410,00")
		,DevolucaoSaque=Decimal.Parse("420,00"),ValorNaoUtilizado=Decimal.Parse("430,00") },
	new DetalheConcessaoAplicacaoSF { DetConcAplicId=5,ConcessaoSuprimentoFundosId=5,NaturezaDespesaId=5
		,ValorConcedido=Decimal.Parse("500,00"),ValorAplicado=Decimal.Parse("510,00")
		,DevolucaoSaque=Decimal.Parse("520,00"),ValorNaoUtilizado=Decimal.Parse("530,00") }
	};

	List<NaturezaDespesa> naturezaDespesas = new List<NaturezaDespesa>
	{
        new NaturezaDespesa { NaturezaDespesaId=1,Descricao="339030-Material de Consumo" },
        new NaturezaDespesa { NaturezaDespesaId=2,Descricao="339036-Outros Serviços de Terceiros Pessoa Física" },
        new NaturezaDespesa { NaturezaDespesaId=3,Descricao="339039-Outros Serviços de Terceiros Pessoa Jurídica" },
        new NaturezaDespesa { NaturezaDespesaId=4,Descricao="449052-Equipamentos e Material Permanente" },
        new NaturezaDespesa { NaturezaDespesaId=5,Descricao="339157-Despesas Tributárias e Contributivas" }
     };
	 
	 
	 var ConsultaGeralConcessao = (
	 
	 			from c in concessoesSuprimentosFundos
	 			join a in agentesSupridos
				on c.AgenteSupridoId equals a.AgenteSupridoId
				join d in detalhesConcessoesAplicacoesSF
				on c.ConcessaoSuprimentoFundosId equals d.ConcessaoSuprimentoFundosId
				join nd in naturezaDespesas
				on d.NaturezaDespesaId equals nd.NaturezaDespesaId
				
				
				select new {
				
					Nome = a.Nome
					,Matricula = a.Matricula
					,PROAD = c.Proc_Proad
					,NumSFApropriacao = c.SF_Apropriacao
					,NaturezaDesesa = nd.Descricao
					,ValorConcedido = d.ValorConcedido
					,ValorAplicado = d.ValorAplicado
					,DevolucaoSaque = d.DevolucaoSaque
					,ValorNaoUtilizado = d.ValorNaoUtilizado
					
				}
				).ToList();
				
	ConsultaGeralConcessao.Dump();
}