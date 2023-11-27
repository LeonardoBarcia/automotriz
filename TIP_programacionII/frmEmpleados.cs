using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System.Data;
using System.Data.SqlClient;
using TIP_programacionII.Reportes.data;

namespace TIP_programacionII
{
    public partial class frmEmpleados : Form
    {
        private SqlConnection coneccion;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSetempleados d = new DataSetempleados();
           
            
            string cs = @"Data Source=LEONARDODJ-PC\SQLEXPRESS;Initial Catalog=AutomotrizDB_PROG;Integrated Security=True";
            
            SqlConnection cnn = new SqlConnection(cs);
            
            
            SqlDataAdapter da = new SqlDataAdapter("select legajo,nombre from Empleados",cnn);

            da.Fill(d, d.Tables[0].TableName);

            

            ReportDataSource rds = new ReportDataSource("DataSet1", d.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TIP_programacionII.Reportes.data.Reportempleados.rdlc";
            reportViewer1.RefreshReport();

           
        }
    }
}