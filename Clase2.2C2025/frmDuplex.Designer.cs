
namespace Clase2._2C2025
{
    partial class frmDuplex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mcFecha = new MonthCalendar();
            lblCliente = new Label();
            txtCliente = new TextBox();
            cboNumeroDuplex = new ComboBox();
            lblDuplex = new Label();
            lblCantidadPersonas = new Label();
            cboCantidadPersonas = new ComboBox();
            btnGuardarDuplex = new Button();
            dgvDuplex = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            NombreDelCliente = new DataGridViewTextBoxColumn();
            NumeroDeDuplex = new DataGridViewTextBoxColumn();
            CantidadPersonas = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            label4 = new Label();
            btnAlta = new Button();
            btnEliminarDuplex = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDuplex).BeginInit();
            SuspendLayout();
            // 
            // mcFecha
            // 
            mcFecha.BackColor = SystemColors.Desktop;
            mcFecha.Location = new Point(18, 22);
            mcFecha.Name = "mcFecha";
            mcFecha.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(236, 17);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(110, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Nombre del Cliente";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.LightSkyBlue;
            txtCliente.Location = new Point(236, 35);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(232, 23);
            txtCliente.TabIndex = 2;
            // 
            // cboNumeroDuplex
            // 
            cboNumeroDuplex.BackColor = Color.LightSkyBlue;
            cboNumeroDuplex.FormattingEnabled = true;
            cboNumeroDuplex.Location = new Point(236, 92);
            cboNumeroDuplex.Name = "cboNumeroDuplex";
            cboNumeroDuplex.Size = new Size(232, 23);
            cboNumeroDuplex.TabIndex = 3;
            // 
            // lblDuplex
            // 
            lblDuplex.AutoSize = true;
            lblDuplex.Location = new Point(236, 74);
            lblDuplex.Name = "lblDuplex";
            lblDuplex.Size = new Size(107, 15);
            lblDuplex.TabIndex = 4;
            lblDuplex.Text = "Numero de Duplex";
            // 
            // lblCantidadPersonas
            // 
            lblCantidadPersonas.AutoSize = true;
            lblCantidadPersonas.Location = new Point(236, 127);
            lblCantidadPersonas.Name = "lblCantidadPersonas";
            lblCantidadPersonas.Size = new Size(121, 15);
            lblCantidadPersonas.TabIndex = 6;
            lblCantidadPersonas.Text = "Cantidad de Personas";
            // 
            // cboCantidadPersonas
            // 
            cboCantidadPersonas.BackColor = Color.LightSkyBlue;
            cboCantidadPersonas.FormattingEnabled = true;
            cboCantidadPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cboCantidadPersonas.Location = new Point(236, 147);
            cboCantidadPersonas.Name = "cboCantidadPersonas";
            cboCantidadPersonas.Size = new Size(232, 23);
            cboCantidadPersonas.TabIndex = 5;
            // 
            // btnGuardarDuplex
            // 
            btnGuardarDuplex.BackColor = Color.MediumSpringGreen;
            btnGuardarDuplex.ForeColor = SystemColors.WindowText;
            btnGuardarDuplex.Location = new Point(490, 188);
            btnGuardarDuplex.Name = "btnGuardarDuplex";
            btnGuardarDuplex.Size = new Size(129, 44);
            btnGuardarDuplex.TabIndex = 7;
            btnGuardarDuplex.Text = "Guardar Duplex";
            btnGuardarDuplex.UseVisualStyleBackColor = false;
            btnGuardarDuplex.Click += btnGuardarDuplex_Click;
            // 
            // dgvDuplex
            // 
            dgvDuplex.BackgroundColor = Color.LightCyan;
            dgvDuplex.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuplex.Columns.AddRange(new DataGridViewColumn[] { Fecha, NombreDelCliente, NumeroDeDuplex, CantidadPersonas, Precio });
            dgvDuplex.Location = new Point(8, 253);
            dgvDuplex.Name = "dgvDuplex";
            dgvDuplex.Size = new Size(749, 185);
            dgvDuplex.TabIndex = 8;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // NombreDelCliente
            // 
            NombreDelCliente.HeaderText = "NombreDelCliente";
            NombreDelCliente.Name = "NombreDelCliente";
            NombreDelCliente.ReadOnly = true;
            // 
            // NumeroDeDuplex
            // 
            NumeroDeDuplex.HeaderText = "NumeroDeDuplex";
            NumeroDeDuplex.Name = "NumeroDeDuplex";
            NumeroDeDuplex.ReadOnly = true;
            // 
            // CantidadPersonas
            // 
            CantidadPersonas.HeaderText = "CantidadPersonas";
            CantidadPersonas.Name = "CantidadPersonas";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SpringGreen;
            btnActualizar.Location = new Point(631, 188);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 44);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(490, 22);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.Lime;
            btnAlta.Location = new Point(490, 37);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(270, 44);
            btnAlta.TabIndex = 11;
            btnAlta.Text = "Dar Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnEliminarDuplex
            // 
            btnEliminarDuplex.BackColor = Color.Red;
            btnEliminarDuplex.ForeColor = SystemColors.Control;
            btnEliminarDuplex.Location = new Point(490, 126);
            btnEliminarDuplex.Name = "btnEliminarDuplex";
            btnEliminarDuplex.Size = new Size(129, 44);
            btnEliminarDuplex.TabIndex = 12;
            btnEliminarDuplex.Text = "Eliminar Duplex";
            btnEliminarDuplex.UseVisualStyleBackColor = false;
            btnEliminarDuplex.Click += btnEliminarDuplex_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(236, 179);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.LightSkyBlue;
            txtPrecio.Location = new Point(236, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(232, 23);
            txtPrecio.TabIndex = 14;
            // 
            // frmDuplex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(769, 450);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnEliminarDuplex);
            Controls.Add(btnAlta);
            Controls.Add(label4);
            Controls.Add(btnActualizar);
            Controls.Add(dgvDuplex);
            Controls.Add(btnGuardarDuplex);
            Controls.Add(lblCantidadPersonas);
            Controls.Add(cboCantidadPersonas);
            Controls.Add(lblDuplex);
            Controls.Add(cboNumeroDuplex);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(mcFecha);
            Name = "frmDuplex";
            Text = "Formulario de Duplex";
            ((System.ComponentModel.ISupportInitialize)dgvDuplex).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MonthCalendar mcFecha;
        private Label lblCliente;
        private TextBox txtCliente;
        private ComboBox cboNumeroDuplex;
        private Label lblDuplex;
        private Label lblCantidadPersonas;
        private ComboBox cboCantidadPersonas;
        private Button btnGuardarDuplex;
        private DataGridView dgvDuplex;
        private Button btnActualizar;
        private Label label4;
        private Button btnAlta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn NombreDelCliente;
        private DataGridViewTextBoxColumn NumeroDeDuplex;
        private DataGridViewTextBoxColumn CantidadPersonas;
        #endregion

        private Button btnEliminarDuplex;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private DataGridViewTextBoxColumn Precio;
    }
}