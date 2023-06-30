using Entidades;
using System.Data;
using System.Globalization;
using System.Text;
using Vista;

namespace VistaConfeccion
{
    public partial class FrmMain : Form
    {
        private TimeSpan horarioApertura;
        private TimeSpan horarioCierre;
        private Persona PersonaLogueada;

        public FrmMain(Persona personaLogueada)
        {
            InitializeComponent();
            if (personaLogueada is not null)
            {
                PersonaLogueada = personaLogueada;
                horarioApertura = new(9, 0, 0); // Ejemplo: 9:00 AM
                horarioCierre = new(17, 0, 0); // Ejemplo: 5:00 PM
            }
        }
        private void FrmConfecciones_Load(object sender, EventArgs e)
        {
            //CrearDatagridCortes_General(GestionDatos.CortesPorFecha.Values.SelectMany(c => c).OrderBy(c => c.FechaInicio).ToList());
            CrearCalendario();
            DtgMuestreoMain.RowTemplate.Height = 30;
           
        }

        public void CrearCalendario()
        {
            // Obtén la fecha y hora actual
            DateTime horaActual = DateTime.Now;

            // Crea una tabla de datos para el DataGridView
            DataTable dataTable = new DataTable();

            // Agrega la columna de horas
            dataTable.Columns.Add("Hora", typeof(string));

            // Obtén los días laborales siguientes
            DateTime fechaActual = DateTime.Today;
            List<string> diasLaboralesSiguientes = new();

            SortedDictionary<DateTime, string> diasLaboralesProximos = new();

            if (GestionDatos.DiasLaborales is not null)
            {
                CultureInfo cultura = new("es-ES");
                string diaSemana;

                int diasAgregados = 0;
                while (diasAgregados < 7)
                {
                    fechaActual = fechaActual.AddDays(1);
                    diaSemana = cultura.DateTimeFormat.GetDayName(fechaActual.DayOfWeek);
                    diaSemana = cultura.TextInfo.ToTitleCase(diaSemana);

                    if (GestionDatos.DiasLaborales.Contains(diaSemana))
                    {
                        diaSemana = $"{diaSemana} {fechaActual.Day}/{fechaActual.Month}";
                        diasLaboralesProximos.Add(fechaActual, diaSemana);
                        diasAgregados++;
                    }
                }

                // Agrega las columnas de fechas

                foreach (KeyValuePair<DateTime, string> kvp in diasLaboralesProximos)
                {
                    dataTable.Columns.Add(kvp.Value, typeof(string));
                }

                // Obtén la cantidad de horas de trabajo
                TimeSpan horasJornada = horarioCierre - horarioApertura; // Ejemplo: 8 horas

                // Agrega las filas de horas
                for (int j = 0; j < (int)horasJornada.TotalHours; j++)
                {
                    DataRow row = dataTable.NewRow();
                    row["Hora"] = horaActual.ToString("HH:mm", CultureInfo.InvariantCulture);

                    foreach (KeyValuePair<DateTime, string> kvp in diasLaboralesProximos)
                    {
                        List<Corte> listaCortesFecha = Administracion.ObtenerCorte_Diccionario(kvp.Key);


                        StringBuilder sb = new();
                        foreach (Corte corte in listaCortesFecha)
                        {
                            sb.AppendLine(corte.IdentificadorDeConfeccion + " ");
                        }
                        row[kvp.Value] = sb.ToString();
                        horaActual = horaActual.AddHours(1); // Avanza una hora

                    }
                    dataTable.Rows.Add(row);

                }
                DtgMuestreoMain.DataSource = dataTable;
            }
            else
            {
                throw new NullReferenceException("No hay dias validos cargados en el sistema.");

            }
            // Asigna la tabla de datos al DataGridView

        }

        private void gestionarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegistro registro = new();
                if (registro.ShowDialog() != DialogResult.OK)
                {
                    registro.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CrearDatagridUsuarios_General();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void agregarPrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaPrenda altaPrenda = new();
                if (altaPrenda.ShowDialog() != DialogResult.OK)
                {
                    altaPrenda.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrarPrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatagridPrendasSistema();
        }

        private void crearNuevoCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaCortes altaCortes = new();
                if (altaCortes.ShowDialog() != DialogResult.OK)
                {
                    altaCortes.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrarCortesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearDatagridCortes_General(GestionDatos.CortesPorFecha.Values.SelectMany(c => c).OrderBy(c => c.FechaInicio).ToList());
        }

        private void ordenarPorJerarquiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDatos.PersonasSistema = GestionDatos.PersonasSistema.OrderBy(u =>
            {
                if (u.RolPersona == Rol.Empleado)
                    return 0;
                if (u.RolPersona == Rol.Administrador)
                    return 1;
                if (u.RolPersona == Rol.Propietario)
                    return 2;
                return 3;
            }).ToList();

            CrearDatagridUsuarios_General();
        }

