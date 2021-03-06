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
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.itempedido_produto = new HashSet<ItemPedido_Produto>();
            this.produto_ibpt = new HashSet<Produto_Ibpt>();
            this.itempedido_otica = new HashSet<ItemPedido_Otica>();
            this.movimentacoes = new HashSet<Movimento>();
        }
    
        public long id { get; set; }
        public string codigo_produto_integracao { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string ean { get; set; }
        public string ncm { get; set; }
        public Nullable<decimal> quantidade_estoque { get; set; }
        public string csosn_icms { get; set; }
        public string unidade { get; set; }
        public Nullable<decimal> valor_unitario { get; set; }
        public string cst_icms { get; set; }
        public Nullable<decimal> aliquota_icms { get; set; }
        public Nullable<decimal> red_base_icms { get; set; }
        public Nullable<decimal> aliquota_ibpt { get; set; }
        public string tipoItem { get; set; }
        public string cst_pis { get; set; }
        public Nullable<decimal> aliquota_pis { get; set; }
        public string cst_cofins { get; set; }
        public Nullable<decimal> aliquota_cofins { get; set; }
        public string bloqueado { get; set; }
        public string importado_api { get; set; }
        public Nullable<int> codigo_familia { get; set; }
        public string codInt_familia { get; set; }
        public string descricao_familia { get; set; }
        public string inativo { get; set; }
        public Nullable<int> id_dadosIbpt { get; set; }
        public string cest { get; set; }
        public string cfop { get; set; }
        public Nullable<decimal> peso_liq { get; set; }
        public Nullable<decimal> peso_bruto { get; set; }
        public Nullable<decimal> estoque_minimo { get; set; }
        public string descr_detalhada { get; set; }
        public string obs_internas { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
        public int codigo_produto { get; set; }
        public string sincronizar { get; set; }
        public Nullable<long> id_familia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido_Produto> itempedido_produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto_Ibpt> produto_ibpt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido_Otica> itempedido_otica { get; set; }
        public virtual Familia_Produto familia_produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movimento> movimentacoes { get; set; }
    }
}
