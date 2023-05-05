using Entidades;
namespace VistaConfeccion
{
    public partial class FrmAltaConfeccion : Form
    {
        Confeccion confeccion;
        public FrmAltaConfeccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAltaConfeccion_Load(object sender, EventArgs e)
        {
            string[] talles = Enum.GetNames(typeof(TallePrenda));
            CmbTalle.DataSource = talles;
            DtgPrendasSistema.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgPrendasConfeccion.AutoGenerateColumns = true;
            DtgPrendasSistema.DataSource = GestionDatos.PrendasCreadas;
            DtgPrendasConfeccion.DataSource = GestionDatos.PrendasParaConfeccion;
        }

        private void BtnAgregarPrenda_Click(object sender, EventArgs e)
        {
            if (DtgPrendasSistema.SelectedRows.Count != 0)
            {
                Prenda prendaSeleccionada = (Prenda)DtgPrendasSistema.SelectedRows[0].DataBoundItem;

                if (!GestionDatos.PrendasParaConfeccion.Contains(prendaSeleccionada))
                {
                    GestionDatos.PrendasParaConfeccion.Add(prendaSeleccionada);
                    DtgPrendasConfeccion.DataSource = null; // Limpia el origen de datos
                    DtgPrendasConfeccion.DataSource = GestionDatos.PrendasParaConfeccion;

                    TallePrenda[] talles = (TallePrenda[])Enum.GetValues(typeof(TallePrenda));
                    TallePrenda talle = talles[CmbTalle.SelectedIndex];
                    confeccion = new(talle, Confeccion.CondicionEntrega.Procesando);

                    if (confeccion is not null)
                    {
                        MessageBox.Show(confeccion.ToString());
                    }
                }
            }
        }

        private void DtgPrendasSistema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DtgPrendasSistema.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
