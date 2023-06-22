using Entidades;

namespace VistaConfeccion
{
    public partial class FrmMain : Form
    {
        string fechaSeleccionada;
        Persona PersonaLogueada;

        public FrmMain(Persona personaLogueada)
        {
            InitializeComponent();
            if (PersonaLogueada is not null)
            {
                PersonaLogueada = personaLogueada;
            }
        }
        private void FrmConfecciones_Load(object sender, EventArgs e)
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgMuestreoMain.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgMuestreoMain.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgMuestreoMain.Columns.Add("ColumnaFechaInicio", "Fecha Inicio");
            DtgMuestreoMain.Columns.Add("ColumnaFechaFin", "Fecha Fin");
            DtgMuestreoMain.Columns.Add("ColumnaDuracionHs", "Horas Produccion");
            DtgMuestreoMain.Columns.Add("ColumnaDuracionDias", "Dias Produccion");
            DtgMuestreoMain.Columns.Add("ColumnaEtapa", "Etapa");
            DtgMuestreoMain.Columns.Add("ColumnaPrendas", "Prendas en corte");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
            {
                foreach (Corte corte in par.Value)
                {

                    // Crear una nueva fila y asignar los valores de las celdas
                    DataGridViewRow fila = new();
                    fila.CreateCells(DtgMuestreoMain);
                    fila.Cells[0].Value = corte.FechaInicio.ToShortDateString(); 
                    fila.Cells[1].Value = par.Key.ToShortDateString(); 
                    fila.Cells[2].Value = corte.HorasTotalesCorte; 
                    fila.Cells[3].Value = corte.HorasTotalesCorte / 24;
                    fila.Cells[4].Value = corte.Etapa;
                    fila.Cells[5].Value = corte.PrendasEnConfeccion.Count;

                    // Agregar la fila al DataGridView
                    DtgMuestreoMain.Rows.Add(fila);
                }
            }
        }


        private void gestionarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}