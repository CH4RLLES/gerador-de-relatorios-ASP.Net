using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoPesagem
    {
        public TblInfracaoPesagem()
        {
            TblInfracao = new HashSet<TblInfracao>();
        }

        public long CodigoInfracaoPesagem { get; set; }
        public string DescricaoVeiculo { get; set; }
        public int? MedicaoRealizadaPbt { get; set; }
        public int? MedicaoRealizadaCmt { get; set; }
        public int? MedicaoRealizadaEixo1 { get; set; }
        public int? MedicaoRealizadaEixo2 { get; set; }
        public int? MedicaoRealizadaEixo3 { get; set; }
        public int? MedicaoRealizadaEixo4 { get; set; }
        public int? MedicaoRealizadaEixo5 { get; set; }
        public int? MedicaoRealizadaEixo6 { get; set; }
        public int? MedicaoRealizadaEixo7 { get; set; }
        public int? MedicaoRealizadaEixo8 { get; set; }
        public int? MedicaoRealizadaEixo9 { get; set; }
        public int? LimiteRegulamentarPbt { get; set; }
        public int? LimiteRegulamentarEixo1 { get; set; }
        public int? LimiteRegulamentarEixo2 { get; set; }
        public int? LimiteRegulamentarEixo3 { get; set; }
        public int? LimiteRegulamentarEixo4 { get; set; }
        public int? LimiteRegulamentarEixo5 { get; set; }
        public int? LimiteRegulamentarEixo6 { get; set; }
        public int? LimiteRegulamentarEixo7 { get; set; }
        public int? LimiteRegulamentarEixo8 { get; set; }
        public int? LimiteRegulamentarEixo9 { get; set; }
        public int? LimiteRegulamentarCmt { get; set; }
        public int? ToleranciaPbt { get; set; }
        public int? ToleranciaEixo1 { get; set; }
        public int? ToleranciaEixo2 { get; set; }
        public int? ToleranciaEixo3 { get; set; }
        public int? ToleranciaEixo4 { get; set; }
        public int? ToleranciaEixo5 { get; set; }
        public int? ToleranciaEixo6 { get; set; }
        public int? ToleranciaEixo7 { get; set; }
        public int? ToleranciaEixo8 { get; set; }
        public int? ToleranciaEixo9 { get; set; }
        public int? ToleranciaCmt { get; set; }
        public int? LimiteRegulamentarComToleranciaPbt { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo1 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo2 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo3 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo4 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo5 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo6 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo7 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo8 { get; set; }
        public int? LimiteRegulamentarComToleranciaEixo9 { get; set; }
        public int? LimiteRegulamentarComToleranciaCmt { get; set; }
        public int? ExcessoAferidoPbt { get; set; }
        public int? ExcessoAferidoEixo1 { get; set; }
        public int? ExcessoAferidoEixo2 { get; set; }
        public int? ExcessoAferidoEixo3 { get; set; }
        public int? ExcessoAferidoEixo4 { get; set; }
        public int? ExcessoAferidoEixo5 { get; set; }
        public int? ExcessoAferidoEixo6 { get; set; }
        public int? ExcessoAferidoEixo7 { get; set; }
        public int? ExcessoAferidoEixo8 { get; set; }
        public int? ExcessoAferidoEixo9 { get; set; }
        public int? ExcessoAferidoCmt { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
    }
}
