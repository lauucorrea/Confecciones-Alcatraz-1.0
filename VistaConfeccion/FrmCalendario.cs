using Entidades;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCalendario : Form
    {
        Persona PersonaLogueada;
        public FrmCalendario(Persona persona)
        {
            InitializeComponent();
            PersonaLogueada = persona;
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            CrearCalendario();
            AutoScroll = false;
            // DtgCalendario.Dock = DockStyle.Fill;
        }


        public void CrearCalendario()
        {
            DataTable dataTable = new DataTable();
            // Obtener el primer día del mes actual
            DateTime diaInicioActualizable = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            // Obtener el día de la semana en el que empieza el mes
            int diaSemanaInicio = (int)diaInicioActualizable.DayOfWeek;
            // Obtener el último día del mes actual
            DateTime ultimoDiaDelMes = diaInicioActualizable.AddMonths(1).AddDays(-1);
            string[] nombresDiasSemana = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
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
                    // Verificar si el día actual está dentro del mes
                    if (diaActualizado.Month == diaInicioActualizable.Month || diaActualizado.DayOfWeek == DayOfWeek.Sunday)
                    {
                        // Obtener los cortes correspondientes a la fecha actual
                        List<Corte> cortesEnFecha = Administracion.ObtenerCortesPorFecha(diaActualizado);
                        if (cortesEnFecha is not null && cortesEnFecha.Count > 0)
                        {
                            // Construir una cadena con los identificadores de los cortes
                            StringBuilder sb = new StringBuilder();
                            foreach (Corte corte in cortesEnFecha)
                            {
                                if(cortesEnFecha.IndexOf(corte) == 0)
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

                            sb.AppendLine($"\n Fecha: {diaActualizado.Day}/{diaActualizado.Month}");
                            // Eliminar la coma final y los espacios
                            row[i] = sb.ToString();
                        }
                        else
                        {
                            row[i] = $" Fecha: {diaActualizado.Day}/{diaActualizado.Month}"; // Mostrar la numeración del día
                        }
                    }
                    else
                    {
                        row[i] = $" Fecha fuera mes: {diaActualizado.Day}/{diaActualizado.Month}"; // Mostrar la fecha del día correspondiente a otro mes
                    }

                    diaActualizado = diaActualizado.AddDays(1);
                }

                dataTable.Rows.Add(row);
            }

            DtgCalendario.DataSource = dataTable;
            AjustarAltosFilas(DtgCalendario, DtgCalendario.Height);
            RedimencionarForm();
            DtgCalendario.CellPainting += DtgCalendario_CellPainting;
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
                DataGridViewCellStyle style = new DataGridViewCellStyle();
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
        /// <summary>
        /// Redimensiona la ventana del formulario para que se adapte al contenido del mismo
        /// </summary>
        private void RedimencionarForm()
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
    }
}


