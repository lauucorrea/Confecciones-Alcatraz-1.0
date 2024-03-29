using Entidades;
using System.Data;
using System.Globalization;
using Vista;

namespace VistaConfeccion
{
    public partial class FrmMain : Form
    {

        private Persona PersonaLogueada;

        public FrmMain(Persona personaLogueada)
        {
            InitializeComponent();
            if (personaLogueada is not null)
            {
                PersonaLogueada = personaLogueada;
            }
        }
        private void FrmConfecciones_Load(object sender, EventArgs e)
        {
            if (PersonaLogueada.RolPersona.ToString() != "Propietario" && PersonaLogueada.RolPersona.ToString() != "Administrador")
            {
                // Ocultar el elemento del men�
                TsmiReportes.Visible = false; // Reemplaza "toolStripMenuItem1" con el nombre de tu elemento
            }
            CrearDatagridCortes_General(GestionDatos.CortesSistema.Select(c => c).OrderBy(c => c.FechaInicio).ToList());
            //CrearCalendario();
            this.ControlBox = false;
            FrmCalendario registro = new(PersonaLogueada);
            if (registro.ShowDialog() != DialogResult.OK)
            {
                registro.Close();
            }

        }

        //Analizar prox pero hay que insertar columna por columna en vez de fila por fila (proviene de frmCalendario)
        /*
          int index = 0;

        foreach (string nombreDia in nombresDiasSemana)
        {
        string nombreColumna = $"ColumnaFecha{index}";
        DtgCalendario.Columns.Add(nombreColumna, nombreDia);

        index++;
        }



        DataGridViewRow row = new();
        //genero contenido 

        DataGridViewTextBoxCell celda = new();
        //cargo de contenido la celda
        celda.Value = sb.ToString();
        //cargo tag
        celda.Tag = diaActualizado.Date;

        //agrego todo cargado a la celda
        row.Cells.Add(celda);
        DtgCalendario.Rows.Insert(index, row);
        */

        public void CrearCalendario()
        {
            DtgMuestreoMain.DataSource = null;
            DtgMuestreoMain.Columns.Clear();

            // Obt�n la fecha y hora actual
            DateTime horaCierre = DateTime.Now.Date + PersonaLogueada.HorarioCierre;


            // Obt�n los d�as laborales siguientes
            DateTime fechaActual = DateTime.Today;

            SortedDictionary<DateTime, string> diasLaboralesProximos = ObtenerDiasLaborales(fechaActual, PersonaLogueada, DtgMuestreoMain);

            if (PersonaLogueada.DiasLaborales is not null)
            {

                // Obt�n la cantidad de horas de trabajo
                TimeSpan horasJornada = PersonaLogueada.HorarioCierre - PersonaLogueada.HorarioApertura; // Ejemplo: 8 horas
                PersonaLogueada.HorasJornada = (int)horasJornada.TotalHours;

                Dictionary<DateTime, List<Corte>> cortesAgregados = new();

                decimal horasRestantesCorte;
                decimal horasRestantesDia;
                List<Corte> cortesParaAgregar = new();



                //Idear algo distinto pero va por aca
                //Separar en distintos metodos
                foreach (KeyValuePair<DateTime, string> kvp in diasLaboralesProximos)
                {
                    List<Corte> cortesEnFecha = Administracion.ObtenerCortesPorFecha(kvp.Key);
                    DateTime horaActual = kvp.Key + PersonaLogueada.HorarioApertura;

                    foreach (Corte corte in cortesEnFecha)
                    {
                        horasRestantesCorte = corte.HorasTotalesCorte - PersonaLogueada.HorasJornada;
                        horasRestantesDia = PersonaLogueada.HorasJornada - corte.HorasTotalesCorte;

                        if (horasRestantesCorte <= 0 && horasRestantesDia > 0)
                        {
                            cortesParaAgregar.Add(corte);
                            cortesAgregados.Add(horaActual.Date, cortesParaAgregar);
                            continue;
                        }
                        else if (horasRestantesCorte > 0 && horasRestantesDia <= 0)
                        {
                            horaActual.AddDays(1);
                            horaActual = horaActual.Date + PersonaLogueada.HorarioApertura;
                        }


                    }
                }


            }
            else
            {
                throw new NullReferenceException("No hay dias validos cargados en el sistema.");

            }
            // Asigna la tabla de datos al DataGridView

        }

        private static SortedDictionary<DateTime, string> ObtenerDiasLaborales(DateTime fechaActual, Persona PersonaJornada, DataGridView tabla)
        {
            SortedDictionary<DateTime, string> ListaDiasLaborales = new();
            CultureInfo cultura = new("es-ES");
            string diaSemana;

            int diasAgregados = 0;
            while (diasAgregados < 7)
            {
                fechaActual = fechaActual.AddDays(1);
                diaSemana = cultura.DateTimeFormat.GetDayName(fechaActual.DayOfWeek);
                diaSemana = cultura.TextInfo.ToTitleCase(diaSemana);
                if (PersonaJornada.DiasLaborales.Contains(diaSemana) && !Administracion.EsDiaFeriado(fechaActual))
                {

                    diaSemana = $"{diaSemana} {fechaActual.Day}/{fechaActual.Month}";
                    ListaDiasLaborales.Add(fechaActual, diaSemana);
                    diasAgregados++;

                    string nombreColumna = $"ColumnaFecha{diasAgregados}";
                    tabla.Columns.Add(nombreColumna, diaSemana);
                }
            }

            return ListaDiasLaborales;

        }

