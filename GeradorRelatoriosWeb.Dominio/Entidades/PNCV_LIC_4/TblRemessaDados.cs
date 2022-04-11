using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class TblRemessaDados
    {
        public TblRemessaDados()
        {
            TblRegistroContagem = new HashSet<TblRegistroContagem>();
            TblRegistroInfracao = new HashSet<TblRegistroInfracao>();
            TblRegistroTesteEquipamento = new HashSet<TblRegistroTesteEquipamento>();
            TblRemessaDadosErro = new HashSet<TblRemessaDadosErro>();
            TblRemessaDadosEvento = new HashSet<TblRemessaDadosEvento>();
        }

        public long CodigoRemessaDados { get; set; }
        public int CodigoRemessaDadosTipo { get; set; }
        public int CodigoRemessaDadosSituacao { get; set; }
        public int CodigoRemessaDadosSituacaoArquivoRetorno { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public int? CodigoPncvequipamentoFaixa { get; set; }
        public int? CodigoPncvequipamentoEstudoTecnicoFaixa { get; set; }
        public int? CodigoInfracaoEquipamentoAfericaoTipo { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataProcessamento { get; set; }
        public string Identificador { get; set; }
        public string CodigoEquipamentoDnit { get; set; }
        public DateTime? ColetaDadosData { get; set; }
        public string LocalRodovia { get; set; }
        public decimal? LocalKm { get; set; }
        public string LocalSentidoRodovia { get; set; }
        public string LocalTipoVia { get; set; }
        public byte? LocalNumeroFaixa { get; set; }
        public int QuantidadeRegistros { get; set; }
        public int QuantidadeRegistrosTesteEquipamento { get; set; }
        public int QuantidadeErros { get; set; }
        public bool MedicaoContratoIndicadorApuracao { get; set; }
        public string ArquivoDadosNome { get; set; }
        public int ArquivoDadosTamanho { get; set; }
        public DateTime ArquivoDadosDataCriacao { get; set; }
        public bool ArquivoDadosIndicadorRemovidoOrigem { get; set; }
        public string ArquivoRetornoNome { get; set; }
        public string ArquivoRetornoConteudo { get; set; }
        public DateTime? ArquivoRetornoDataEnvio { get; set; }
        public int? CodigoUf { get; set; }
        public int? CodigoRodovia { get; set; }
        public int? CodigoRenavammunicipio { get; set; }
        public string EquipamentoAfericaoMarca { get; set; }
        public string EquipamentoAfericaoModelo { get; set; }
        public DateTime? EquipamentoAfericaoInmetroVerificacaoData { get; set; }
        public bool RegistroInfracaoPreAutuacaoIndicadorProcessamento { get; set; }
        public bool? ExportacaoContagemIndicadorProcessado { get; set; }

        public virtual TblRemessaDadosSituacaoArquivoRetorno CodigoRemessaDadosSituacaoArquivoRetornoNavigation { get; set; }
        public virtual TblRemessaDadosSituacao CodigoRemessaDadosSituacaoNavigation { get; set; }
        public virtual TblRemessaDadosTipo CodigoRemessaDadosTipoNavigation { get; set; }
        public virtual ICollection<TblRegistroContagem> TblRegistroContagem { get; set; }
        public virtual ICollection<TblRegistroInfracao> TblRegistroInfracao { get; set; }
        public virtual ICollection<TblRegistroTesteEquipamento> TblRegistroTesteEquipamento { get; set; }
        public virtual ICollection<TblRemessaDadosErro> TblRemessaDadosErro { get; set; }
        public virtual ICollection<TblRemessaDadosEvento> TblRemessaDadosEvento { get; set; }
    }
}
