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
    public partial class frmproductos : Form
    {
        public frmproductos()
        {
            InitializeComponent();
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            DataSetProductos d = new DataSetProductos();


            string cs = @"Data Source=LEONARDODJ-PC\SQLEXPRESS;Initial Catalog=AutomotrizDB_PROG;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(cs);


            SqlDataAdapter da = new SqlDataAdapter("SELECT   Productos.precio, Tipos_vehiculo.descripcion FROM  Productos INNER JOIN Tipos_vehiculo ON Productos.cod_tipo_vehiculo = Tipos_vehiculo.cod_tipo_vehiculo", cnn);

            da.Fill(d, d.Tables[0].TableName);



            ReportDataSource rds = new ReportDataSource("DataSet1", d.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TIP_programacionII.Reportes.data.Reportproducto.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
