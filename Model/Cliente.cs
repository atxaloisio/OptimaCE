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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.cliente_tag = new HashSet<Cliente_Tag>();
            this.pedidoes = new HashSet<Pedido>();
            this.cliente_parcela = new HashSet<Cliente_Parcela>();
            this.pedido_otica = new HashSet<Pedido_Otica>();
            this.rotas = new HashSet<Rota>();
            this.cliente_transportadora = new HashSet<Cliente_Transportadora>();
            this.cliente_transportadora1 = new HashSet<Cliente_Transportadora>();
            this.cliente_vendedor = new HashSet<Cliente_Vendedor>();
            this.pedido_otica1 = new HashSet<Pedido_Otica>();
        }
    
        public long Id { get; set; }
        public long codigo_cliente_omie { get; set; }
        public string codigo_cliente_integracao { get; set; }
        public string cnpj_cpf { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string logradouro { get; set; }
        public string endereco { get; set; }
        public string endereco_numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string codigo_pais { get; set; }
        public string contato { get; set; }
        public Nullable<System.DateTime> nascimento { get; set; }
        public string telefone1_ddd { get; set; }
        public string telefone1_numero { get; set; }
        public string telefone2_ddd { get; set; }
        public string telefone2_numero { get; set; }
        public string fax_ddd { get; set; }
        public string fax_numero { get; set; }
        public string email { get; set; }
        public string homepage { get; set; }
        public string observacao { get; set; }
        public string inscricao_municipal { get; set; }
        public string inscricao_estadual { get; set; }
        public string inscricao_suframa { get; set; }
        public string pessoa_fisica { get; set; }
        public string optante_simples_nacional { get; set; }
        public string bloqueado { get; set; }
        public string importado_api { get; set; }
        public string cnae { get; set; }
        public string obsEndereco { get; set; }
        public string obsTelefonesEmail { get; set; }
        public Nullable<System.DateTime> inclusao { get; set; }
        public string usuario_inclusao { get; set; }
        public Nullable<System.DateTime> alteracao { get; set; }
        public string usuario_alteracao { get; set; }
        public string sincronizar { get; set; }
        public Nullable<long> Id_empresa { get; set; }
        public Nullable<long> Id_filial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Tag> cliente_tag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> pedidoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Parcela> cliente_parcela { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Otica> pedido_otica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rota> rotas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Transportadora> cliente_transportadora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Transportadora> cliente_transportadora1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Vendedor> cliente_vendedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido_Otica> pedido_otica1 { get; set; }
    }
}
