using Entidades;
using Procesos;
namespace VistaConfeccion
{
    public partial class FrmAltaConfeccion : Form
    {
        Confeccion PreConfeccion;
        public FrmAltaConfeccion()
        {
            InitializeComponent();
        }

        private void BtnAgregarConfeccion_Click(object sender, EventArgs e)
        {
            if (PreConfeccion != null && GestionDatos.PrendasParaConfeccion is not null)
            {
                DateTime fechaInicio = McFechaEntrega.SelectionStart;
                int cantidadDiasConfeccion = Administracion.CalcularTiempoConfeccion(GestionDatos.PrendasParaConfeccion, Convert.ToInt32(NumUnidades.Value), 8);
                DateTime fechaFinal = fechaInicio.AddDays(cantidadDiasConfeccion);
                McFechaEntrega.SelectionEnd = fechaFinal;
                MessageBox.Show(cantidadDiasConfeccion.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            VaciarInformacion();
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
            try
            {

                if (DtgPrendasSistema.SelectedRows.Count != 0)
                {
                    Prenda prendaSeleccionada = (Prenda)DtgPrendasSistema.SelectedRows[0].DataBoundItem;

                    if (!GestionDatos.PrendasParaConfeccion.Contains(prendaSeleccionada))
                    {

                        //Guardo el talle selecionado en la preconfeccion
                        TallePrenda[] talles = (TallePrenda[])Enum.GetValues(typeof(TallePrenda));
                        TallePrenda talle = talles[CmbTalle.SelectedIndex];

                        //Agrego la prenda a la lista de prendas guardada en al clase estatica GestionDatos
                        GestionDatos.PrendasParaConfeccion.Add(prendaSeleccionada);
                        //Recargo la lista de prendas al datagrid
                        DtgPrendasConfeccion.DataSource = null; // Limpia el origen de datos
                        DtgPrendasConfeccion.DataSource = GestionDatos.PrendasParaConfeccion;

                        //Creo la preconfeccion
                        if (PreConfeccion is not null && PreConfeccion.PrendasEnConfeccion.Count != 0)
                        {
                            PreConfeccion.PrendasEnConfeccion.Add(prendaSeleccionada);
                        }
                        else
                        {
                            PreConfeccion = new(talle, Confeccion.CondicionEntrega.Procesando);
                        }

                        if (PreConfeccion is null)
                        {
                            throw new NullReferenceException("Hubo un problema en la creacion de la preconfeccion");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LblErrores.Text = ex.Message;
            }
        }

        private void DtgPrendasSistema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DtgPrendasSistema.Rows[e.RowIndex].Selected = true;
            }
        }

        private void McFechaEntrega_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (PreConfeccion is not null && GestionDatos.PrendasParaConfeccion is not null)
            {
                PreConfeccion.FechaInicio = McFechaEntrega.SelectionRange.Start;
            }
            else
            {
                MessageBox.Show("Primero debe cargar prendas a la confeccion");
            }
        }

        private void McFechaEntrega_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void VaciarInformacion()
        {
            if(GestionDatos.PrendasParaConfeccion is not null && GestionDatos.PrendasParaConfeccion.Count > 0)
            {
                GestionDatos.PrendasParaConfeccion.Clear();
                PreConfeccion = null;
                DtgFechasPrevistas.DataSource = null;
                DtgPrendasConfeccion.DataSource = null;
                NumUnidades.Value = 1;
            }
        }
    }
}