        private void ordenarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                GestionDatos.PersonasSistema = GestionDatos.PersonasSistema.OrderBy(u => u.Nombre).ToList();
                CrearDatagridUsuarios_General();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordenarPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                GestionDatos.PersonasSistema = GestionDatos.PersonasSistema.OrderBy(u => u.Dni).ToList();
                CrearDatagridUsuarios_General();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordenarPorTalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatagridPrendasSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordenarPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                GestionDatos.PrendasSistema = GestionDatos.PrendasSistema.OrderBy(u => u.Categoria).ToList();
                CargarDatagridPrendasSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ordenarPorProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GestionDatos.PrendasSistema = GestionDatos.PrendasSistema.OrderBy(u => u.HorasProduccion).ToList();
                CargarDatagridPrendasSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Corte> cortesOrdenados = GestionDatos.CortesPorFecha.Values.SelectMany(c => c).OrderBy(c => c.FechaInicio).ToList();
                CrearDatagridCortes_General(cortesOrdenados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void porFechaDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Corte> cortesOrdenados = GestionDatos.CortesPorFecha.Values.SelectMany(c => c).OrderBy(c => c.FechaFinal).ToList();
                CrearDatagridCortes_General(cortesOrdenados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void porEtapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatagridCortes_PorEtapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void porTiempoDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Corte> cortesOrdenados = GestionDatos.CortesPorFecha.Values.SelectMany(c => c).OrderBy(c => c.HorasTotalesCorte).ToList();
                CrearDatagridCortes_General(cortesOrdenados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CrearDatagridUsuarios_General()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgMuestreoMain.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgMuestreoMain.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgMuestreoMain.Columns.Add("ColumnaNombre", "Nombre");
            DtgMuestreoMain.Columns.Add("ColumnaApellido", "Apellido");
            DtgMuestreoMain.Columns.Add("ColumnaDni", "DNI");
            DtgMuestreoMain.Columns.Add("ColumnaUsuario", "Nombre de usuario");
            DtgMuestreoMain.Columns.Add("ColumnaRol", "Rol usuario");
            DtgMuestreoMain.Columns.Add("ColumnaJornada", "Horas jornada");

            foreach (Persona persona in GestionDatos.PersonasSistema)
            {

                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgMuestreoMain);
                fila.Cells[0].Value = persona.Nombre;
                fila.Cells[1].Value = persona.Apellido;
                fila.Cells[2].Value = persona.Dni;
                fila.Cells[3].Value = persona.Usuario;
                fila.Cells[4].Value = persona.RolPersona;
                fila.Cells[5].Value = persona.HorasJornada;
                // Agregar la fila al DataGridView
                DtgMuestreoMain.Rows.Add(fila);
            }

        }

        private void CrearDatagridCortes_General(List<Corte> lista)
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgMuestreoMain.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgMuestreoMain.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgMuestreoMain.Columns.Add("ColumnaID", "ID Corte");
            DtgMuestreoMain.Columns.Add("ColumnaFechaInicio", "Fecha Inicio");
            DtgMuestreoMain.Columns.Add("ColumnaFechaFin", "Fecha Fin");
            DtgMuestreoMain.Columns.Add("ColumnaDuracionHs", "Horas Produccion");
            DtgMuestreoMain.Columns.Add("ColumnaDuracionDias", "Dias Produccion");
            DtgMuestreoMain.Columns.Add("ColumnaEtapa", "Etapa");
            DtgMuestreoMain.Columns.Add("ColumnaPrendas", "Prendas en corte");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Corte corte in lista)
            {

                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgMuestreoMain);
                fila.Cells[0].Value = corte.IdentificadorDeConfeccion;
                if (corte.FechaInicio <= DateTime.Now.Date && corte.FechaFinal >= DateTime.Now.Date)
                {
                    fila.Cells[1].Value = "HOY";
                }
                else
                {

                    fila.Cells[1].Value = corte.FechaInicio.ToShortDateString();
                }
                fila.Cells[2].Value = corte.FechaFinal.ToShortDateString();
                fila.Cells[3].Value = corte.HorasTotalesCorte;
                fila.Cells[4].Value = corte.HorasTotalesCorte / PersonaLogueada.HorasJornada;
                fila.Cells[5].Value = corte.Etapa;
                fila.Cells[6].Value = corte.PrendasEnConfeccion.Count;

