using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoLavratura
    {
        public long CodigoInfracaoPreAutuacaoLavratura { get; set; }
        public int CodigoInfracaoOrigem { get; set; }
        public long? CodigoInfracaoOrigemContratacao { get; set; }
        public long? CodigoInfracaoOrigemContrato { get; set; }
        public long? CodigoInfracaoOrigemRemessaDados { get; set; }
        public long CodigoInfracaoOrigemRegistro { get; set; }
        public string NumeroAgenteTransito { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public DateTime DataInfracao { get; set; }
        public int CodigoUflocalInfracao { get; set; }
        public int CodigoRodoviaLocalInfracao { get; set; }
        public int CodigoRenavammunicipioLocalInfracao { get; set; }
        public string LocalInfracaoRodovia { get; set; }
        public decimal LocalInfracaoKm { get; set; }
        public string LocalInfracaoRodoviaFaixa { get; set; }
        public string LocalInfracaoOcorrencia { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int CodigoInfracaoDesdobramento { get; set; }
        public string CodigoInfracaoCtb { get; set; }
        public int CodigoInfracaoIndicadorResponsavel { get; set; }
        public int CodigoInfracaoGravidade { get; set; }
        public byte PontosCnh { get; set; }
        public int? CodigoInfracaoEquipamentoAfericaoTipo { get; set; }
        public string EquipamentoAfericaoCodigoDnit { get; set; }
        public string EquipamentoAfericaoMarca { get; set; }
        public string EquipamentoAfericaoModelo { get; set; }
        public DateTime EquipamentoAfericaoInmetroVerificacaoData { get; set; }
        public int CodigoRenavamunidadeMedida { get; set; }
        public decimal LimiteRegulamentado { get; set; }
        public decimal MedicaoRealizada { get; set; }
        public decimal ValorConsiderado { get; set; }
        public string VeiculoPlaca { get; set; }
        public int? CodigoRenavampaisVeiculoPlacaEstrangeira { get; set; }
        public int? CodigoUfjurisdicaoVeiculo { get; set; }
        public int? CodigoRenavammunicipioEmplacamentoVeiculo { get; set; }
        public int? CodigoRenavammarcaModeloVeiculo { get; set; }
        public int? CodigoRenavamtipoVeiculo { get; set; }
        public int? CodigoRenavamveiculoCor { get; set; }
        public int? CodigoRenavamveiculoEspecie { get; set; }
        public int? CodigoRenavamveiculoCarroceria { get; set; }
        public int? CodigoRenavamveiculoCategoria { get; set; }
        public int? CodigoInfracaoVeiculoTipo { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorOriginal80Porcento { get; set; }
        public decimal ValorOriginal60Porcento { get; set; }
        public string ImagemPrincipalArquivoNome { get; set; }
        public string ImagemPrincipalArquivoNomeFisico { get; set; }
        public int ImagemPrincipalArquivoTamanho { get; set; }
        public int ImagemPrincipalSequencia { get; set; }
        public bool IndicadorProcessamentoNumero { get; set; }
        public string NumeroAutoPrefixo { get; set; }
        public string NumeroAuto { get; set; }
        public string Nupformatado { get; set; }
        public DateTime? NupdataCadastro { get; set; }
    }
}
