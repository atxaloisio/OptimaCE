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
    
    public partial class Vendedor_Localidade
    {
        public long Id { get; set; }
        public long Id_vendedor { get; set; }
        public long Id_localidade { get; set; }
    
        public virtual Cidade cidade { get; set; }
        public virtual Vendedor vendedor { get; set; }
    }
}
