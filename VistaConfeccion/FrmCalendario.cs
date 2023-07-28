using Entidades;
using System.Data;
using System.Globalization;
using System.Text;

namespace Vista
{
    public partial class FrmCalendario : Form
    {
        Persona PersonaLogueada;
        DateTime MesActual;
        DataTable Calendario;
        public FrmCalendario(Persona persona)
        {

            InitializeComponent();
            PersonaLogueada = persona;
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            MesActual = DateTime.Now;
            CrearCalendario(MesActual);
            AutoScroll = false;
        }
        public void CrearCalendario(DateTime fecha)
        {
            Calendario = ObtenerFilasCalendario(fecha);
            DtgCalendario.DataSource = Calendario;
            // AjustarAltosFilas(DtgCalendario, DtgCalendario.Height);
            // RedimensionarForm();

            AjustarAltosFilas(DtgCalendario, DtgCalendario.Height);
            RedimensionarForm();
            DtgCalendario.CellPainting += DtgCalendario_CellPainting;
        }
        public DataTable ObtenerFilasCalendario(DateTime fecha)
        {

            DataTable dataTable = new DataTable();
            // Obtener el primer día del mes actual
            DateTime diaInicioActualizable = new DateTime(fecha.Year, fecha.Month, 1);
            // Obtener el día de la semana en el que empieza el mes
            int diaSemanaInicio = (int)diaInicioActualizable.DayOfWeek;
            // Obtener el último día del mes actual
            DateTime ultimoDiaDelMes = diaInicioActualizable.AddMonths(1).AddDays(-1);
            string[] nombresDiasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            DateTime diaActualizado = diaInicioActualizable.AddDays(-diaSemanaInicio);

            foreach (string nombreDia in nombresDiasSemana)
            {
                dataTable.Columns.Add(nombreDia, typeof(string));
            }

            while (diaActualizado <= ultimoDiaDelMes || diaActualizado.DayOfWeek != DayOfWeek.Sunday)
            {
                // Agregar filas al DataTable para cada semana del mes
                DataRow row = dataTable.NewRow();

                // Iterar sobre los días de la semana
                for (int i = 0; i < 7; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    // Verificar si el día actual está dentro del mes
                    if (diaActualizado.Month == diaInicioActualizable.Month || diaActualizado.DayOfWeek == DayOfWeek.Sunday)
                    {
                        // Obtener los cortes correspondientes a la fecha actual
                        List<Corte> cortesEnFecha = Administracion.ObtenerCortesPorFecha(diaActualizado);
                        if (cortesEnFecha is not null && cortesEnFecha.Count > 0)
                        {
                            // Construir una cadena con los identificadores de los cortes
                            foreach (Corte corte in cortesEnFecha)
                            {
                                if (cortesEnFecha.IndexOf(corte) == 0)
                                {
                                    sb.Append("Identificador de cortes: ");
                                }
                                sb.Append($"{corte.IdentificadorDeCorte}\n");

                                sb.Append(corte.ToString());
                                if (cortesEnFecha.IndexOf(corte) != cortesEnFecha.Count - 1)
                                {
                                    sb.Append(", ");
                                }
                            }

                            sb.Append($"\n Fecha: {diaActualizado.Day}/{diaActualizado.Month}");
                            // Eliminar la coma final y los espacios
                            // row[i] = sb.ToString();
                        }
                        else
                        {
                            sb.Append($"\n Fecha: {diaActualizado.Day}/{diaActualizado.Month}"); // Mostrar la numeración del día
                        }
                    }
                    else
                    {
                        sb.Append($" Fecha fuera mes: {diaActualizado.Day}/{diaActualizado.Month}"); // Mostrar la fecha del día correspondiente a otro mes
                    }
                    //row[i] = sb.ToString();

                    // Crear una nueva celda y establecer su valor
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = sb.ToString();

                    // Establecer el valor de la propiedad "tag" de la celda como diaActualizado
                    cell.Tag = diaActualizado;

                    // Agregar la celda a la fila actual
                    row[i] = cell.Value;

                    diaActualizado = diaActualizado.AddDays(1);
                }

                dataTable.Rows.Add(row);
            }
            return dataTable;
        }


