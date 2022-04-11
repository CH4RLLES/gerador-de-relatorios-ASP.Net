using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaEvento
    {
        public long CodigoSistemaEvento { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int? CodigoSistemaAcao { get; set; }
        public int CodigoSistemaEventoTipo { get; set; }
        public string Login { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public DateTime Data { get; set; }
        public string NumeroIp { get; set; }
        public string NomeComputador { get; set; }
        public long? CodigoRegistroOrigem { get; set; }
        public string CaminhoFuncionalidadeAcao { get; set; }
        public string Detalhes { get; set; }

        public virtual TblSistemaEventoTipo CodigoSistemaEventoTipoNavigation { get; set; }
    }
}
