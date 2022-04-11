using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoResumoEquipamentos
    {
        [Display(Name = "Código do Equipamento DNIT")]
        public string CodigoEquipamentoDnit { get; set; }
        [Display(Name = "Edital Lote da Operadora")]
        public string EditalLoteOperadora { get; set; }
        public string SNV { get; set; }
        public string UF { get; set; }
        public string BR { get; set; }
        public string KM { get; set; }
        [Display(Name = "Município")]
        public string Municipio { get; set; }
        [Display(Name = "Tipo de Equipamento")]
        public string TipoEquipamento { get; set; }
        [Display(Name = "Número de faixas")]
        public string NoFaixas { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [Display(Name = "Inicio da Operação")]
        public string InicioOperacao { get; set; }
        public string Faixas { get; set; }
        public string Situacao { get; set; }
        [Display(Name = "Velocidade Regulamentada")]
        public string ValocidadeRegulamentada { get; set; }
        [Display(Name = "Código do Estudo Tecnico")]
        public string CodigoEstudoTecnico { get; set; }
        [Display(Name = "Código do Estudo de Viabilidade")]
        public string CodigoEstudoViabilidade { get; set; }
        [Display(Name = "Paralisações")]
        public List<Paralisacoes> Paralisacoes { get; set; }
    }
}