        /// <summary>
        /// Centra contenido y configura aspectos visuales del datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtgCalendario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda actual
                DataGridViewCell cell = DtgCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Establecer el estilo de la celda
                DataGridViewCellStyle style = new();
                style.BackColor = cell.Style.BackColor; // Utiliza el color de fondo actual
                style.SelectionBackColor = cell.Style.SelectionBackColor; // Utiliza el color de selección actual

                // Dibujar la celda como un cuadrado
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.FillRectangle(new SolidBrush(style.BackColor), e.CellBounds);

                // Dibujar el contenido de la celda centrado
                if (cell.Value != null)
                {
                    string text = cell.Value.ToString();
                    using (StringFormat format = new StringFormat())
                    {
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;
                        e.Graphics.DrawString(text, e.CellStyle.Font, Brushes.Black, e.CellBounds, format);
                    }
                }

                // Evitar la pintura predeterminada de la celda
                e.Handled = true;
            }

        }

        public void AjustarAltosFilas(DataGridView dataGridView, int altoTotal)
        {

            int numFilas = dataGridView.Rows.Count; // Obtener el número de filas actual del DataGridView

            if (numFilas > 0)
            {
                int altoFila = altoTotal / numFilas; // Calcular el alto exacto de cada fila

                // Configurar el alto de cada fila del DataGridView
                foreach (DataGridViewRow fila in dataGridView.Rows)
                {
                    fila.Height = altoFila;
                }
            }
        }
        /// <summary>
        /// Redimensiona la ventana del formulario para que se adapte al contenido del mismo
        /// </summary>
        private void RedimensionarForm()
        {
            int AltoGridIni = DtgCalendario.Height;
            int AltoGrid = 0;
            int AltoForm = this.Height;
            int Diferencia;
            AltoGrid = AltoGrid + DtgCalendario.ColumnHeadersHeight;

            for (int i = 0; i <= DtgCalendario.Rows.Count - 1; i++)
            {
                AltoGrid = AltoGrid + DtgCalendario.Rows[i].Height;
            }
            Diferencia = AltoGridIni - AltoGrid;

            if (Diferencia > 0)
            {
                AltoForm = AltoForm - Diferencia;
                this.Height = AltoForm;
            }
            else if (Diferencia < 0)
            {
                AltoForm = AltoForm + Diferencia;
                this.Height = AltoForm;
            }
            DtgCalendario.Height = AltoGrid;


        }

        private void VaciarCeldas(DataGridView dataGridView)
        {
            // Iterar a través de todas las filas y columnas
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Establecer el valor de la celda como nulo o una cadena vacía
                    if (cell.ValueType == typeof(string))
                    {
                        cell.Value = string.Empty; // Vaciar celdas de tipo cadena
                    }
                    else
                    {
                        cell.Value = null; // Vaciar celdas de otros tipos de datos
                    }
                }
            }
        }

        private void BtnMesSiguiente_Click(object sender, EventArgs e)
        {
            VaciarCeldas(DtgCalendario);
            Calendario = new();
            MesActual = MesActual.AddMonths(1);
            LblMesActual.Text = CultureInfo.GetCultureInfo("es-ES").DateTimeFormat.GetMonthName(MesActual.Month);
            CrearCalendario(MesActual);
            DtgCalendario.CellPainting += DtgCalendario_CellPainting;
        }

        private void BtnMesAnterior_Click(object sender, EventArgs e)
        {
            VaciarCeldas(DtgCalendario);
            Calendario = new();
            MesActual = MesActual.AddMonths(-1);
            LblMesActual.Text = CultureInfo.GetCultureInfo("es-ES").DateTimeFormat.GetMonthName(MesActual.Month);
            CrearCalendario(MesActual);
            DtgCalendario.CellPainting += DtgCalendario_CellPainting;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar?";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar? No se guardaran los cambios sin guardar";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clase_serializadora serializadora = new();
                // serializadora.GuardarPersonasXML();
                // serializadora.GuardarAvionesXML();

                DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnAceptarFecha_Click(object sender, EventArgs e)
        {

        }
    }
}


