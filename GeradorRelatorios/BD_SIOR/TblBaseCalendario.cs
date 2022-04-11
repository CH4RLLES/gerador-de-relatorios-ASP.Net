using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseCalendario
    {
        public int CodigoBaseCalendario { get; set; }
        public DateTime Data { get; set; }
        public bool? IndicadorDiaSemana { get; set; }
        public bool IndicadorFeriado { get; set; }
        public short? Ano { get; set; }
        public byte? Mes { get; set; }
        public byte? Semana { get; set; }
        public byte? Dia { get; set; }
        public byte? DiaSemana { get; set; }
        public short? DiaJuliano { get; set; }
        public string NomeMes { get; set; }
        public string SiglaMes { get; set; }
        public string NomeDiaSemana { get; set; }
        public string SiglaDiaSemana { get; set; }
        public string Observacao { get; set; }
    }
}
