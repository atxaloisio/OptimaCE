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
using System.Configuration;
using System.Data.SqlServerCe;

namespace prjbase
{
    public partial class frmRelReciboVenda : prjbase.frmReportBase
    {
        public frmRelReciboVenda()
        {
            InitializeComponent();
        }

        protected override void CarregaRelatorio()
        {

            rvRelatorios.LocalReport.DataSources.Clear();
            rvRelatorios.Reset();
            rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relReciboVenda.rdlc";

            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            SqlCeDataAdapter qryReciboVenda = null;
            SqlCeDataAdapter qryParcela = null;

            try
            {
                con.Open();
                StringBuilder sbReciboVenda = new StringBuilder();
                sbReciboVenda.Append("select ");
                sbReciboVenda.Append("  po.codigo pedido,");
                sbReciboVenda.Append("  c.razao_social,");
                sbReciboVenda.Append("  c.endereco,");
                sbReciboVenda.Append("  c.endereco_numero, ");
                sbReciboVenda.Append("  c.complemento,");
                sbReciboVenda.Append("  c.bairro,");
                sbReciboVenda.Append("  c.cidade,");
                sbReciboVenda.Append("  c.estado,");
                sbReciboVenda.Append("  c.cep,");
                sbReciboVenda.Append("  c.telefone1_ddd, ");
                sbReciboVenda.Append("  c.telefone1_numero,");
                sbReciboVenda.Append("  p.codigo,");
                sbReciboVenda.Append("  p.descricao,");
                sbReciboVenda.Append("  ipo.unidade,");
                sbReciboVenda.Append("  ipo.valor_unitario,");
                sbReciboVenda.Append("  ipo.valor_total ");
                sbReciboVenda.Append("from ");
                sbReciboVenda.Append("  pedido_otica po ");
                sbReciboVenda.Append("  inner join cliente c ON c.Id = po.Id_cliente ");
                sbReciboVenda.Append("  left join itempedido_otica ipo on ipo.Id_pedido_otica = po.Id ");
                sbReciboVenda.Append("  inner join produto p ON p.id = ipo.Id_produto ");
                sbReciboVenda.Append("where ");
                sbReciboVenda.Append(string.Format("  po.Id = {0}",Id));


                qryReciboVenda = new SqlCeDataAdapter(sbReciboVenda.ToString(), con);

                StringBuilder sbParcela = new StringBuilder();
                sbParcela.Append("select ");
                sbParcela.Append("  pop.Id, ");
                sbParcela.Append("  pop.numero_parcela,  ");
                sbParcela.Append("  pop.valor,   ");
                sbParcela.Append("  pop.data_vencimento, ");
                sbParcela.Append("  pa.descricao ");
                sbParcela.Append("from ");
                sbParcela.Append("  pedido_otica_parcelas pop ");
                sbParcela.Append("  inner join pedido_otica po ON po.Id = pop.Id_pedido_otica");
                sbParcela.Append("  inner join parcela pa ON pa.Id = po.condicao_pagamento ");
                sbParcela.Append("where ");
                sbParcela.Append(string.Format(" po.Id = {0}",Id));


                qryParcela = new SqlCeDataAdapter(sbParcela.ToString(), con);
                
                dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter Empresa_Logo = new dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter();
                
                DataTable dt = new DataTable();
                DataTable dtl = new DataTable();
                DataTable dtp = new DataTable();

                //dt = prod.GetData(Convert.ToInt64(Id));
                
                qryReciboVenda.Fill(dt);
                dtl = Empresa_Logo.GetData();
                qryParcela.Fill(dtp);
                
                ReportDataSource ds = new ReportDataSource(dt.TableName, dt);
                ReportDataSource ds2 = new ReportDataSource(dtl.TableName, dtl);
                ReportDataSource ds3 = new ReportDataSource(dtp.TableName, dtp);


                ds.Name = "DataSet1";
                ds2.Name = "DataSet2";
                ds3.Name = "DataSet3";
                rvRelatorios.LocalReport.DataSources.Add(ds);
                rvRelatorios.LocalReport.DataSources.Add(ds2);
                rvRelatorios.LocalReport.DataSources.Add(ds3);

                //rvRelatorios.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(onSubreportProcessing);

                ReportParameterCollection parametros = new ReportParameterCollection();
                ReportParameter parametro = new ReportParameter();
                parametro.Name = "EndLaboratorio";
                parametro.Values.Add("Documento sem valor fiscal");
                parametro.Values.Add("");
                parametros.Add(parametro);

                ReportParameter nrRecibo = new ReportParameter();
                nrRecibo.Name = "nrRecibo";

                nrRecibo.Values.Add(Sequence.GetNextVal("sq_recibo_venda_sequence").ToString());
                parametros.Add(nrRecibo);
                rvRelatorios.LocalReport.SetParameters(parametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }

            
        }

        //protected void onSubreportProcessing(object sender, SubreportProcessingEventArgs e)
        //{
        //    dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter itempedido = new dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter();
        //    DataTable dt = itempedido.GetData(Convert.ToInt64(Id));
        //    e.DataSources.Add(new ReportDataSource("DataSetItemPedido_Otica", (object)dt));
        //}
    }
}
