using Entidades;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCalendario : Form
    {
        Persona PersonaLogueada;
        DateTime MesActual;
        DataTable Calendario;
        bool redimensionado = false;
        int AltoGrid = 0;
        int AltoGridInicial = 0;
        int AltoForm;
        int Diferencia;
        public FrmCalendario(Persona persona)
        {

            InitializeComponent();
            PersonaLogueada = persona;
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            MesActual = DateTime.Now;
            LblMesActual.Text = CultureInfo.GetCultureInfo("es-ES").DateTimeFormat.GetMonthName(MesActual.Month);
            CrearCalendario(MesActual);
            AutoScroll = false;
        }
        public void CrearCalendario(DateTime fecha)
        {
            DibujarFilas(fecha);
            AjustarAltosFilas(DtgCalendario, DtgCalendario.Height);
            RedimensionarForm();
            DtgCalendario.CellPainting += DtgCalendario_CellPainting;
        }


        public void DibujarFilas(DateTime fecha)
        {
            // Obtener el primer día del mes actual
            DateTime diaInicioActualizable = new DateTime(fecha.Year, fecha.Month, 1);
            // Obtener el día de la semana en el que empieza el mes
            int diaSemanaInicio = (int)diaInicioActualizable.DayOfWeek;
            // Obtener el último día del mes actual
            DateTime ultimoDiaDelMes = diaInicioActualizable.AddMonths(1).AddDays(-1);
            string[] nombresDiasSemana = { "Domingo","Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            DateTime diaActualizado = diaInicioActualizable.AddDays(-diaSemanaInicio);
            int index = 0;

            foreach (string nombreDia in nombresDiasSemana)
            {
                string nombreColumna = $"ColumnaFecha{index}";
                DtgCalendario.Columns.Add(nombreColumna, nombreDia);

                index++;
            }
            index = 0;
            while (diaActualizado <= ultimoDiaDelMes || diaActualizado.DayOfWeek != DayOfWeek.Sunday)
            {

                DataGridViewRow row = new();
                // Iterar sobre los días de la semana
                for (int i = 0; i < 7; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    // Verificar si el día actual está dentro del mes
                    // Obtener los cortes correspondientes a la fecha actual
                    List<Corte> cortesEnFecha = Administracion.ObtenerCortesPorFecha(diaActualizado);
                    if (cortesEnFecha is not null && cortesEnFecha.Count > 0)
                    {
                        // Construir una cadena con los identificadores de los cortes
                        foreach (Corte corte in cortesEnFecha)
                        {
                            sb.Append($"C{corte.IdentificadorDeCorte}\n");

                            //sb.Append(corte.ToString());
                            if (cortesEnFecha.IndexOf(corte) != cortesEnFecha.Count - 1)
                            {
                                sb.Append(", ");
                            }
                        }

                    }
                   
                    DataGridViewTextBoxCell celda = new();


                    celda.Value = sb.ToString();
                    celda.Tag = diaActualizado;
                    row.Cells.Add(celda);

                    diaActualizado = diaActualizado.AddDays(1);
                }
                DtgCalendario.Rows.Insert(index, row);
                index++;
            }
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

                    // Obtener el contenido original de la celda
                    string cellText = e.FormattedValue?.ToString();

                    // Vaciar el contenido de la celda
                    e.Paint(e.CellBounds, DataGridViewPaintParts.Background);

                    // Obtener el valor del tag de la celda (que contiene la fecha)
                    DateTime tagCeldaDateTime = (DateTime)DtgCalendario.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                    // Obtener el número del día (día del mes)
                    int numeroDelDia = tagCeldaDateTime.Day;

                    // Definir el texto para el contenido centrado
                    string centerText = cellText;

                    // Obtener las coordenadas para el texto centrado
                    float centerX = e.CellBounds.Left + (e.CellBounds.Width - e.Graphics.MeasureString(centerText, e.CellStyle.Font).Width) / 2;
                    float centerY = e.CellBounds.Top + (e.CellBounds.Height - e.Graphics.MeasureString(centerText, e.CellStyle.Font).Height) / 2;

                    Font customFont = new Font(e.CellStyle.Font.FontFamily, 16); // Tamaño de fuente 14 (ajusta el valor según tus necesidades)

                    // Establecer la fuente personalizada para el estilo de celda
                    e.CellStyle.Font = customFont;

                    // Dibujar el número del día en la esquina superior izquierda
                    e.Graphics.DrawString(numeroDelDia.ToString(), e.CellStyle.Font, Brushes.Black, e.CellBounds.Location);

                    // Dibujar el contenido centrado
                    e.Graphics.DrawString(centerText, e.CellStyle.Font, Brushes.Black, centerX, centerY);

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

            if (!redimensionado)
            {

                AltoForm = this.Height;
                AltoGrid = AltoGridInicial + DtgCalendario.ColumnHeadersHeight;

                foreach (DataGridViewRow row in DtgCalendario.Rows)
                {
                    AltoGrid += row.Height;
                }

                Diferencia = AltoGridInicial - AltoGrid;

                AltoForm -= Diferencia;
                this.Height = AltoForm;

                DtgCalendario.Height = AltoGrid;

                redimensionado = true;

            }
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
            DtgCalendario.Rows.Clear();
            DtgCalendario.Columns.Clear();
            Calendario = new();
            MesActual = MesActual.AddMonths(1);
            LblMesActual.Text = CultureInfo.GetCultureInfo("es-ES").DateTimeFormat.GetMonthName(MesActual.Month);
            CrearCalendario(MesActual);
            // DtgCalendario.CellPainting += DtgCalendario_CellPainting;
        }

        private void BtnMesAnterior_Click(object sender, EventArgs e)
        {
            DtgCalendario.Rows.Clear();
            DtgCalendario.Columns.Clear();
            Calendario = new();
            MesActual = MesActual.AddMonths(-1);
            LblMesActual.Text = CultureInfo.GetCultureInfo("es-ES").DateTimeFormat.GetMonthName(MesActual.Month);
            CrearCalendario(MesActual);
            //DtgCalendario.CellPainting += DtgCalendario_CellPainting;
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
                DialogResult = DialogResult.Cancel;
            }
        }

        private void BtnAceptarFecha_Click(object sender, EventArgs e)
        {

        }

        private void DtgCalendario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica que se haya hecho clic dentro de una celda válida
            {
                // Obtén el DataGridView desde el evento
                DataGridView dgv = sender as DataGridView;

                // Verifica si el DataGridView es válido y contiene celdas
                if (dgv != null && dgv.Rows.Count > 0 && dgv.Columns.Count > 0)
                {
                    // Obtén la celda seleccionada desde el DataGridView
                    DataGridViewCell celdaSeleccionada = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Verifica si la celda tiene un valor en su propiedad "Tag"
                    if (celdaSeleccionada.Tag != null)
                    {
                        // Obtén el valor del "Tag" de la celda como DateTime
                        DateTime tagCeldaDateTime = (DateTime)celdaSeleccionada.Tag;

                        //AgregarPrendasCalendario_Gestion(Administracion.ObtenerCortesPorFecha(tagCeldaDateTime));

                        List<Corte>? cortesEnFecha = Administracion.ObtenerCortesPorFecha(tagCeldaDateTime);

                        if (cortesEnFecha is not null)
                        {
                            FrmTareaDiaria frmTarea = new(cortesEnFecha, PersonaLogueada);
                            if (frmTarea.ShowDialog() != DialogResult.OK)
                            {
                                frmTarea.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("no hay prendas en esta fecha");
                        }
                    }
                    else
                    {
                        // La celda no tiene un valor válido en su propiedad "Tag" o no es del tipo DateTime
                        MessageBox.Show("La celda no tiene un valor válido en su Tag o no es del tipo DateTime.");
                    }
                }
            }
        }
        public List<Prenda>? ObtenerPrendasEnCalendario(DateTime fechaBusqueda)
        {
            List<Prenda>? listaPrendas = null;
            if (fechaBusqueda != DateTime.MinValue)
            {

                foreach (KeyValuePair<string, List<Prenda>> kvp in GestionDatos.CalendarioPrendasCorte)
                {
                    string fechaConvertida = fechaBusqueda.ToString("dd - MM - yyyy");

                    if (kvp.Key == fechaConvertida)
                    {
                        listaPrendas = kvp.Value;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("La fecha recibida no es valida");
            }
            return listaPrendas;
        }


    }
}


