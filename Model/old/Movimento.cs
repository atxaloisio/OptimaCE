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
    
    public partial class Movimento
    {
        public long Id { get; set; }
        public long id_produto { get; set; }
        public System.DateTime data { get; set; }
        public string tipo { get; set; }
        public decimal quantidade { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal valor_total { get; set; }
        public string observacao { get; set; }
    
        public virtual Produto produto { get; set; }
    }
}
