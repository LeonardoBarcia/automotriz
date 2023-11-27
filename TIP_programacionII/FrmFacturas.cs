using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIP_programacionII.Reportes.data;

namespace TIP_programacionII
{
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {

            DataSet1 d = new DataSet1();


            string cs = @"Data Source=LEONARDODJ-PC\SQLEXPRESS;Initial Catalog=AutomotrizDB_PROG;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(cs);


            SqlDataAdapter da = new SqlDataAdapter("SELECT  Detalles_factura.precio, Facturas.fecha  FROM   Detalles_factura INNER JOIN Facturas ON Detalles_factura.cod_factura = Facturas.cod_factura", cnn);

            da.Fill(d, d.Tables[0].TableName);



            ReportDataSource rds = new ReportDataSource("DataSet1", d.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TIP_programacionII.Reportes.data.ReportFactura.rdlc";
            reportViewer1.RefreshReport();


        }
    }
}
