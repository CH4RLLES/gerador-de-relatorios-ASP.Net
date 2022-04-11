using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoEquipamentoAfericaoTipo
    {
        public TblInfracaoEquipamentoAfericaoTipo()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoConferenciaDupla = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
        }

        public int CodigoInfracaoEquipamentoAfericaoTipo { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDupla { get; set; }
    }
}
