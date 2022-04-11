using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoMotivoInvalidacao
    {
        public TblInfracaoPreAutuacaoMotivoInvalidacao()
        {
            TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoAnaliseNavigation = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisaoNavigation = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoConferenciaDuplaCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
            TblInfracaoPreAutuacaoConferenciaDuplaCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
        }

        public int CodigoInfracaoPreAutuacaoMotivoInvalidacao { get; set; }
        public int CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? CodigoProtocolo { get; set; }
        public bool? IndicadorResponsabilidadeContratato { get; set; }
        public int? CodigoProtocoloVersao2018 { get; set; }
        public bool? IndicadorResponsabilidadeContratatoVersao2018 { get; set; }

        public virtual TblInfracaoPreAutuacaoMotivoInvalidacaoGrupo CodigoInfracaoPreAutuacaoMotivoInvalidacaoGrupoNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoAnaliseNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaRevisaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacaoCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDuplaCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaDoisNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDuplaCodigoInfracaoPreAutuacaoMotivoInvalidacaoConferenciaUmNavigation { get; set; }
    }
}
