using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseGruCodigoRecolhimentoTes
    {
        public TblBaseGruCodigoRecolhimentoTes()
        {
            TblInfracaoEnquadramento = new HashSet<TblInfracaoEnquadramento>();
            TblInfracaoFinanceiroDetran = new HashSet<TblInfracaoFinanceiroDetran>();
        }

        public int CodigoBaseGrucodigoRecolhimentoTes { get; set; }
        public string CodigoRecolhimento5D { get; set; }
        public string CodigoRecolhimentoDv { get; set; }
        public string CodigoUnidadeGestora11D { get; set; }
        public string Descricao { get; set; }
        public string CodigoBanco3D { get; set; }
        public string NumeroAgencia5D { get; set; }
        public string NumeroAgenciaDv { get; set; }
        public string NumeroConta12D { get; set; }
        public string NumeroContaDv { get; set; }
        public string NumeroCarteiraGruComRegistro2D { get; set; }
        public string NumeroVariacaoCarteiraGruComRegistro3D { get; set; }
        public string NumeroConvenioGruComRegistro7D { get; set; }
        public string NumeroContratoGruComRegistro { get; set; }
        public string NumeroCarteiraGruSemRegistro2D { get; set; }
        public string NumeroVariacaoCarteiraGruSemRegistro3D { get; set; }
        public string NumeroConvenioGruSemRegistro6D { get; set; }
        public string NumeroContratoGruSemRegistro { get; set; }
        public string NumeroCarteiraGruComercioEletronico2D { get; set; }
        public string NumeroVariacaoCarteiraGruComercioEletronicoRegistro3D { get; set; }
        public string NumeroConvenioGruComercioEletronicoRegistro7D { get; set; }
        public string NumeroContratoGruComercioEletronicoRegistro { get; set; }
        public string NumeroComercioEletronico6D { get; set; }

        public virtual ICollection<TblInfracaoEnquadramento> TblInfracaoEnquadramento { get; set; }
        public virtual ICollection<TblInfracaoFinanceiroDetran> TblInfracaoFinanceiroDetran { get; set; }
    }
}
