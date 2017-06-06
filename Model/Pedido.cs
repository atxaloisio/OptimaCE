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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.itempedidoes = new HashSet<ItemPedido>();
            this.pedido_observacoes = new HashSet<Pedido_Observacoes>();
            this.pedido_frete = new HashSet<Pedido_Frete>();
            this.pedido_parcelas = new HashSet<Pedido_Parcelas>();
            this.pedido_total = new HashSet<Pedido_Total>();
            this.pedido_otica = new HashSet<Pedido_Otica>();
            this.pedido_infoadic = new HashSet<Pedido_InfoAdic>();
        }
    
        public long id { get; set; }
        public long codigo_pedido { get; set; }
        public string codigo_pedido_integracao { get; set; }
        public string numero_pedido { get; set; }
        public long Id_cliente { get; set; }
        public int codigo_cliente { get; set; }
        public string codigo_cliente_integracao { get; set; }
        public string data_previsao { get; set; }
        public Nullable<int> quantidade_itens { get; set; }
        public string etapa { get; set; }
        public string codigo_parcela { get; set; }
        public Nullable<int> qtde_parcelas { get; set; }
        public string bloqueado { get; set; }
        public string importado_api { get; set; }
        public Nullable<int> codigo_empresa { get; set; }
        public string codigo_empresa_integracao { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido> itempedidoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Observacoes> pedido_observacoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Frete> pedido_frete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Parcelas> pedido_parcelas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Total> pedido_total { get; set; }
        public virtual Cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Otica> pedido_otica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_InfoAdic> pedido_infoadic { get; set; }
    }
}