        private void GestionarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AgregToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MostrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void AgregarPrendaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void MostrarPrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatagridPrendasSistema();
        }

        private void CrearNuevoCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaCorte altaCortes = new(PersonaLogueada);
                if (altaCortes.ShowDialog() != DialogResult.OK)
                {
                    altaCortes.Close();
                    CrearCalendario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarCortesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearDatagridCortes_General(GestionDatos.CortesSistema.Select(c => c).OrderBy(c => c.FechaInicio).ToList());
        }

        private void OrdenarPorJerarquiaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void OrdenarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void OrdenarPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void OrdenarPorTalleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void OrdenarPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void OrdenarPorProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GestionDatos.PrendasSistema = GestionDatos.PrendasSistema.OrderBy(u => u.HorasParaCantidad).ToList();
                CargarDatagridPrendasSistema();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Corte> cortesOrdenados = GestionDatos.CortesSistema.Select(c => c).OrderBy(c => c.FechaInicio).ToList();
                CrearDatagridCortes_General(cortesOrdenados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PorFechaDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Corte> cortesOrdenados = GestionDatos.CortesSistema.Select(c => c).OrderBy(c => c.FechaFinal).ToList();
                CrearDatagridCortes_General(cortesOrdenados);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PorEtapaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void PorTiempoDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Corte> cortesOrdenados = GestionDatos.CortesSistema.Select(c => c).OrderBy(c => c.HorasTotalesCorte).ToList();
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
            DtgMuestreoMain.Columns.Add("ColumnaPrendas", "Prendas en corte");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Corte corte in lista)
            {

                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgMuestreoMain);
                fila.Cells[0].Value = corte.IdentificadorDeCorte;
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
                fila.Cells[5].Value = corte.PrendasEnCorte.Count;

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
                fila.Cells[2].Value = prenda.CantidadEnHoras; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[3].Value = prenda.HorasParaCantidad; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[4].Value = prenda.PrendasHora; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[5].Value = prenda.Detalles; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[6].Value = prenda.Distintivo; // Suponiendo que Prenda tiene una propiedad "Cantidad"

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
            DtgMuestreoMain.Columns.Add("ColumnaEtapaTizando", "Pendiente");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaTizando", "Tizando");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaEncimando", "Encimando");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaCortando", "Cortando");
            DtgMuestreoMain.Columns.Add("ColumnaEtapaTerminando", "Terminando");
            DtgMuestreoMain.Columns.Add("ColumnaHorasProduccion", "Horas produccion");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Corte corte in GestionDatos.CortesSistema)
            {
                List<int> conteo = Administracion.ObtenerConteoDeEstado(GestionDatos.CortesSistema);

                DataGridViewRow fila = new();
                fila.CreateCells(DtgMuestreoMain);
                fila.Cells[0].Value = corte.IdentificadorDeCorte;
                fila.Cells[1].Value = corte.FechaInicio;
                fila.Cells[2].Value = corte.FechaFinal;
                fila.Cells[3].Value = corte.PrendasEnCorte.Count();
                fila.Cells[4].Value = conteo[0];
                fila.Cells[5].Value = conteo[1];
                fila.Cells[6].Value = conteo[2];
                fila.Cells[7].Value = conteo[3];
                fila.Cells[8].Value = conteo[4];
                fila.Cells[9].Value = corte.HorasTotalesCorte;
                DtgMuestreoMain.Rows.Add(fila);
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
            DtgMuestreoMain.Columns.Add("ColumnaTalleS", "Talle S");
            DtgMuestreoMain.Columns.Add("ColumnaTalleM", "Talle M");
            DtgMuestreoMain.Columns.Add("ColumnaTalleL", "Talle L");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXL", "Talle XL");
            DtgMuestreoMain.Columns.Add("ColumnaTalleXXL", "Talle XXL");
            DtgMuestreoMain.Columns.Add("ColumnaHorasProduccion", "Horas produccion");

            // Recorrer el diccionario y agregar filas al DataGridView

            foreach (Corte corte in GestionDatos.CortesSistema)
            {
                List<int> conteo = Administracion.ObtenerConteoDeTalles_Corte(corte);
                DataGridViewRow fila = new();
                fila.CreateCells(DtgMuestreoMain);
                fila.Cells[0].Value = corte.IdentificadorDeCorte;
                fila.Cells[1].Value = corte.FechaInicio;
                fila.Cells[2].Value = corte.FechaFinal;
                fila.Cells[3].Value = corte.PrendasEnCorte.Count();
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



        private void PorTallesDePrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarDatagridCortes_PorTalle();
        }

        private void ModificarJornadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                FrmEdicionJornada frmEdicion = new();

                if (frmEdicion.ShowDialog() != DialogResult.OK)
                {
                    frmEdicion.Close();
                }
                else
                {
                    frmEdicion.Close();
                    CrearCalendario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void tareaSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DtgMuestreoMain.DataSource = null;
            DtgMuestreoMain.Columns.Clear();
            CrearCalendario();
        }

    }
}