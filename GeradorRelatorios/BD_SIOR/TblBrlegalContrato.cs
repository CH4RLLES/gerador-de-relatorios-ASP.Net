using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalContrato
    {
        public TblBrlegalContrato()
        {
            TblBrlegalAnteprojeto = new HashSet<TblBrlegalAnteprojeto>();
            TblBrlegalContratoTrecho = new HashSet<TblBrlegalContratoTrecho>();
            TblBrlegalContratoTrechoContratado = new HashSet<TblBrlegalContratoTrechoContratado>();
            TblBrlegalDocumento = new HashSet<TblBrlegalDocumento>();
            TblBrlegalImplantacaoPlanejamento = new HashSet<TblBrlegalImplantacaoPlanejamento>();
            TblBrlegalProjetoBasicoEntrega = new HashSet<TblBrlegalProjetoBasicoEntrega>();
            TblBrlegalProjetoExecutivoEntrega = new HashSet<TblBrlegalProjetoExecutivoEntrega>();
            TblSistemaUsuarioBrlegalContrato = new HashSet<TblSistemaUsuarioBrlegalContrato>();
        }

        public int CodigoBrlegalContrato { get; set; }
        public int CodigoBrlegalEdital { get; set; }
        public int CodigoBrlegalEmpresa { get; set; }
        public int? CodigoBrlegalEngenheiroResponsavel { get; set; }
        public int CodigoBaseUf { get; set; }
        public string NumeroContrato { get; set; }
        public int NumeroLote { get; set; }
        public decimal? ExtensaoMalhaContratada { get; set; }
        public decimal? ValorInicial { get; set; }
        public DateTime? DataOrdemInicioServicos { get; set; }
        public DateTime? DataLimiteEntregaProjetoBasico { get; set; }
        public DateTime? DataLimiteEntregaProjetoExecutivo { get; set; }
        public DateTime? NovaDataEntregaProjetoBasico { get; set; }
        public DateTime? NovaDataEntregaProjetoExecutivo { get; set; }
        public bool? ProjetoBasicoFinalizado { get; set; }
        public bool? ProjetoExecutivoFinalizado { get; set; }
        public decimal? ValorInicialAditivo { get; set; }
        public string OficioProjetoBasicoNome { get; set; }
        public string OficioProjetoBasicoNomeFisico { get; set; }
        public int? OficioProjetoBasicoTamanho { get; set; }
        public string OficioProjetoExecutivoNome { get; set; }
        public string OficioProjetoExecutivoNomeFisico { get; set; }
        public int? OficioProjetoExecutivoTamanho { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? ValorInicialAditivoReajuste { get; set; }
        public DateTime? DataBaseCalculo { get; set; }

        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblBrlegalEdital CodigoBrlegalEditalNavigation { get; set; }
        public virtual TblBrlegalEmpresa CodigoBrlegalEmpresaNavigation { get; set; }
        public virtual TblBrlegalEngenheiroResponsavel CodigoBrlegalEngenheiroResponsavelNavigation { get; set; }
        public virtual ICollection<TblBrlegalAnteprojeto> TblBrlegalAnteprojeto { get; set; }
        public virtual ICollection<TblBrlegalContratoTrecho> TblBrlegalContratoTrecho { get; set; }
        public virtual ICollection<TblBrlegalContratoTrechoContratado> TblBrlegalContratoTrechoContratado { get; set; }
        public virtual ICollection<TblBrlegalDocumento> TblBrlegalDocumento { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoPlanejamento> TblBrlegalImplantacaoPlanejamento { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntrega> TblBrlegalProjetoBasicoEntrega { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntrega> TblBrlegalProjetoExecutivoEntrega { get; set; }
        public virtual ICollection<TblSistemaUsuarioBrlegalContrato> TblSistemaUsuarioBrlegalContrato { get; set; }
    }
}
