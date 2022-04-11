using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaSsrs
    {
        public TblSistemaSsrs()
        {
            TblSistemaSsrsrelatorio = new HashSet<TblSistemaSsrsrelatorio>();
        }

        public int CodigoSistemaSsrs { get; set; }
        public string ServidorEndereco { get; set; }
        public string ServidorUsuarioNome { get; set; }
        public string ServidorUsuarioSenha { get; set; }
        public string ServidorUsuarioDominio { get; set; }

        public virtual ICollection<TblSistemaSsrsrelatorio> TblSistemaSsrsrelatorio { get; set; }
    }
}
