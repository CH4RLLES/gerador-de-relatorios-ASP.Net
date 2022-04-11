using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaCatalogoConexaoServico
    {
        public TblSistemaCatalogoConexaoServico()
        {
            TblSistemaCatalogoConexao = new HashSet<TblSistemaCatalogoConexao>();
        }

        public int CodigoSistemaCatalogoConexaoServico { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaCatalogoConexao> TblSistemaCatalogoConexao { get; set; }
    }
}
