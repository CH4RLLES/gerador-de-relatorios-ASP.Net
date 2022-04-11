using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorRelatorios.DTO
{
    public class RetornoPNVC
    {
        public long Id { get; set; }
        public string Data { get; set; }
        public string Horario { get; set; }
        public string CodigoEquipamentoDnit { get; set; }
        public string LocalSentidoRodovia { get; set; }
        public string Classe { get; set; }
        public string Velocidade { get; set; }
    }

    public class RetornoProcessosSIOR
    {
        public string Data { get; set; }
        public string FICI { get; set; }
        public string DA { get; set; }
        public string SA { get; set; }
        public string Recurso1estancia { get; set; }
        public string Recurso2estancia { get; set; }
    }

    public class RetornoCompletoEngenharia
    {
        public string Contrato { get; set; }
        public string EquipamentoAfericaoCodigoDnit { get; set; }
        public string DataHoraInfracao { get; set; }
        public string DataCadastro { get; set; }
        public string DataConferencia2 { get; set; }
        public string DataRevisão { get; set; }
        public string DataPreparação { get; set; }
        public string LocalInfracaoKm { get; set; }
        public string LocalInfracaoRodovia { get; set; }
        public string MedicaoRealizada { get; set; }
        public string LimiteRegulamentado { get; set; }
        public string ValorConsiderado { get; set; }
        public string VeiculoPlacaFinal { get; set; }
        public string ConferenciaUmPlacaVeiculo { get; set; }
        public string ConferenciaDoisPlacaVeiculo { get; set; }
        public string ConferenciaRevisaoPlacaVeiculo { get; set; }
        public string DescricaoInfracaoResumo { get; set; }
        public string MotivoInvalidaçãoFinal { get; set; }
        public string FaixaSentidoVia { get; set; }
        public string TipoEquipamento { get; set; }
        public string MarcaModeloEquipamento { get; set; }
        public string UF { get; set; }
        public string Municipio { get; set; }
        public string OnlineOffline { get; set; }
    }

    public class RetornoImgsValidasInvalidas
    {
        public string Data { get; set; }
        public string Validos { get; set; }
        public string Invalidos { get; set; }
    }

    public class RetornoResumoEquipamentos
    {
        public string CodigoEquipamentoDnit { get; set; }
        public string EditalLoteOperadora { get; set; }
        public string SNV { get; set; }
        public string UF { get; set; }
        public string BR { get; set; }
        public string KM { get; set; }
        public string Municipio { get; set; }
        public string TipoEquipamento { get; set; }
        public string NoFaixas { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string InicioOperacao { get; set; }
        public string Faixas { get; set; }
        public string Situacao { get; set; }
        public string ValocidadeRegulamentada { get; set; }
        public string CodigoEstudoTecnico { get; set; }
        public string CodigoEstudoViabilidade { get; set; }
        public List<Paralisacoes> Paralisacoes { get; set; }
    }

    public class Paralisacoes
    {
        public string CodigoEquipamentoDnit { get; set; }
        public string Faixa { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
    }

    public class RetornoNomeCNPJ
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
    }

    public class RetornoRecursosJari
    {
        public string NumeroAIT { get; set; }
        public string NumeroProcesso { get; set; }
        public string CpfCnpjRecorrente { get; set; }
        public string DataProtocolo { get; set; }
        public string JARI { get; set; }
        public string UF { get; set; }
        public string Instancia { get; set; }
        public string MesAnoProtocolo { get; set; }
        public string QuantidadedeArquivos { get; set; }
        public string FaseRecurso { get; set; }
        public string SituacaoRecurso { get; set; }
        public string PrevisaoPrescricao { get; set; }
    }

    public class RetornoExcessoPeso
    {
        public string NumeroAIT { get; set; }
        public string DataInfracao { get; set; }
        public string RodoviaKmLocalInfracao { get; set; }
        public string Municipio { get; set; }
        public string Enquadramento { get; set; }
        public string PlacaVeiculo { get; set; }
        public string RENAVAM { get; set; }
        public string MarcaModelo { get; set; }
        public string ValorPrincipal { get; set; }
        public string ValorPago { get; set; }
        public string SituacaoDebito { get; set; }
        public string Infrator { get; set; }
        public string Proprietario { get; set; }
        public string Embarcador { get; set; }
        public string Transportador { get; set; }
        public string LimiteRegulamentarPBT { get; set; }
        public string LimiteRegulamentarComToleranciaPBT { get; set; }
        public string ToleranciaPBT { get; set; }
        public string MedicaoRealizadaPBT { get; set; }
        public string ExcessoAferidoPBT { get; set; }

        public string LimiteRegulamentarEixo1 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo1 { get; set; }
        public string ToleranciaEixo1 { get; set; }
        public string MedicaoRealizadaEixo1 { get; set; }
        public string ExcessoAferidoEixo1 { get; set; }

        public string LimiteRegulamentarEixo2 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo2 { get; set; }
        public string ToleranciaEixo2 { get; set; }
        public string MedicaoRealizadaEixo2 { get; set; }
        public string ExcessoAferidoEixo2 { get; set; }

        public string LimiteRegulamentarEixo3 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo3 { get; set; }
        public string ToleranciaEixo3 { get; set; }
        public string MedicaoRealizadaEixo3 { get; set; }
        public string ExcessoAferidoEixo3 { get; set; }

        public string LimiteRegulamentarEixo4 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo4 { get; set; }
        public string ToleranciaEixo4 { get; set; }
        public string MedicaoRealizadaEixo4 { get; set; }
        public string ExcessoAferidoEixo4 { get; set; }

        public string LimiteRegulamentarEixo5 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo5 { get; set; }
        public string ToleranciaEixo5 { get; set; }
        public string MedicaoRealizadaEixo5 { get; set; }
        public string ExcessoAferidoEixo5 { get; set; }

        public string LimiteRegulamentarEixo6 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo6 { get; set; }
        public string ToleranciaEixo6 { get; set; }
        public string MedicaoRealizadaEixo6 { get; set; }
        public string ExcessoAferidoEixo6 { get; set; }

        public string LimiteRegulamentarEixo7 { get; set; }
        public string LimiteRegulamentarComToleranciaEixo7 { get; set; }
        public string ToleranciaEixo7 { get; set; }
        public string MedicaoRealizadaEixo7 { get; set; }
        public string ExcessoAferidoEixo7 { get; set; }

        //public string LimiteRegulamentarEixo8 { get; set; }
        //public string LimiteRegulamentarComToleranciaEixo8 { get; set; }
        //public string ToleranciaEixo8 { get; set; }
        //public string MedicaoRealizadaEixo8 { get; set; }
        //public string ExcessoAferidoEixo8 { get; set; }

        //public string LimiteRegulamentarEixo9 { get; set; }
        //public string LimiteRegulamentarComToleranciaEixo9 { get; set; }
        //public string ToleranciaEixo9 { get; set; }
        //public string MedicaoRealizadaEixo9 { get; set; }
        //public string ExcessoAferidoEixo9 { get; set; }

        public string LimiteRegulamentarCMT { get; set; }
        public string LimiteRegulamentarComToleranciaCMT { get; set; }
        public string ToleranciaCMT { get; set; }
        public string MedicaoRealizadaCMT { get; set; }
        public string ExcessoAferidoCMT { get; set; }
        public string NotasFiscais { get; set; }
    }

    public class RetornoJulgamentosJari
    {
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string JARI { get; set; }
        public string Fase { get; set; }
        public string QuantidadeJulgados { get; set; }
    }

    public class RetornoDadosInfracao
    {
        public string Auto { get; set; }
        public string CpfCnpj { get; set; }
        public string Enquadramento { get; set; }
    }
}
