using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseMunicipio
    {
        public TblBaseMunicipio()
        {
            TblBrlegalEmpresa = new HashSet<TblBrlegalEmpresa>();
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
            TblSistemaInstituicao = new HashSet<TblSistemaInstituicao>();
        }

        public int CodigoBaseMunicipio { get; set; }
        public int CodigoBaseUf { get; set; }
        public string Nome { get; set; }
        public int? Populacao { get; set; }
        public bool? IndicadorCapital { get; set; }

        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual ICollection<TblBrlegalEmpresa> TblBrlegalEmpresa { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
        public virtual ICollection<TblSistemaInstituicao> TblSistemaInstituicao { get; set; }
    }
}
