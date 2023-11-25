using AutomotrizClient.Http;
using Libreria.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizClient.Productos
{
    public partial class Delete_empleado : Form
    {
        public Delete_empleado()
        {
            InitializeComponent();
        }

        private void Delete_empleado_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitar(true);
        }
        private void habilitar(bool x)
        {
            txtlegajo.Enabled = x;

            btnconfirmar.Enabled = x;
        }
        private void limpiarCampos()
        {
            txtlegajo.Text = string.Empty;

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro de eliminar a este empleado ?");

            elimiarEmpleadoselecciondo();
        }
        private async void elimiarEmpleadoselecciondo()
        {
            

            string url = $"http://localhost:5046/borrar_empleado?legajo={txtlegajo.Text}";
            var res = await ClientSingleton.GetInstance().DeleteAsync(url);

            if (res.Equals("true"))
            {
                MessageBox.Show("Empleado Eliminado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                habilitar(false);

            }
            else
            {
                MessageBox.Show("No se pudo Eliminar al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
