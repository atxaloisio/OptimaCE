﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Model;
    
    public partial class CEEntities : DbContext
    {
        public CEEntities()
            : base("name=CEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caixa> Caixas { get; set; }
        public virtual DbSet<Categoria> Categorias1 { get; set; }
        public virtual DbSet<Cidade> Cidades1 { get; set; }
        public virtual DbSet<Cliente> Clientes1 { get; set; }
        public virtual DbSet<Cliente_Parcela> Cliente_Parcela1 { get; set; }
        public virtual DbSet<Cliente_Tag> Cliente_Tag1 { get; set; }
        public virtual DbSet<Cliente_Transportadora> Cliente_Transportadora1 { get; set; }
        public virtual DbSet<Cliente_Vendedor> Cliente_Vendedor1 { get; set; }
        public virtual DbSet<CNAE> CNAEs1 { get; set; }
        public virtual DbSet<Conta_Corrente> Conta_Corrente1 { get; set; }
        public virtual DbSet<Empresa> Empresas1 { get; set; }
        public virtual DbSet<Familia_Produto> Familia_Produto1 { get; set; }
        public virtual DbSet<FormasPagVenda> FormasPagVendas1 { get; set; }
        public virtual DbSet<Funcao> Funcaos1 { get; set; }
        public virtual DbSet<Funcao_Perfil> Funcao_Perfil1 { get; set; }
        public virtual DbSet<ItemPedido> ItemPedidoes1 { get; set; }
        public virtual DbSet<ItemPedido_Imposto> ItemPedido_Imposto1 { get; set; }
        public virtual DbSet<ItemPedido_InfoAdic> ItemPedido_InfoAdic1 { get; set; }
        public virtual DbSet<ItemPedido_Otica> ItemPedido_Otica { get; set; }
        public virtual DbSet<ItemPedido_Produto> ItemPedido_Produto1 { get; set; }
        public virtual DbSet<Motivo_Entrega> Motivo_Entrega1 { get; set; }
        public virtual DbSet<Movimento> Movimentoes1 { get; set; }
        public virtual DbSet<Pais> Pais1 { get; set; }
        public virtual DbSet<Parcela> Parcelas1 { get; set; }
        public virtual DbSet<Pedido> Pedidoes1 { get; set; }
        public virtual DbSet<Pedido_Armacao> Pedido_Armacao1 { get; set; }
        public virtual DbSet<Pedido_Frete> Pedido_Frete1 { get; set; }
        public virtual DbSet<Pedido_InfoAdic> Pedido_InfoAdic1 { get; set; }
        public virtual DbSet<Pedido_Lente> Pedido_Lente1 { get; set; }
        public virtual DbSet<Pedido_Observacoes> Pedido_Observacoes1 { get; set; }
        public virtual DbSet<Pedido_Otica> Pedido_Otica1 { get; set; }
        public virtual DbSet<Pedido_Otica_InfoAdic> Pedido_Otica_InfoAdic1 { get; set; }
        public virtual DbSet<Pedido_Otica_Parcelas> Pedido_Otica_Parcelas1 { get; set; }
        public virtual DbSet<Pedido_Parcelas> Pedido_Parcelas1 { get; set; }
        public virtual DbSet<Pedido_Total> Pedido_Total1 { get; set; }
        public virtual DbSet<Perfil> Perfils1 { get; set; }
        public virtual DbSet<Produto> Produtoes1 { get; set; }
        public virtual DbSet<Produto_Ibpt> Produto_Ibpt1 { get; set; }
        public virtual DbSet<Produto_Imposto> Produto_Imposto1 { get; set; }
        public virtual DbSet<Rota> Rotas1 { get; set; }
        public virtual DbSet<Tag> Tags1 { get; set; }
        public virtual DbSet<Tipo_Armacao> Tipo_Armacao1 { get; set; }
        public virtual DbSet<Tipo_Lente> Tipo_Lente1 { get; set; }
        public virtual DbSet<Unidade> Unidades1 { get; set; }
        public virtual DbSet<Usuario> Usuarios1 { get; set; }
        public virtual DbSet<Vendedor> Vendedors1 { get; set; }
        public virtual DbSet<Vendedor_Localidade> Vendedor_Localidade1 { get; set; }
        public virtual DbSet<Contas_Pagar> Contas_Pagar1 { get; set; }
        public virtual DbSet<Filial> Filials1 { get; set; }
        public virtual DbSet<Item_Livro_Caixa> Item_Livro_Caixa1 { get; set; }
        public virtual DbSet<Livro_Caixa> Livro_Caixa1 { get; set; }
    }
}
