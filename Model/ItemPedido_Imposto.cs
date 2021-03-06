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
    
    public partial class ItemPedido_Imposto
    {
        public long Id { get; set; }
        public long Id_itempedido { get; set; }
        public string cod_sit_trib_icms_sn { get; set; }
        public string origem_icms_sn { get; set; }
        public Nullable<decimal> aliq_icms_sn { get; set; }
        public Nullable<decimal> valor_credito_icms_sn { get; set; }
        public Nullable<decimal> base_icms_sn { get; set; }
        public Nullable<decimal> valor_icms_sn { get; set; }
        public string cod_sit_trib_icms { get; set; }
        public string origem_icms { get; set; }
        public string modalidade_icms { get; set; }
        public Nullable<decimal> perc_red_base_icms { get; set; }
        public Nullable<decimal> base_icms { get; set; }
        public Nullable<decimal> aliq_icms { get; set; }
        public Nullable<decimal> valor_icms { get; set; }
        public string cod_sit_trib_icms_st { get; set; }
        public string modalidade_icms_st { get; set; }
        public Nullable<decimal> perc_red_base_icms_st { get; set; }
        public Nullable<decimal> base_icms_st { get; set; }
        public Nullable<decimal> aliq_icms_st { get; set; }
        public Nullable<decimal> margem_icms_st { get; set; }
        public Nullable<decimal> valor_icms_st { get; set; }
        public Nullable<decimal> aliq_icms_opprop { get; set; }
        public string cod_sit_trib_ipi { get; set; }
        public string tipo_calculo_ipi { get; set; }
        public string enquadramento_ipi { get; set; }
        public Nullable<decimal> base_ipi { get; set; }
        public Nullable<decimal> aliq_ipi { get; set; }
        public Nullable<decimal> qtde_unid_trib_ipi { get; set; }
        public Nullable<decimal> valor_unid_trib_ipi { get; set; }
        public Nullable<decimal> valor_ipi { get; set; }
        public string cod_sit_trib_pis { get; set; }
        public string tipo_calculo_pis { get; set; }
        public Nullable<decimal> base_pis { get; set; }
        public Nullable<decimal> aliq_pis { get; set; }
        public Nullable<decimal> qtde_unid_trib_pis { get; set; }
        public Nullable<decimal> valor_unid_trib_pis { get; set; }
        public Nullable<decimal> valor_pis { get; set; }
        public string cod_sit_trib_pis_st { get; set; }
        public string tipo_calculo_pis_st { get; set; }
        public Nullable<decimal> base_pis_st { get; set; }
        public Nullable<decimal> aliq_pis_st { get; set; }
        public Nullable<decimal> qtde_unid_trib_pis_st { get; set; }
        public Nullable<decimal> valor_unid_trib_pis_st { get; set; }
        public Nullable<decimal> margem_pis_st { get; set; }
        public Nullable<decimal> valor_pis_st { get; set; }
        public string cod_sit_trib_cofins { get; set; }
        public string tipo_calculo_cofins { get; set; }
        public Nullable<decimal> base_cofins { get; set; }
        public Nullable<decimal> aliq_cofins { get; set; }
        public Nullable<decimal> qtde_unid_trib_cofins { get; set; }
        public Nullable<decimal> valor_unid_trib_cofins { get; set; }
        public Nullable<decimal> valor_cofins { get; set; }
        public string cod_sit_trib_cofins_st { get; set; }
        public string tipo_calculo_cofins_st { get; set; }
        public Nullable<decimal> base_cofins_st { get; set; }
        public Nullable<decimal> aliq_cofins_st { get; set; }
        public Nullable<decimal> qtde_unid_trib_cofins_st { get; set; }
        public Nullable<decimal> valor_unid_trib_cofins_st { get; set; }
        public Nullable<decimal> margem_cofins_st { get; set; }
        public Nullable<decimal> valor_cofins_st { get; set; }
        public Nullable<decimal> aliq_inss { get; set; }
        public Nullable<decimal> valor_inss { get; set; }
        public Nullable<decimal> aliq_csll { get; set; }
        public Nullable<decimal> valor_csll { get; set; }
        public Nullable<decimal> aliq_irrf { get; set; }
        public Nullable<decimal> valor_irrf { get; set; }
        public Nullable<decimal> base_iss { get; set; }
        public Nullable<decimal> aliq_iss { get; set; }
        public Nullable<decimal> valor_iss { get; set; }
        public string retem_iss { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    
        public virtual ItemPedido itempedido { get; set; }
    }
}
