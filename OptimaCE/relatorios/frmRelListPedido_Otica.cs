using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Utils;
using Model;
using System.Data.SqlServerCe;
using System.Configuration;

namespace prjbase
{
    public partial class frmRelListPedido_Otica : prjbase.frmReportBase
    {
        public long? pedidoDe { get; set; }
        public long? pedidoAte { get; set; }

        public long? clienteDe { get; set; }
        public long? clienteAte { get; set; }

        public DateTime? data_emissaoDe { get; set; }
        public DateTime? data_emissaoAte { get; set; }

        public DateTime? data_fechamentoDe { get; set; }
        public DateTime? data_fechamentoAte { get; set; }

        public long? vendedorDe { get; set; }
        public long? vendedorAte { get; set; }

        public long? transportadoraDe { get; set; }
        public long? transportadoraAte { get; set; }

        public int? caixaDe { get; set; }
        public int? caixaAte { get; set; }

        public string nrpedclienteDe { get; set; }
        public string nrpedclienteAte { get; set; }

        public int? statusDe { get; set; }
        public int? statusAte { get; set; }

        public frmRelListPedido_Otica()
        {
            InitializeComponent();            
        }

        protected override void CarregaRelatorio()
        {

            rvRelatorios.LocalReport.DataSources.Clear();
            rvRelatorios.Reset();
            rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relListPedido_Otica.rdlc";

            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            SqlCeDataAdapter sda = null;

            try
            {
                con.Open();                
                                
                StringBuilder sb = new StringBuilder();

                string consulta = getConsulta();
                string filtro = getFiltro();

                sb.Append(consulta);
                if (!string.IsNullOrEmpty(filtro))
                {
                    sb.Append(" WHERE ");
                    sb.Append(filtro);
                }
                                                                
                sb.Append("order by ");
                sb.Append("  p1.codigo");

                sda = new SqlCeDataAdapter(sb.ToString(), con);

                dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter Empresa_Logo = new dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter();

                DataTable dt = new DataTable();
                DataTable dtl = new DataTable();

                sda.Fill(dt);
                
                dtl = Empresa_Logo.GetData();

                ReportDataSource ds = new ReportDataSource(dt.TableName, dt);
                ReportDataSource ds2 = new ReportDataSource(dtl.TableName, dtl);

                ds.Name = "DataSet1";
                ds2.Name = "DataSet2";
                rvRelatorios.LocalReport.DataSources.Add(ds);
                rvRelatorios.LocalReport.DataSources.Add(ds2);

                //rvRelatorios.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(onSubreportProcessing);

                ReportParameterCollection parametros = new ReportParameterCollection();

                ReportParameter parametro = new ReportParameter();
                parametro.Name = "EndLaboratorio";
                //parametro.Values.Add("LABORATORIO PRECISION - Rua Antonio Rabelo Guimarães, 256 - Centro - Nova Iguaçu/RJ - Fone: (21) 2667-6932");
                parametro.Values.Add("");

                ReportParameter pardQtdRegs = new ReportParameter();
                pardQtdRegs.Name = "QtdRegistros";
                pardQtdRegs.Values.Add(dt.Rows.Count.ToString());

                parametros.Add(parametro);
                parametros.Add(pardQtdRegs);
                rvRelatorios.LocalReport.SetParameters(parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sda.Dispose();
                con.Close();
                con.Dispose();
            }


            //dbintegracaoDataSetTableAdapters.qryListPedido_OticaTableAdapter lstPed = new dbintegracaoDataSetTableAdapters.qryListPedido_OticaTableAdapter();
            


        }

        private string getFiltro()
        {
            StringBuilder filtro = new StringBuilder();

            #region Pedido
            if (pedidoAte != null & pedidoDe == null)
            {
                pedidoDe = pedidoAte;
            }

            if ((pedidoDe != null) & (pedidoAte == null))
            {
                filtro.Append(string.Format(" p1.Id = {0} ",pedidoDe));
            }

            if ((pedidoDe != null) & (pedidoAte != null))
            {
                filtro.Append(string.Format(" p1.Id >= {0} and p1.Id <= {1} ", pedidoDe,pedidoAte));
            }
            #endregion

            #region Cliente
            if (clienteAte != null & clienteDe == null)
            {
                clienteDe = clienteAte;
            }

            if ((clienteDe != null) & (clienteAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" (p1.Id_cliente = {0}) ", clienteDe));
            }

            if ((clienteDe != null) & (clienteAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" (p1.Id_cliente >= {0} and p1.Id_cliente <= {1}) ", clienteDe, clienteAte));
            }
            #endregion

            #region Transportadora
            if (transportadoraAte != null & transportadoraDe == null)
            {
                transportadoraDe = transportadoraAte;
            }

