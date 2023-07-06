using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCalendario : Form
    {
        Persona personaLogueada;
        public FrmCalendario(Persona persona)
        {
            InitializeComponent();
            personaLogueada = persona;
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            CreateDataGridView(personaLogueada.DiasLaborales);
            DtgCalendario.RowTemplate.Height = 30;
           // DtgCalendario.Dock = DockStyle.Fill;
        }

        private void CreateDataGridView(List<string> diasLaborales)
        {
            // Obtener la fecha y hora actual
            DateTime horaActual = DateTime.Now;

            // Crear una tabla de datos para el DataGridView
            DataTable dataTable = new DataTable();

            // Agregar la columna de horas
            dataTable.Columns.Add("Hora", typeof(string));

            // Agregar las columnas de fechas
            for (int i = 0; i < 7; i++)
            {
                DateTime fecha = horaActual.AddDays(i);
                dataTable.Columns.Add(fecha.ToString("dddd d"), typeof(string));
            }

            // Agregar las filas de horas
            for (int j = 0; j < 8; j++)
            {
                DateTime hora = horaActual.AddHours(j);
                DataRow row = dataTable.NewRow();
                row["Hora"] = hora.ToString("HH:mm", CultureInfo.InvariantCulture);

                for (int i = 0; i < 7; i++)
                {
                    DateTime fecha = horaActual.AddDays(i);
                    row[fecha.ToString("dddd d")] = fecha.ToString();
                }

                dataTable.Rows.Add(row);
            }

            // Asignar la tabla de datos al DataGridView
            DtgCalendario.DataSource = dataTable;
        }
    }
}
