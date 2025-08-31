using Clase2._2C2025.Entidad;

namespace Clase2._2C2025
{
    public partial class frmDuplex : Form
    {
        public frmDuplex()
        {
            InitializeComponent();
            cargarNumeroDuplex();
            cargarCantidadPersonas();
        }

        private void cargarNumeroDuplex()
        {
            cboNumeroDuplex.Items.Clear();
            cboNumeroDuplex.Items.Add("Duplex 1");
            cboNumeroDuplex.Items.Add("Duplex 2");
            cboNumeroDuplex.Items.Add("Duplex 3");
            cboNumeroDuplex.Items.Add("Duplex 4");
            cboNumeroDuplex.Items.Add("Duplex 5");
            cboNumeroDuplex.Items.Add("Duplex 6");
            cboNumeroDuplex.Items.Add("Duplex 7");
            cboNumeroDuplex.SelectedIndex = 0;
        }

        private void cargarCantidadPersonas()
        {
            cboCantidadPersonas.Items.Clear();
            for (int i = 1; i <= 8; i++)
            {
                cboCantidadPersonas.Items.Add(i.ToString());
            }
            cboCantidadPersonas.SelectedIndex = 0;
        }

        private void btnGuardarDuplex_Click(object sender, EventArgs e)
        {

            Duplex duplex = new Duplex(mcFecha.SelectionStart.ToShortDateString(),
                txtCliente.Text, 
                cboNumeroDuplex.SelectedItem.ToString(), 
                cboCantidadPersonas.SelectedItem.ToString(),
                txtPrecio.Text);

            CargarGrillaDuplex(duplex);

            // Limpiar los campos después de guardar
            mcFecha.SetDate(DateTime.Now);
            txtCliente.Clear();
            cboNumeroDuplex.SelectedIndex = 0;
            cboCantidadPersonas.SelectedIndex = 0;
            txtPrecio.Clear();

        }

        private void CargarGrillaDuplex(Duplex duplex)
        {
            dgvDuplex.Rows.Add(duplex.Fecha, 
                duplex.Cliente, 
                duplex.NumeroDuplex, 
                duplex.NumeroPersonas, 
                duplex.Precio);
        }

        private void btnEliminarDuplex_Click(object sender, EventArgs e)
        {
            if (dgvDuplex.SelectedRows.Count > 0)
            {
                dgvDuplex.Rows.RemoveAt(dgvDuplex.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvDuplex.Refresh();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta frmAlta = new frmAlta();
            frmAlta.Show();
        }
    }
}
