using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoRecursosJari
    {
        [Display(Name = "Número Auto")]
        public string NumeroAIT { get; set; }
        [Display(Name = "Número Processo")]
        public string NumeroProcesso { get; set; }
        [Display(Name = "CPF/CNPJ")]
        public string CpfCnpjRecorrente { get; set; }
        [Display(Name = "Data Protocolo")]
        public string DataProtocolo { get; set; }
        public string JARI { get; set; }
        public string UF { get; set; }
        [Display(Name = "Instância")]
        public string Instancia { get; set; }
        [Display(Name = "Quantidade de Arquivos")]
        public string QuantidadedeArquivos { get; set; }
        [Display(Name = "Fase")]
        public string FaseRecurso { get; set; }
        [Display(Name = "Situação do Recurso")]
        public string SituacaoRecurso { get; set; }
        [Display(Name = "Data de Prescrição")]
        public string PrevisaoPrescricao { get; set; }
    }
}
