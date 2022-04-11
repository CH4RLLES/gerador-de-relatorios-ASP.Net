using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class AuxRemessaDadosRepetida
    {
        public long CodigoRemessaDados { get; set; }
        public int CodigoRemessaDadosTipo { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public int CodigoPncvequipamentoFaixa { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataProcessamento { get; set; }
        public string Identificador { get; set; }
        public string CodigoEquipamentoDnit { get; set; }
        public DateTime ColetaDadosData { get; set; }
        public string LocalSentidoRodovia { get; set; }
        public string LocalTipoVia { get; set; }
        public byte LocalNumeroFaixa { get; set; }
        public string ArquivoDadosNome { get; set; }
        public DateTime ArquivoDadosDataCriacao { get; set; }
        public int QuantidadeRegistros { get; set; }
        public int QuantidadeRegistrosTesteEquipamento { get; set; }
        public int? AnaliseOrdemProcessamento { get; set; }
        public bool? AnaliseIndicadorRepetida { get; set; }
    }
}
