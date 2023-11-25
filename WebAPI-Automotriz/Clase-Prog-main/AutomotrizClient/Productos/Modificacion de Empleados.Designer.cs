namespace AutomotrizClient.Productos
{
    partial class Modificacion_de_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn2Confirmar = new Button();
            comboModifi = new ComboBox();
            textNyAmodi = new TextBox();
            label1 = new Label();
            label4 = new Label();
            btncerrar = new Button();
            dgvEmpleados = new DataGridView();
            txtlegajo = new TextBox();
            lbllegajo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btn2Confirmar
            // 
            btn2Confirmar.Location = new Point(41, 390);
            btn2Confirmar.Name = "btn2Confirmar";
            btn2Confirmar.Size = new Size(91, 33);
            btn2Confirmar.TabIndex = 33;
            btn2Confirmar.Text = "Confirmar";
            btn2Confirmar.UseVisualStyleBackColor = true;
            btn2Confirmar.Click += btn2Confirmar_Click;
            // 
            // comboModifi
            // 
            comboModifi.FormattingEnabled = true;
            comboModifi.Location = new Point(25, 271);
            comboModifi.Name = "comboModifi";
            comboModifi.Size = new Size(137, 23);
            comboModifi.TabIndex = 32;
            // 
            // textNyAmodi
            // 
            textNyAmodi.Location = new Point(25, 186);
            textNyAmodi.Name = "textNyAmodi";
            textNyAmodi.Size = new Size(140, 23);
            textNyAmodi.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 241);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 30;
            label1.Text = "Tipo de Empleado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 153);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 29;
            label4.Text = "Nombre y Apellido";
            // 
            // btncerrar
            // 
            btncerrar.Location = new Point(420, 390);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(91, 33);
            btncerrar.TabIndex = 35;
            btncerrar.Text = "Cerrar";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Enabled = false;
            dgvEmpleados.Location = new Point(245, 70);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(266, 276);
            dgvEmpleados.TabIndex = 36;
            dgvEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtlegajo
            // 
            txtlegajo.Location = new Point(30, 99);
            txtlegajo.Name = "txtlegajo";
            txtlegajo.Size = new Size(140, 23);
            txtlegajo.TabIndex = 37;
            // 
            // lbllegajo
            // 
            lbllegajo.AutoSize = true;
            lbllegajo.Location = new Point(30, 70);
            lbllegajo.Name = "lbllegajo";
            lbllegajo.Size = new Size(95, 15);
            lbllegajo.TabIndex = 38;
            lbllegajo.Text = "legajo Empleado";
            // 
            // Modificacion_de_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(lbllegajo);
            Controls.Add(txtlegajo);
            Controls.Add(dgvEmpleados);
            Controls.Add(btncerrar);
            Controls.Add(btn2Confirmar);
            Controls.Add(comboModifi);
            Controls.Add(textNyAmodi);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Modificacion_de_Empleados";
            Text = "Modificacion_de_Empleados";
            Load += Modificacion_de_Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn2Confirmar;
        private ComboBox comboModifi;
        private TextBox textNyAmodi;
        private Label label1;
        private Label label4;
        private Button btncerrar;
        private DataGridView dgvEmpleados;
        private TextBox txtlegajo;
        private Label lbllegajo;
    }
}