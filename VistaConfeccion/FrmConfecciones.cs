namespace VistaConfeccion
{
    public partial class FrmConfecciones : Form
    {
        string fechaSeleccionada;
        public FrmConfecciones()
        {
            //fechaSeleccionada = fecha;
            InitializeComponent();
        }

        private void FrmConfecciones_Load(object sender, EventArgs e)
        {
        }

        private void McConfecciones_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechaSeleccionada = McConfecciones.SelectionRange.Start.ToString();
            MessageBox.Show(fechaSeleccionada);
        }

        private void BtnAgregarConfeccion_Click(object sender, EventArgs e)
        {
            FrmAltaPrenda frmlAltaPrenda = new FrmAltaPrenda();
            if (frmlAltaPrenda is not null)
            {
                if (frmlAltaPrenda.ShowDialog() != DialogResult.OK)
                {
                    frmlAltaPrenda.Close();

                }
            }
        }

        private void BtnAgregarPrenda_Click(object sender, EventArgs e)
        {
            FrmAltaConfeccion frmAltaConfeccion = new FrmAltaConfeccion();
            if (frmAltaConfeccion is not null)
            {
                if (frmAltaConfeccion.ShowDialog() != DialogResult.OK)
                {
                    frmAltaConfeccion.Close();
                }
            }
        }
    }
}