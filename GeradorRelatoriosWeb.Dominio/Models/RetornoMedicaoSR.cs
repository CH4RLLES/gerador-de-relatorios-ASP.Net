using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoMedicaoSR
    {
        public string Tipo { get; set; }
        [Display(Name = "Nome do Arquivo")]
        public string NomeDoArquivo { get; set; }
        [Display(Name = "Data da Digitalização")]
        public string DataDigitalizacao { get; set; }
        [Display(Name = "Tamanho do Arquivo")]
        public string TamanhoDoArquivo { get; set; }
        [Display(Name = "Nome do Funcionário")]
        public string NomeDoFuncionario { get; set; }
        [Display(Name = "CPF do Funcionário")]
        public string CpfDoFuncionario { get; set; }
        public string SR { get; set; }
    }
}
