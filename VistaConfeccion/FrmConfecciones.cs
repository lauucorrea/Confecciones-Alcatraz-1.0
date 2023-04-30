using VistaConfeccion;
namespace VistaConfeccion
{
    public partial class FrmConfecciones : Form
    {
        public FrmConfecciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BtnAgregarConfeccion_Click(object sender, EventArgs e)
        {
            FrmAltaPrenda frmlAltaPrenda = new FrmAltaPrenda();
            if (frmlAltaPrenda is not null)
            {
                frmlAltaPrenda.ShowDialog();
            }
        }

        private void McConfecciones_DateSelected(object sender, DateRangeEventArgs e)
        {
            string fechaSeleccionada = McConfecciones.SelectionRange.Start.ToString();
            MessageBox.Show(fechaSeleccionada);
        }
    }
}