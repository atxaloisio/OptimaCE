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
    public partial class frmRelReciboParcela : prjbase.frmReportBase
    {
        public frmRelReciboParcela()
        {
            InitializeComponent();
        }

        protected override void CarregaRelatorio()
        {

            rvRelatorios.LocalReport.DataSources.Clear();
            rvRelatorios.Reset();
            rvRelatorios.LocalReport.ReportEmbeddedResource = "prjbase.relatorios.relReciboParcela.rdlc";

            string ConnectionString = ConfigurationManager.ConnectionStrings["prjbase.Properties.Settings.ConnectionString"].ConnectionString;
            SqlCeConnection con = new SqlCeConnection(ConnectionString);
            SqlCeDataAdapter sda = null;

            try
            {
                con.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("select");
                sb.Append("  pop.Id,");
                sb.Append("  'Recebemos de ' + ");
                sb.Append("  c.razao_social + ");
                sb.Append("  ' a importância de ' +");
                sb.Append("  'R$ ' + ");
                sb.Append("  replace(CONVERT(nvarchar, pop.valor,2),'.',',')+ ");
                sb.Append("  ' referente a parcela nº '+ ");
                sb.Append("  convert(nvarchar,pop.numero_parcela) + ");
                sb.Append("  ' do pedido de vendas nº ' + ");
                sb.Append("  convert(nvarchar, po.codigo,0) + ");
                sb.Append("  ', com vencimento em ' + ");
                sb.Append("  pop.data_vencimento  as recibo,  ");
                sb.Append("  pop.forma_pagamento,");
                sb.Append("  pop.valor ");
                sb.Append("from ");
                sb.Append("  pedido_otica_parcelas pop ");
                sb.Append("  inner join pedido_otica po ON po.Id = pop.Id_pedido_otica");
                sb.Append("  inner join cliente c ON c.Id = po.Id_cliente ");
                sb.Append(string.Format("where pop.Id = {0}",Id));

                sda = new SqlCeDataAdapter(sb.ToString(), con);

                dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter Empresa_Logo = new dbintegracaoDataSetTableAdapters.empresa_logoTableAdapter();

                DataTable dt = new DataTable();
                DataTable dtl = new DataTable();

                //dt = prod.GetData(Convert.ToInt64(Id));
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
                parametro.Values.Add("Documento sem valor fiscal");
                parametros.Add(parametro);

                ReportParameter nrRecibo = new ReportParameter();
                nrRecibo.Name = "nrRecibo";
                nrRecibo.Values.Add(Sequence.GetNextVal("sq_recibo_parcela_sequence").ToString());
                parametros.Add(nrRecibo);

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
        }

        //protected void onSubreportProcessing(object sender, SubreportProcessingEventArgs e)
        //{
        //    dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter itempedido = new dbintegracaoDataSetTableAdapters.qryItemPedido_OticaTableAdapter();
        //    DataTable dt = itempedido.GetData(Convert.ToInt64(Id));
        //    e.DataSources.Add(new ReportDataSource("DataSetItemPedido_Otica", (object)dt));
        //}
    }
}
