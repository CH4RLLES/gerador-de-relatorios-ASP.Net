using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoVeiculo
    {
        public TblInfracaoVeiculo()
        {
            TblInfracao = new HashSet<TblInfracao>();
        }

        public long CodigoInfracaoVeiculo { get; set; }
        public int? CodigoRenavammarcaModeloVeiculo { get; set; }
        public int? CodigoUfjurisdicao { get; set; }
        public int? CodigoRenavammunicipioEmplacamento { get; set; }
        public int? CodigoRenavamveiculoCor { get; set; }
        public int? CodigoRenavamtipoVeiculo { get; set; }
        public int? CodigoRenavamveiculoEspecie { get; set; }
        public int? CodigoRenavamveiculoCarroceria { get; set; }
        public int? CodigoRenavamveiculoCategoria { get; set; }
        public string Placa { get; set; }
        public long? NumeroCodigoRenavam { get; set; }
        public int? CodigoRenavamindicadorRestricaoRenavam1 { get; set; }
        public int? CodigoRenavamindicadorRestricaoRenavam2 { get; set; }
        public int? CodigoRenavamindicadorRestricaoRenavam3 { get; set; }
        public int? CodigoRenavamindicadorRestricaoRenavam4 { get; set; }
        public int? CodigoRenavamindicadorRestricaoRenajud { get; set; }
        public int? CodigoRenavamindicadorRouboFurtoRenavam { get; set; }
        public int? CodigoRenavamindicadorRestricaoRenavam { get; set; }
        public int? CodigoRenavampaisVeiculoPlacaEstrangeira { get; set; }
        public int? CodigoInfracaoVeiculoTipo { get; set; }

        public virtual TblInfracaoVeiculoTipo CodigoInfracaoVeiculoTipoNavigation { get; set; }
        public virtual TblBaseUf CodigoUfjurisdicaoNavigation { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
    }
}
