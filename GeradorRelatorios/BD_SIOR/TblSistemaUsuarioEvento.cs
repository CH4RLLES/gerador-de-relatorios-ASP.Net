using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaUsuarioEvento
    {
        public int CodigoSistemaUsuarioEvento { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
