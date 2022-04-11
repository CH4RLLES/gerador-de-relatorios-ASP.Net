using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SINPEV
{
    public partial class TblDadosSinpev
    {
        public string NumeroAit { get; set; }
        public string CodigoPpv { get; set; }
        public int? NumRemessaSgpv { get; set; }
        public string ClassificacaoVeiculo { get; set; }
        public string PesoDeclaradoVeiculo { get; set; }
        public string NumeroAetveiculo { get; set; }
        public string AnoFabricacaoVeiculo { get; set; }
        public string AnoModeloVeiculo { get; set; }
        public string TaraVeiculo { get; set; }
        public string ChassiVeiculo { get; set; }
        public string MunicipioOrigemCarga { get; set; }
        public string MunicipioDestinoCarga { get; set; }
        public string VersaoSgpv { get; set; }
        public string CargaTransportada { get; set; }
        public string TipoCargaTransportada { get; set; }
        public string NotasFiscais { get; set; }
    }
}
