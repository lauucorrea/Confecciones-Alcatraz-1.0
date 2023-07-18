using Entidades;
using Procesos;
using System.Text;

namespace Vista
{
    public partial class FrmAltaCorte : Form
    {
        DateTime fechaInicio;
        DateTime fechaFinal;
        Corte CorteCreado;
        List<DateTime> posiblesFechas;
        Prenda? PrendaSeleccionada;
        Persona PersonaLogueada;
        int cantidadHorasCorte;
        public FrmAltaCorte(Persona personaLogueada)
        {
            InitializeComponent();
            CorteCreado = new();
            PersonaLogueada = personaLogueada;
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            VaciarInformacion();
            const string mensaje = "Estas seguro de que queres cancelar? se perderan los datos no guardados";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clase_serializadora serializadora = new();
                //serializadora.GuardarPersonasXML();
                //serializadora.GuardarAvionesXML();
                DialogResult = DialogResult.Cancel;
            }

        }


        private void BtnCrearCorte_Click(object sender, EventArgs e)
        {
            try
            {
                if (GestionDatos.PrendasParaCortes is not null)
                {


                    posiblesFechas = EstimacionCortes.ObtenerFechasPosibles(PersonaLogueada.HorasJornada, GestionDatos.PrendasParaCortes);
                    posiblesFechas.Sort((fecha1, fecha2) => fecha1.CompareTo(fecha2));

                    CorteCreado = new(posiblesFechas[^1], posiblesFechas[0]);

                    if (CorteCreado is not null)
                    {
                        foreach (Prenda prenda in GestionDatos.PrendasParaCortes)
                        {
                            Administracion.AgregarPrenda_Corte(CorteCreado, prenda);
                        }
                        GestionDatos.CortesSistema.Add(CorteCreado);

                        FrmCalendario registro = new(PersonaLogueada);
                        if (registro.ShowDialog() != DialogResult.OK)
                        {
                            registro.Close();
                        }

                    }
                }
                else
                {
                    throw new Exception("Es necesario agregar prendas antes de crear el corte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void FrmAltaCorte_Load(object sender, EventArgs e)
        {

            string[] talles = Enum.GetNames(typeof(TallePrenda));
            CmbTalle.DataSource = talles;
            DtgPrendasSistema.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgPrendasConfeccion.AutoGenerateColumns = true;

            CargarDatagridPrendasSistema();


        }

        private void BtnAgregarPrenda_Click(object sender, EventArgs e)
        {
            try
            {

                if (DtgPrendasSistema.SelectedRows.Count != 0)
                {
                    PrendaSeleccionada = ObtenerPrendaSeleccionada();

                    if (PrendaSeleccionada is not null)
                    {
                        if (NumUnidades.Value > 0)
                        {

                            //Guardo el talle selecionado en la preconfeccion
                            TallePrenda[] talles = (TallePrenda[])Enum.GetValues(typeof(TallePrenda));
                            TallePrenda talle = talles[CmbTalle.SelectedIndex];

                            PrendaSeleccionada.UnidadesCorte = (int)NumUnidades.Value;
                            PrendaSeleccionada.TallePrenda = talle;

                            //Administracion.AgregarPrenda_Corte(CorteCreado, PrendaSeleccionada);
                            GestionDatos.PrendasParaCortes.Add(PrendaSeleccionada);
                            CargarDatagridPrendasCorte();

                        }
                        else
                        {
                            throw new Exception("Debes seleccionar al menos una prenda para continuar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DtgPrendasSistema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DtgPrendasSistema.Rows[e.RowIndex].Selected = true;
            }
        }
        private Prenda? ObtenerPrendaSeleccionada()
        {
            PrendaSeleccionada = null;
            if (DtgPrendasSistema.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DtgPrendasSistema.SelectedRows[0];
                string? categoriaPrenda = filaSeleccionada.Cells["ColumnaCategoria"].Value.ToString();

                if (filaSeleccionada is not null && !string.IsNullOrEmpty(categoriaPrenda))
                {

                    // Obtener los valores de las celdas
                    CategoriaPrenda categoria = (CategoriaPrenda)Enum.Parse(typeof(CategoriaPrenda), categoriaPrenda);
                    int cantidadPrendas = Convert.ToInt32(filaSeleccionada.Cells["ColumnaPrendas"].Value);
                    int horasProduccion = Convert.ToInt32(filaSeleccionada.Cells["ColumnaHoras"].Value);
                    string? detalle = filaSeleccionada.Cells["ColumnaDetalle"].Value.ToString();
                    string? adicionales = filaSeleccionada.Cells["ColumnaAdicionales"].Value.ToString();

                    // Crear una instancia de la prenda seleccionada
                    if (string.IsNullOrEmpty(detalle) && string.IsNullOrEmpty(adicionales))
                    {
                        PrendaSeleccionada = new Prenda(categoria, cantidadPrendas, horasProduccion);
                    }
                    else if (string.IsNullOrEmpty(adicionales) && !string.IsNullOrEmpty(detalle))
                    {
                        PrendaSeleccionada = new Prenda(categoria, cantidadPrendas, horasProduccion, detalle);
                    }
                    else if (!string.IsNullOrEmpty(adicionales))
                    {
                        PrendaSeleccionada = new Prenda(categoria, cantidadPrendas, horasProduccion, detalle, adicionales);
                    }
                }
                else
                {
                    throw new NullReferenceException("La prenda seleccionada no tiene categoria asignada");
                }

            }
            return PrendaSeleccionada;
        }
        private void CargarDatagridPrendasSistema()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasSistema.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasSistema.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgPrendasSistema.Columns.Add("ColumnaCategoria", "Categoria");
            DtgPrendasSistema.Columns.Add("ColumnaPrendas", "Unidades Produccion");
            DtgPrendasSistema.Columns.Add("ColumnaHoras", "Horas Produccion");
            DtgPrendasSistema.Columns.Add("ColumnaPrendasHora", "Promedio Prendas/Hora");
            DtgPrendasSistema.Columns.Add("ColumnaDetalle", "Detalle");
            DtgPrendasSistema.Columns.Add("ColumnaAdicionales", "Adicionales");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Prenda prenda in GestionDatos.PrendasSistema)
            {
                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgPrendasSistema);
                fila.Cells[0].Value = prenda.Categoria; // Suponiendo que Prenda tiene una propiedad "Nombre"
                fila.Cells[1].Value = prenda.CantidadEnHoras; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[2].Value = prenda.HorasParaCantidad; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[3].Value = prenda.PrendasHora; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[4].Value = prenda.Detalles; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[5].Value = prenda.Adicional; // Suponiendo que Prenda tiene una propiedad "Cantidad"

                // Agregar la fila al DataGridView
                DtgPrendasSistema.Rows.Add(fila);
            }
        }
        private void CargarDatagridPrendasCorte()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasConfeccion.DataSource = null; // Limpia el origen de datos
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasConfeccion.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgPrendasConfeccion.Columns.Add("ColumnaTipo", "Tipo");
            DtgPrendasConfeccion.Columns.Add("ColumnaDetallePrenda", "Detalle");
            DtgPrendasConfeccion.Columns.Add("ColumnaTalle", "Talle");
            DtgPrendasConfeccion.Columns.Add("ColumnaCantidadPrendas", "Cantidad de Prendas");
            DtgPrendasConfeccion.Columns.Add("ColumnaTiempoEstimadoHoras", "Tiempo Estimado (HS)");
            DtgPrendasConfeccion.Columns.Add("ColumnaTiempoEstimadoDias", "Tiempo Estimado (Dias)");

            // Recorrer el diccionario y agregar filas al DataGridView
            if (GestionDatos.PrendasParaCortes is not null && GestionDatos.PrendasParaCortes.Count > 0)
            {  // Crear una nueva fila y asignar los valores de las celdas
                foreach (Prenda prenda in GestionDatos.PrendasParaCortes)
                {
                    DataGridViewRow fila = new();
                    fila.CreateCells(DtgPrendasConfeccion);
                    fila.Cells[0].Value = prenda.Categoria;
                    fila.Cells[1].Value = prenda.Detalles;
                    fila.Cells[2].Value = prenda.TallePrenda;
                    fila.Cells[3].Value = prenda.UnidadesCorte;

                    //si la cantidad elegida, es igual al tiempo por hora, las prendas se hacen en una hora
                    if (NumUnidades.Value == PrendaSeleccionada.PrendasHora && prenda == PrendaSeleccionada)
                    {
                        prenda.HorasParaCantidad = PrendaSeleccionada.HorasParaCantidad;
                    }
                    fila.Cells[4].Value = Math.Round(prenda.TiempoFinalEtapa, 1);
                    fila.Cells[5].Value = Math.Round(prenda.TiempoFinalEtapa / 24, 1);
                    DtgPrendasConfeccion.Rows.Add(fila);
                }



            }
            else
            {
                throw new Exception("Debe cargar al menos una prenda");
            }
        }
        /*private void CargarDatagridConfeccionesConEntrega()
         {
             // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
             DtgFechasPrevistas.DataSource = null; // Limpia el origen de datos
             // Limpiar las columnas existentes en el DataGridView
             DtgFechasPrevistas.Columns.Clear();

             // Agregar las columnas necesarias al DataGridView
             DtgFechasPrevistas.Columns.Add("ColumnaId", "ID");
             DtgFechasPrevistas.Columns.Add("ColumnaPrendas", "Prendas");
             DtgFechasPrevistas.Columns.Add("ColumnaEntrega", "Fecha Entrega");
             DtgFechasPrevistas.Columns.Add("ColumnaInicio", "Fecha Inicio");
             DtgFechasPrevistas.Columns.Add("ColumnaTiempo", "Tiempo Estimado");

             if (GestionDatos.CortesConEntregas is not null)
             {

                 // Recorrer el diccionario y agregar filas al DataGridView
                 foreach (Corte confeccion in GestionDatos.CortesConEntregas)
                 {
                     // Crear una nueva fila y asignar los valores de las celdas
                     DataGridViewRow fila = new();
                     fila.CreateCells(DtgFechasPrevistas);
                     fila.Cells[0].Value = confeccion.IdentificadorDeConfeccion;
                     fila.Cells[1].Value = confeccion.PrendasEnConfeccion.Count;
                     fila.Cells[2].Value = confeccion.FechaFinal.ToShortDateString();
                     fila.Cells[3].Value = confeccion.FechaInicio.ToShortDateString();
                     fila.Cells[4].Value = cantidadHorasCorte;

                     // Agregar la fila al DataGridView
                     DtgFechasPrevistas.Rows.Add(fila);
                 }
             }
         }*/
        private void VaciarInformacion()
        {
            if (GestionDatos.PrendasParaCortes is not null && GestionDatos.PrendasParaCortes.Count > 0)
            {
                GestionDatos.PrendasParaCortes.Clear();
                CorteCreado = null;
                DtgPrendasConfeccion.DataSource = null;
                NumUnidades.Value = 1;
            }
        }

        private void DtgPrendasSistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar? Se perderan los cambios sin guardar";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Clase_serializadora serializadora = new();
                //serializadora.GuardarPersonasXML();
                //serializadora.GuardarAvionesXML();
                Application.Exit();
            }
        }
    }
}
