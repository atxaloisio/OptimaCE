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
    
    public partial class ItemPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemPedido()
        {
            this.itempedido_imposto = new HashSet<ItemPedido_Imposto>();
            this.itempedido_infoadic = new HashSet<ItemPedido_InfoAdic>();
            this.itempedido_produto = new HashSet<ItemPedido_Produto>();
        }
    
        public long id { get; set; }
        public long id_pedido { get; set; }
        public Nullable<int> ordem { get; set; }
        public string codigo_item_integracao { get; set; }
        public Nullable<int> codigo_item { get; set; }
        public string simples_nacional { get; set; }
        public Nullable<int> regra_impostos { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido_Imposto> itempedido_imposto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido_InfoAdic> itempedido_infoadic { get; set; }
        public virtual Pedido pedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemPedido_Produto> itempedido_produto { get; set; }
    }
}