            if ((transportadoraDe != null) & (transportadoraAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.Id_transportadora = {0} ", transportadoraDe));
            }

            if ((transportadoraDe != null) & (transportadoraAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.Id_transportadora >= {0} and p1.Id_transportadora <= {1} ", transportadoraDe, transportadoraAte));
            }
            #endregion

            #region Data Emissão
            if (data_emissaoAte != null & data_emissaoDe == null)
            {
                data_emissaoDe = data_emissaoAte;
            }

            if ((data_emissaoDe != null) & (data_emissaoAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" (p1.data_emissao = CONVERT(datetime,'{0}',103)) ", data_emissaoDe.Value.ToShortDateString()));
            }

            if ((data_emissaoDe != null) & (data_emissaoAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" (p1.data_emissao >= CONVERT(datetime,'{0}',103) and p1.data_emissao <= CONVERT(datetime,'{1}',103)) ", data_emissaoDe.Value.ToShortDateString(), data_emissaoAte.Value.ToShortDateString()));
            }
            #endregion

            #region Data fechamento
            if (data_fechamentoAte != null & data_fechamentoDe == null)
            {
                data_fechamentoDe = data_fechamentoAte;
            }

            if ((data_fechamentoDe != null) & (data_fechamentoAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" (p1.data_fechamento = CONVERT(datetime,'{0}',103)) ", data_fechamentoDe.Value.ToShortDateString()));
            }

            if ((data_fechamentoDe != null) & (data_fechamentoAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" (p1.data_fechamento >= CONVERT(datetime,'{0}',103) and p1.data_fechamento <= CONVERT(datetime,'{1}',103)) ", data_fechamentoDe.Value.ToShortDateString(), data_fechamentoAte.Value.ToShortDateString()));
            }
            #endregion

            #region Vendedor
            if (vendedorAte != null & vendedorDe == null)
            {
                vendedorDe = vendedorAte;
            }

            if ((vendedorDe != null) & (vendedorAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.Id_vendedor = {0} ", vendedorDe));
            }

            if ((vendedorDe != null) & (vendedorAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.Id_vendedor >= {0} and p1.Id_vendedor <= {1} ", vendedorDe, vendedorAte));
            }
            #endregion

            #region NrPedidoCliente - TSO
            if (nrpedclienteAte != null & nrpedclienteDe == null)
            {
                nrpedclienteDe = nrpedclienteAte;
            }

            if ((nrpedclienteDe != null) & (nrpedclienteAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.numero_pedido_cliente = {0} ", nrpedclienteDe));
            }

            if ((nrpedclienteDe != null) & (nrpedclienteAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.numero_pedido_cliente >= {0} and p1.numero_pedido_cliente <= {1} ", nrpedclienteDe, nrpedclienteAte));
            }
            #endregion

            #region Caixa
            if (caixaAte != null & caixaDe == null)
            {
                caixaDe = caixaAte;
            }

            if ((caixaDe != null) & (caixaAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.Id_caixa = {0} ", nrpedclienteDe));
            }

            if ((caixaDe != null) & (caixaAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.Id_caixa >= {0} and p1.Id_caixa <= {1} ", caixaDe, caixaAte));
            }
            #endregion

            #region Status
            if (statusAte != null & statusDe == null)
            {
                statusDe = statusAte;
            }

            if ((statusDe != null) & (statusAte == null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.status = {0} ", statusDe));
            }

            if ((statusDe != null) & (statusAte != null))
            {
                if (filtro.Length > 0)
                {
                    filtro.Append(" and ");
                }
                filtro.Append(string.Format(" p1.status >= {0} and p1.status <= {1} ", statusDe, statusAte));
            }
            #endregion


            return filtro.ToString();
        }

        private string getConsulta()
        {
            StringBuilder consulta = new StringBuilder();

            consulta.Append("select");
            consulta.Append("  p1.codigo,");
            consulta.Append("  p1.numero_pedido_cliente,");
            consulta.Append("  cx.numero as caixa,");
            consulta.Append("  c1.razao_social as cliente,");
            consulta.Append("  c2.razao_social as transportadora,");
            consulta.Append("  pc.descricao as codicao_pagamento,");
            consulta.Append("  it.Total,");
            consulta.Append("  p1.status ");
            consulta.Append("from ");
            consulta.Append("  pedido_otica p1 ");
            consulta.Append("  inner join cliente c1 on (p1.Id_cliente = c1.Id) ");
            consulta.Append("  left join cliente c2 on (p1.Id_transportadora = c2.Id)");
            consulta.Append("  left join parcela pc ON (p1.condicao_pagamento = pc.Id )");
            consulta.Append("  left join caixa cx ON (cx.Id = p1.Id_caixa)");
            consulta.Append("  left join (select ");
            consulta.Append("              io.Id_pedido_otica, ");
            consulta.Append("              sum(io.valor_total) as Total ");
            consulta.Append("            from ");
            consulta.Append("              itempedido_otica io ");
            consulta.Append("            group by ");
            consulta.Append("              io.Id_pedido_otica) it on (p1.Id = it.Id_pedido_otica) ");

            return consulta.ToString();
        }
    }
}
