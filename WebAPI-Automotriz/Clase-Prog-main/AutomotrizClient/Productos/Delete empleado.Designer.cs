namespace AutomotrizClient.Productos
{
    partial class Delete_empleado
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
            btnconfirmar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            txtlegajo = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnconfirmar
            // 
            btnconfirmar.Location = new Point(59, 182);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(75, 23);
            btnconfirmar.TabIndex = 0;
            btnconfirmar.Text = "Confirmar";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(344, 402);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 76);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Legajo del empleado";
            // 
            // txtlegajo
            // 
            txtlegajo.Location = new Point(59, 124);
            txtlegajo.Name = "txtlegajo";
            txtlegajo.Size = new Size(100, 23);
            txtlegajo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(214, 273);
            dataGridView1.TabIndex = 4;
            // 
            // Delete_empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtlegajo);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnconfirmar);
            Name = "Delete_empleado";
            Text = "Delete_empleado";
            Load += Delete_empleado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconfirmar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtlegajo;
        private DataGridView dataGridView1;
    }
}