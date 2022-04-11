using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoResumoEquipamentosLista
    {
        [Display(Name = "Código do Equipamento DNIT")]
        public string CodigoEquipamentoDnit { get; set; }
        public string UF { get; set; }
        public string BR { get; set; }
        [Display(Name = "Município")]
        public string Municipio { get; set; }
        [Display(Name = "Tipo de Equipamento")]
        public string TipoEquipamento { get; set; }
        [Display(Name = "Inicio da Operação")]
        public string InicioOperacao { get; set; }
        [Display(Name = "Edital Lote da Operadora")]
        public string EditalLoteOperadora { get; set; }


    }
}
