﻿using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoNotificacaoTipo
    {
        public TblInfracaoNotificacaoTipo()
        {
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
            TblInfracaoNotificacaoEditalNotificacao = new HashSet<TblInfracaoNotificacaoEditalNotificacao>();
            TblInfracaoSolicitacaoCancelamentoInfracao = new HashSet<TblInfracaoSolicitacaoCancelamentoInfracao>();
        }

        public int CodigoInfracaoNotificacaoTipo { get; set; }
        public int CodigoInfracaoNotificacaoTipoGrupo { get; set; }
        public string Nome { get; set; }

        public virtual TblInfracaoNotificacaoTipoGrupo CodigoInfracaoNotificacaoTipoGrupoNavigation { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoEditalNotificacao> TblInfracaoNotificacaoEditalNotificacao { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoCancelamentoInfracao> TblInfracaoSolicitacaoCancelamentoInfracao { get; set; }
    }
}
