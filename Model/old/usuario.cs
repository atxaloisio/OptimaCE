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
    
    public partial class Usuario
    {
        public long Id { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string password { get; set; }
        public Nullable<long> Id_perfil { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
        public string inativo { get; set; }
    
        public virtual Perfil perfil { get; set; }
    }
}