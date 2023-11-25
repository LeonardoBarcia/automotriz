using AutomotrizClient;
using AutomotrizClient.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutomotrizClient
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturas frmFact = new FrmFacturas();
            frmFact.ShowDialog();
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            //frmAutopartes frmAutop = new frmAutopartes();
            //frmAutop.ShowDialog();
        }



        private void toolStripTextBox13_Click(object sender, EventArgs e)
        {
            Delete_empleado eli = new Delete_empleado();
            eli.ShowDialog();
        }

        private void toolStripTextBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox11_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleado = new Empleados();
            frmEmpleado.ShowDialog();
        }

        private void toolStripTextBox12_Click(object sender, EventArgs e)
        {
            Modificacion_de_Empleados frm = new Modificacion_de_Empleados();
            frm.ShowDialog();
        }
    }
}
