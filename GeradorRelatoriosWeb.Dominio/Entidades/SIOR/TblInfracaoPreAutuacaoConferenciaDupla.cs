using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoPreAutuacaoConferenciaDupla
    {
        public long CodigoInfracaoPreAutuacaoConferenciaDupla { get; set; }
        public long CodigoInfracaoPreAutuacao { get; set; }
        public int? CodigoUfjurisdicaoVeiculo { get; set; }
        public int? CodigoRenavammunicipioEmplacamentoVeiculo { get; set; }
        public int? CodigoRenavammarcaModeloVeiculo { get; set; }
        public int? CodigoRenavamtipoVeiculo { get; set; }
        public int? CodigoRenavamveiculoEspecie { get; set; }
        public int? CodigoRenavamveiculoCarroceria { get; set; }
        public int? CodigoRenavamveiculoCategoria { get; set; }
        public int? CodigoRenavamveiculoCor { get; set; }
        public int? CodigoSistemaUsuarioConferenciaUm { get; set; }
        public int? CodigoSistemaUsuarioConferenciaDois { get; set; }
        public int? CodigoSistemaUsuarioConferenciaRevisao { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUm { get; set; }
        public int? CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDois { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public string PlacaVeiculo { get; set; }
        public string ImagemPrincipalArquivoNomeFisico { get; set; }
        public bool? ConferenciaUmIndicadorRegistroValido { get; set; }
        public string ConferenciaUmPlacaVeiculo { get; set; }
        public DateTime? ConferenciaUmData { get; set; }
        public bool? ConferenciaDoisIndicadorRegistroValido { get; set; }
        public string ConferenciaDoisPlacaVeiculo { get; set; }
        public DateTime? ConferenciaDoisData { get; set; }
        public DateTime? ConferenciaDataEmProcessamento { get; set; }
        public int? CodigoInfracaoEquipamentoAfericaoTipo { get; set; }
        public int? ConferenciaUmCodigoUfjurisdicaoVeiculo { get; set; }
        public int? ConferenciaUmCodigoRenavammunicipioEmplacamentoVeiculo { get; set; }
        public int? ConferenciaUmCodigoRenavammarcaModeloVeiculo { get; set; }
        public int? ConferenciaUmCodigoRenavamtipoVeiculo { get; set; }
        public int? ConferenciaUmCodigoRenavamveiculoEspecie { get; set; }
        public int? ConferenciaUmCodigoRenavamveiculoCarroceria { get; set; }
        public int? ConferenciaUmCodigoRenavamveiculoCategoria { get; set; }
        public int? ConferenciaUmCodigoRenavamveiculoCor { get; set; }
        public decimal MedicaoRealizada { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public byte[] RowVersion { get; set; }
        public string NomeRenavammarcaModeloVeiculo { get; set; }
        public string ConferenciaUmNomeRenavammarcaModeloVeiculo { get; set; }
        public string LocalInfracaoMunicipioUf { get; set; }

        public virtual TblInfracaoEquipamentoAfericaoTipo CodigoInfracaoEquipamentoAfericaoTipoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoMotivoInvalidacao CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation { get; set; }
        public virtual TblInfracaoPreAutuacaoMotivoInvalidacao CodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation { get; set; }
        public virtual TblInfracaoPreAutuacao CodigoInfracaoPreAutuacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioConferenciaDoisNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioConferenciaRevisaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioConferenciaUmNavigation { get; set; }
        public virtual TblBaseUf CodigoUfjurisdicaoVeiculoNavigation { get; set; }
    }
}
