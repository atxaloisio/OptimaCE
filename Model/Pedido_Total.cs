//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido_Total
    {
        public long Id { get; set; }
        public long Id_pedido { get; set; }
        public Nullable<decimal> base_calculo_icms { get; set; }
        public Nullable<decimal> base_calculo_st { get; set; }
        public Nullable<decimal> valor_pis { get; set; }
        public Nullable<decimal> valor_cofins { get; set; }
        public Nullable<decimal> valor_csll { get; set; }
        public Nullable<decimal> valor_icms { get; set; }
        public Nullable<decimal> valor_st { get; set; }
        public Nullable<decimal> valor_inss { get; set; }
        public Nullable<decimal> valor_IPI { get; set; }
        public Nullable<decimal> valor_ir { get; set; }
        public Nullable<decimal> valor_iss { get; set; }
        public Nullable<decimal> valor_deducoes { get; set; }
        public Nullable<decimal> valor_descontos { get; set; }
        public Nullable<decimal> valor_mercadorias { get; set; }
        public Nullable<decimal> valor_total_pedido { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    
        public virtual Pedido pedido { get; set; }
    }
}
