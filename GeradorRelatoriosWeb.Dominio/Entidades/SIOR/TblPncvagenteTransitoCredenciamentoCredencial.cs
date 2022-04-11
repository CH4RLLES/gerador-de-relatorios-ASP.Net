using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvagenteTransitoCredenciamentoCredencial
    {
        public int CodigoPncvagenteTransitoCredenciamentoCredencial { get; set; }
        public int CodigoPncvagenteTransitoCredenciamento { get; set; }
        public int CodigoPncvagenteTransitoIndicadorVinculo { get; set; }
        public int CodigoPncvagenteTransitoIndicadorSexo { get; set; }
        public int CodigoPncvagenteTransitoIndicadorTipoSanguineo { get; set; }
        public int CodigoPncvagenteTransitoIndicadorFatorRh { get; set; }
        public int CodigoBaseUfnaturalidade { get; set; }
        public int CodigoBaseMunicipioNaturalidade { get; set; }
        public string AgenteTransitoNome { get; set; }
        public string AgenteTransitoNumeroIdentificacao { get; set; }
        public string AgenteTransitoNumeroCpf { get; set; }
        public string AgenteTransitoMatriculaSiape { get; set; }
        public string AgenteTransitoNumeroRg { get; set; }
        public string AgenteTransitoNumeroRgorgaoExpedidor { get; set; }
        public string AgenteTransitoFiliacaoMae { get; set; }
        public string AgenteTransitoFiliacaoPai { get; set; }
        public DateTime AgenteTransitoDataNascimento { get; set; }
        public string AgenteTransitoPortariaCredenciamento { get; set; }
        public string AgenteTransitoRestricaoCircunscricao { get; set; }
        public string AgenteTransitoFotoArquivoNome { get; set; }
        public string AgenteTransitoFotoArquivoNomeFisico { get; set; }
        public int AgenteTransitoFotoArquivoTamanho { get; set; }
        public string AutoridadeTransitoNome { get; set; }
        public int AutoridadeTransitoPortariaNumero { get; set; }
        public DateTime AutoridadeTransitoPortariaData { get; set; }
        public DateTime CredencialDataEmissao { get; set; }
        public DateTime? CredencialDataCancelamento { get; set; }
        public string CredencialArquivoNome { get; set; }
        public string CredencialArquivoNomeFisico { get; set; }
        public int? CredencialArquivoTamanho { get; set; }
        public bool CredencialIndicadorAtivo { get; set; }

        public virtual TblBaseMunicipio CodigoBaseMunicipioNaturalidadeNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfnaturalidadeNavigation { get; set; }
        public virtual TblPncvagenteTransitoCredenciamento CodigoPncvagenteTransitoCredenciamentoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorFatorRh CodigoPncvagenteTransitoIndicadorFatorRhNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorSexo CodigoPncvagenteTransitoIndicadorSexoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorTipoSanguineo CodigoPncvagenteTransitoIndicadorTipoSanguineoNavigation { get; set; }
        public virtual TblPncvagenteTransitoIndicadorVinculo CodigoPncvagenteTransitoIndicadorVinculoNavigation { get; set; }
    }
}
