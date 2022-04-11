using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoEvento
    {
        public int CodigoPncvequipamentoEvento { get; set; }
        public int CodigoPncvequipamento { get; set; }
        public DateTime Data { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
    }
}