                // Agregar la fila al DataGridView
                DtgMuestreoMain.Rows.Add(fila);

            }
        }
        private void CargarDatagridPrendasSistema()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgMuestreoMain.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgMuestreoMain.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgMuestreoMain.Columns.Add("ColumnaCategoria", "Categoria");
            DtgMuestreoMain.Columns.Add("ColumnaTalle", "Talle");
            DtgMuestreoMain.Columns.Add("ColumnaPrendas", "Unidades Produccion");
            DtgMuestreoMain.Columns.Add("ColumnaHoras", "Horas Produccion");
            DtgMuestreoMain.Columns.Add("ColumnaPrendasHora", "Promedio Prendas/Hora");
            DtgMuestreoMain.Columns.Add("ColumnaDetalle", "Detalle");
            DtgMuestreoMain.Columns.Add("ColumnaAdicionales", "Adicionales");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Prenda prenda in GestionDatos.PrendasSistema)
            {
                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgMuestreoMain);
                fila.Cells[0].Value = prenda.Categoria; // Suponiendo que Prenda tiene una propiedad "Nombre"
                fila.Cells[1].Value = prenda.TallePrenda;
                fila.Cells[2].Value = prenda.CantidadPrendas; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[3].Value = prenda.HorasProduccion; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[4].Value = prenda.PrendasHora; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[5].Value = prenda.Detalles; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[6].Value = prenda.Adicional; // Suponiendo que Prenda tiene una propiedad "Cantidad"

                // Agregar la fila al DataGridView
                DtgMuestreoMain.Rows.Add(fila);
            }
        }
        private void CargarDatagridCortes_PorEtapa()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgMuestreoMain.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgMuestreoMain.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgMuestreoMain.Columns.Add("ColumnaID", "ID Corte");
            DtgMuestreoMain.Columns.Add("ColumnaFechaInicio", "Fecha inicio");
            DtgMuestreoMain.Columns.Add("ColumnaFechaFin", "Fecha fin");
            DtgMuestreoMain.Columns.Add("ColumnaTotalPrendas", "Cantidad prendas");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaTizando", "Tizando");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaEncimando", "Encimando");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaCortando", "Cortando");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaTerminando", "Terminando");
            DtgMuestreoMain.Columns.Add("ColumnaHorasProduccion", "Horas produccion");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
            {
                foreach (Corte corte in par.Value)
                {
                    List<int> conteo = Administracion.ObtenerConteoDeEstado(par.Value);
                    DataGridViewRow fila = new();
                    fila.CreateCells(DtgMuestreoMain);
                    fila.Cells[0].Value = corte.IdentificadorDeConfeccion;
                    fila.Cells[1].Value = corte.FechaInicio;
                    fila.Cells[2].Value = par.Key;
                    fila.Cells[3].Value = corte.PrendasEnConfeccion.Count();
                    fila.Cells[4].Value = conteo[0];
                    fila.Cells[5].Value = conteo[1];
                    fila.Cells[6].Value = conteo[2];
                    fila.Cells[7].Value = conteo[3];
                    fila.Cells[8].Value = corte.HorasTotalesCorte;
                    DtgMuestreoMain.Rows.Add(fila);
                }


            }
        }

        private void CargarDatagridCortes_PorTalle()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgMuestreoMain.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgMuestreoMain.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgMuestreoMain.Columns.Add("ColumnaID", "ID Corte");
            DtgMuestreoMain.Columns.Add("ColumnaFechaInicio", "Fecha inicio");
            DtgMuestreoMain.Columns.Add("ColumnaFechaFin", "Fecha fin");
            DtgMuestreoMain.Columns.Add("ColumnaTotalPrendas", "Cantidad prendas");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXS", "Talle XS");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXS", "Talle S");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXS", "Talle M");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXS", "Talle L");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXS", "Talle XL");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXS", "Talle XXL");
            DtgMuestreoMain.Columns.Add("ColumnaHorasProduccion", "Horas produccion");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
            {
                foreach (Corte corte in par.Value)
                {
                    List<int> conteo = Administracion.ObtenerConteoDeTalles(corte);
                    DataGridViewRow fila = new();
                    fila.CreateCells(DtgMuestreoMain);
                    fila.Cells[0].Value = corte.IdentificadorDeConfeccion;
                    fila.Cells[1].Value = corte.FechaInicio;
                    fila.Cells[2].Value = par.Key;
                    fila.Cells[3].Value = corte.PrendasEnConfeccion.Count();
                    fila.Cells[4].Value = conteo[0];
                    fila.Cells[5].Value = conteo[1];
                    fila.Cells[6].Value = conteo[2];
                    fila.Cells[7].Value = conteo[3];
                    fila.Cells[8].Value = conteo[4];
                    fila.Cells[9].Value = conteo[5];
                    fila.Cells[10].Value = corte.HorasTotalesCorte;
                    DtgMuestreoMain.Rows.Add(fila);
                }

            }
        }



        private void porTallesDePrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatagridCortes_PorTalle();
        }

        private void modificarJornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmEdicionJornada frmEdicion = new();

                if (frmEdicion.ShowDialog() != DialogResult.OK)
                {
                    frmEdicion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}