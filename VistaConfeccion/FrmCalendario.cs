using Entidades;
using System.Data;
using System.Text;

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
            DtgCalendario.RowTemplate.Height = 30;
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
            string[] nombresDiasSemana = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            DateTime diaActualizado = diaInicioActualizable.AddDays(-diaSemanaInicio); // Ajustar para empezar en el día de la semana correcto
                                                                                       // Agregar columnas al DataTable para cada día de la semana
            foreach (string nombreDia in nombresDiasSemana)
            {
                dataTable.Columns.Add(nombreDia, typeof(string));
            }

            while (diaActualizado <= ultimoDiaDelMes)
            {
                // Agregar filas al DataTable para cada semana del mes
                DataRow row = dataTable.NewRow();

                // Iterar sobre los días de la semana
                for (int i = 0; i < 7; i++)
                {
                    // Verificar si el día actual está dentro del mes
                    if (diaActualizado.Month == diaInicioActualizable.Month)
                    {
                        // Obtener los cortes correspondientes a la fecha actual
                        List<Corte> cortesEnFecha = Administracion.ObtenerCortesPorFecha(diaActualizado);
                        if (cortesEnFecha is not null && cortesEnFecha.Count > 0)
                        {
                            // Construir una cadena con los identificadores de los cortes
                            StringBuilder sb = new StringBuilder();
                            foreach (Corte corte in cortesEnFecha)
                            {
                                sb.Append($"{corte.IdentificadorDeConfeccion}");
                                if (cortesEnFecha.IndexOf(corte) != cortesEnFecha.Count - 1)
                                {
                                    sb.Append(", ");
                                }
                            }
                            // Eliminar la coma final y los espacios
                            row[i] = sb.ToString();
                        }
                        else
                        {
                            row[i] = diaActualizado.ToShortDateString();
                        }
                    }
                    else
                    {
                        row[i] = string.Empty; // Rellenar con una cadena vacía para los días fuera del mes
                    }

                    diaActualizado = diaActualizado.AddDays(1);
                }

                dataTable.Rows.Add(row);
            }

            DtgCalendario.DataSource = dataTable;
        }
    }
}


