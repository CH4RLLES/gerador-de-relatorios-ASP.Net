﻿using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalContratoTrecho
    {
        public TblBrlegalContratoTrecho()
        {
            TblBrlegalContratoTrechoRemovido = new HashSet<TblBrlegalContratoTrechoRemovido>();
            TblBrlegalContratoTrechoSuspenso = new HashSet<TblBrlegalContratoTrechoSuspenso>();
            TblBrlegalImplantacaoTrechoCronograma = new HashSet<TblBrlegalImplantacaoTrechoCronograma>();
        }

        public int CodigoBrlegalContratoTrecho { get; set; }
        public int CodigoBrlegalContrato { get; set; }
        public int CodigoSnvtrecho { get; set; }
        public decimal KmInicial { get; set; }
        public decimal KmFinal { get; set; }
        public decimal Extensao { get; set; }
        public string Observacao { get; set; }
        public bool IndicadorTrechoAlterado { get; set; }
        public bool? Mp082 { get; set; }
        public int? AnoSnv { get; set; }

        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual TblSnvtrecho CodigoSnvtrechoNavigation { get; set; }
        public virtual ICollection<TblBrlegalContratoTrechoRemovido> TblBrlegalContratoTrechoRemovido { get; set; }
        public virtual ICollection<TblBrlegalContratoTrechoSuspenso> TblBrlegalContratoTrechoSuspenso { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoTrechoCronograma> TblBrlegalImplantacaoTrechoCronograma { get; set; }
    }
}
