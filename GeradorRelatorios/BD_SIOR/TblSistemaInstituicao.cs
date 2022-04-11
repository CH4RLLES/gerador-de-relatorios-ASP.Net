using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaInstituicao
    {
        public TblSistemaInstituicao()
        {
            TblSistemaUsuario = new HashSet<TblSistemaUsuario>();
        }

        public int CodigoSistemaInstituicao { get; set; }
        public int CodigoSistemaInstituicaoTipo { get; set; }
        public int? CodigoBaseMunicipio { get; set; }
        public string Nome { get; set; }
        public string NomeEmpresaLiderConsorcio { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }

        public virtual TblBaseMunicipio CodigoBaseMunicipioNavigation { get; set; }
        public virtual TblSistemaInstituicaoTipo CodigoSistemaInstituicaoTipoNavigation { get; set; }
        public virtual ICollection<TblSistemaUsuario> TblSistemaUsuario { get; set; }
    }
}
