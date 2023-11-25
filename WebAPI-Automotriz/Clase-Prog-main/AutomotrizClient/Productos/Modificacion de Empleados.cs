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
    public partial class Modificacion_de_Empleados : Form
    {
        public Modificacion_de_Empleados()
        {
            InitializeComponent();
        }

        private void Modificacion_de_Empleados_Load(object sender, EventArgs e)
        {
            cargarcomboTipoEmpleadosAsync();
            cargarEmpleadoslst();
            limpiar();
            habilitar(true);
        }

        private void habilitar(bool x)
        {
            txtlegajo.Enabled = x;
            textNyAmodi.Enabled = x;
            comboModifi.Enabled = x;
            btn2Confirmar.Enabled = x;

        }

        private void limpiar()
        {
            txtlegajo.Text = string.Empty;
            textNyAmodi.Text = string.Empty;
            comboModifi.SelectedIndex = -1;
        }

        private async void cargarEmpleadoslst()
        {
            string url = "http://localhost:5046/empleados";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            //var lst = JsonConvert.DeserializeObject<List<Empleados>>(res);
            List<Empleados> empleado = JsonConvert.DeserializeObject<List<Empleados>>(res);

            dgvEmpleados.AutoGenerateColumns = true;
            dgvEmpleados.DataSource =empleado;




        }

        private async void cargarcomboTipoEmpleadosAsync()
        {
            string url = "http://localhost:5046/tipos_empleado";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoEmpleado>>(res);
            comboModifi.DataSource = lst;
            comboModifi.ValueMember = "Codigo";
            comboModifi.DisplayMember = "Descripcion";
            comboModifi.SelectedIndex = -1;
        }
        private async Task modificarEmpleado()
        {
            Empleado oEmpleado = new Empleado();
            oEmpleado.Legajo = Convert.ToInt32(txtlegajo.Text);
            oEmpleado.Nombre = textNyAmodi.Text;
            oEmpleado.Tipo_empleado = comboModifi.SelectedIndex + 1;

            string bodyContent = JsonConvert.SerializeObject(oEmpleado);

            string url = "http://localhost:5046/modificar_empleado";
            var res = await ClientSingleton.GetInstance().PutAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Empleado Actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                habilitar(false);
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2Confirmar_Click(object sender, EventArgs e)
        {
            if (comboModifi.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de empleado!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(textNyAmodi.Text))
            {
                // Verificar que solo se ingresen letras
                if (textNyAmodi.Text.All(char.IsLetter))
                {
                    // Todo está bien, solo contiene letras
                }
                else
                {
                    MessageBox.Show("El Nombre solo puede contener letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("El Nombre no puede estar vacío.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            modificarEmpleado();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
