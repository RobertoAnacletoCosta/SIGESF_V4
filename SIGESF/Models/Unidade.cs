using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIGESF.Models
{
    public enum Unidade
    {
        [Display(Name = "Coordenadoria de Comunicação Social")]
        Coordenadoria_Comunicaçâo_Social=0,
        [Display(Name ="Coordenadoria de Desenvolimento de Sistemas")]
        Coordenadoria_Desenvolvimento_Sistemas=1,
        [Display(Name = "Coordenadoria de Engenharia e Manutenção")]
        Coordenadoria_Engenharia_Manutenção=2,
        [Display(Name = "Coordenadoria de Patrimonio e Transportes")]
        Coordenadoria_Patrimonio_Transportes=3,
        [Display(Name = "Coordenadoria de Saúde e Qualidade de Vida")]
        Coordenadoria_Saúde_Qualidade_Vida=4,
        [Display(Name = "Coordenadoria de Infraestrutura e Comunicação")]
        Coordenadoria_Infraestrutura_Comunicação=5,
        [Display(Name = "Escola Judicial")]
        Escola_Judicial=6,
        [Display(Name = "VT de Água Boa")]
        VT_Água_Boa=7,
        [Display(Name = "VT de Alto Araguaia")]
        VT_Alto_Araguaia=8,
        [Display(Name = "VT de Alta Floresta")]
        VT_Alta_Floresta=9,
        [Display(Name = "VT de Barra do Garças")]
        VT_Barra_do_Garças=10,
        [Display(Name = "VT de Cáceres")]
        VT_Cáceres=11,
        [Display(Name = "VT de Campo Novo do Parecis")]
        VT_Campo_Novo_do_Parecis=12,
        [Display(Name = "VT de Colider")]
        VT_Colider=13,
        [Display(Name = "VT de Confresa")]
        VT_Confresa=14,
        [Display(Name = "VT de Diamantino")]
        VT_Diamantino=15,
        [Display(Name = "VT de Jaciara")]
        VT_Jaciara=16,
        [Display(Name = "VT de Juara")]
        VT_Juara=17,
        [Display(Name = "VT de Juína")]
        VT_Juína=18,
        [Display(Name = "VT de Lucas do Rio Verde")]
        VT_Lucas_do_Rio_Verde=19,
        [Display(Name = "VT de Mirassol D'Oeste")]
        VT_Mirassol_D_Oeste=20,
        [Display(Name = "VT de Nova Mutum")]
        VT_Nova_Mutum=21,
        [Display(Name = "VT de Peixoto de Azevedo")]
        VT_Peixoto_de_Azevedo=22,
        [Display(Name = "VT de Pontes  e Lacerda")]
        VT_Pontes_e_Lacerda=23,
        [Display(Name = "VT de Primavera do Leste")]
        VT_Primavera_do_Leste=24,
        [Display(Name = "VT de Rondonópolis")]
        VT_Rondonópolis=25,
        [Display(Name = "VT de Sapezal")]
        VT_Sapezal=26,
        [Display(Name = "VT de Sinop")]
        VT_Sinop=27,
        [Display(Name = "VT de Sorriso")]
        VT_Sorriso=28,
        [Display(Name = "VT de Tangará da Serra")]
        VT_Tangará_da_Serra=29,
        [Display(Name = "VT de Várzea Grande")]
        VT_Várzea_Grande=30,
    }
}