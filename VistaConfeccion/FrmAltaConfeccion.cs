using Entidades;
using Procesos;

namespace VistaConfeccion
{
    public partial class FrmAltaConfeccion : Form
    {
        DateTime fechaInicio;
        DateTime fechaFinal;
        Confeccion PreConfeccion;
        int cantidadDiasConfeccion;
        public FrmAltaConfeccion()
        {
            InitializeComponent();
        }

        private void BtnAgregarConfeccion_Click(object sender, EventArgs e)
        {

            if (PreConfeccion != null && GestionDatos.PrendasParaConfeccion is not null)
            {
                fechaInicio = McFechaEntrega.SelectionStart;
                cantidadDiasConfeccion = EstimacionConfecciones.CalcularTiempoConfeccion(GestionDatos.PrendasParaConfeccion, Convert.ToInt32(NumUnidades.Value), 8);
                if (cantidadDiasConfeccion != -1)
                {
                    fechaFinal = fechaInicio.AddDays(cantidadDiasConfeccion);
                    GestionDatos.ConfeccionesConEntregas = ControlConfecciones.ObtenerEntregasEnDias(fechaInicio, cantidadDiasConfeccion);
                    if (GestionDatos.ConfeccionesConEntregas is not null)
                    {
                        CargarDatagridConfeccionesConEntrega(cantidadDiasConfeccion);
                    }
                    McFechaEntrega.SelectionEnd = fechaFinal;
                    MessageBox.Show(cantidadDiasConfeccion.ToString());
                }
                else
                {
                    LblErrores.Text = "Error al crear esta confeccion. no se pudo calcular el tiempo";
                }
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

            //TEMPORALMENTE HARDCODE
            //GestionDatos.PrendasSistema.Clear();
            Prenda prenda1 = new(CategoriaPrenda.Pantalon, 200);
            Prenda prenda2 = new(CategoriaPrenda.Remera, 500, "azul oscuro", "listo para la fecha");
            if (!GestionDatos.PrendasSistema.Contains(prenda1) && !GestionDatos.PrendasSistema.Contains(prenda2))
            {
                GestionDatos.PrendasSistema.Add(prenda1);
                GestionDatos.PrendasSistema.Add(prenda2);

            }


            Confeccion con = new(TallePrenda.XXL, CondicionEntrega.Procesando, new DateTime(2023, 5, 25), new DateTime(2023, 5, 10));
            List<Confeccion> lConfe = new();
            DateTime dt = new(2023, 5, 25);
            con.PrendasEnConfeccion.Add(prenda1);
            
            lConfe.Add(con);
            GestionDatos.ConfeccionesPorFecha.Clear();
            GestionDatos.ConfeccionesPorFecha.Add(dt, lConfe);


            CargarDatagridPrendasSistema();


        }

        private void BtnAgregarPrenda_Click(object sender, EventArgs e)
        {
            try
            {

                if (DtgPrendasSistema.SelectedRows.Count != 0)
                {
                    Prenda? prendaSeleccionada = ObtenerPrendaSeleccionada();

                    if (prendaSeleccionada is not null && !GestionDatos.PrendasParaConfeccion.ContainsKey(prendaSeleccionada))
                    {
                        //Guardo el talle selecionado en la preconfeccion
                        TallePrenda[] talles = (TallePrenda[])Enum.GetValues(typeof(TallePrenda));
                        TallePrenda talle = talles[CmbTalle.SelectedIndex];

                        //Agrego la prenda a la lista de prendas guardada en al clase estatica GestionDatos
                        GestionDatos.PrendasParaConfeccion.Add(prendaSeleccionada, talle);
                        //Recargo la lista de prendas al datagrid

                        CargarDatagridPrendasConfeccion();

                        //Creo la preconfeccion
                        if (PreConfeccion is not null && PreConfeccion.PrendasEnConfeccion.Count != 0)
                        {
                            PreConfeccion.PrendasEnConfeccion.Add(prendaSeleccionada);
                        }
                        else
                        {
                            PreConfeccion = new(talle, CondicionEntrega.Programado);
                        }

                        if (PreConfeccion is null)
                        {
                            throw new NullReferenceException("Hubo un problema en la creacion de la preconfeccion");
                        }
                    }
                    else
                    {
                        throw new Exception("La prenda ya existe en las prendas de confeccion");
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

        private void McFechaEntrega_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {

                if (PreConfeccion is not null && GestionDatos.PrendasParaConfeccion is not null)
                {
                    PreConfeccion.FechaInicio = McFechaEntrega.SelectionRange.Start;
                }
                else
                {
                    throw new NullReferenceException("Primero debe cargar prendas a la confeccion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void McFechaEntrega_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (GestionDatos.PrendasParaConfeccion is not null && GestionDatos.PrendasParaConfeccion.Count > 0)
            {
                fechaInicio = fechaInicio.AddDays(cantidadDiasConfeccion);
                fechaFinal = fechaInicio.AddDays(cantidadDiasConfeccion);
                McFechaEntrega.SelectionRange.End = fechaFinal;
            }
        }

        private Prenda? ObtenerPrendaSeleccionada()
        {
            Prenda? prendaSeleccionada = null;
            if (DtgPrendasSistema.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DtgPrendasSistema.SelectedRows[0];
                string? categoriaPrenda = filaSeleccionada.Cells["ColumnaCategoria"].Value.ToString();

                if (filaSeleccionada is not null && !string.IsNullOrEmpty(categoriaPrenda))
                {

                    // Obtener los valores de las celdas
                    CategoriaPrenda categoria = (CategoriaPrenda)Enum.Parse(typeof(CategoriaPrenda), categoriaPrenda);
                    int prendasHora = Convert.ToInt32(filaSeleccionada.Cells["ColumnaPrendasHora"].Value);
                    string? detalle = filaSeleccionada.Cells["ColumnaDetalle"].Value.ToString();
                    string? adicionales = filaSeleccionada.Cells["ColumnaAdicionales"].Value.ToString();

                    // Crear una instancia de la prenda seleccionada
                    if (string.IsNullOrEmpty(detalle) && string.IsNullOrEmpty(adicionales))
                    {
                        prendaSeleccionada = new Prenda(categoria, prendasHora);
                    }
                    else if (string.IsNullOrEmpty(adicionales) && !string.IsNullOrEmpty(detalle))
                    {
                        prendaSeleccionada = new Prenda(categoria, prendasHora, detalle);
                    }
                    else if (!string.IsNullOrEmpty(adicionales))
                    {
                        prendaSeleccionada = new Prenda(categoria, prendasHora, detalle, adicionales);
                    }
                }
                else
                {
                    throw new NullReferenceException("La prenda seleccionada no tiene categoria asignada");
                }

            }
            return prendaSeleccionada;
        }
        private void CargarDatagridPrendasSistema()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasSistema.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasSistema.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgPrendasSistema.Columns.Add("ColumnaCategoria", "Categoria");
            DtgPrendasSistema.Columns.Add("ColumnaPrendasHora", "PrendasHora");
            DtgPrendasSistema.Columns.Add("ColumnaDetalle", "Detalle");
            DtgPrendasSistema.Columns.Add("ColumnaAdicionales", "Adicionales");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Prenda prenda in GestionDatos.PrendasSistema)
            {
                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgPrendasSistema);
                fila.Cells[0].Value = prenda.Categoria; // Suponiendo que Prenda tiene una propiedad "Nombre"
                fila.Cells[1].Value = prenda.PrendasHora; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[3].Value = prenda.Detalles; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[2].Value = prenda.Adicional; // Suponiendo que Prenda tiene una propiedad "Cantidad"

                // Agregar la fila al DataGridView
                DtgPrendasSistema.Rows.Add(fila);
            }
        }
        private void CargarDatagridPrendasConfeccion()
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

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (KeyValuePair<Prenda, TallePrenda> par in GestionDatos.PrendasParaConfeccion)
            {
                Prenda prenda = par.Key;
                TallePrenda talle = par.Value;

                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(DtgPrendasConfeccion);
                fila.Cells[0].Value = prenda.Categoria; // Suponiendo que Prenda tiene una propiedad "Nombre"
                fila.Cells[1].Value = prenda.Detalles; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[2].Value = talle; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[3].Value = NumUnidades.Value; // Suponiendo que Prenda tiene una propiedad "Cantidad"

                // Agregar la fila al DataGridView
                DtgPrendasConfeccion.Rows.Add(fila);
            }
        }
        private void CargarDatagridConfeccionesConEntrega(int cantidadDiasProduccion)
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

            if (GestionDatos.ConfeccionesConEntregas is not null)
            {

                // Recorrer el diccionario y agregar filas al DataGridView
                foreach (Confeccion confeccion in GestionDatos.ConfeccionesConEntregas)
                {
                    // Crear una nueva fila y asignar los valores de las celdas
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(DtgFechasPrevistas);
                    fila.Cells[0].Value = confeccion.IdentificadorDeConfeccion;
                    fila.Cells[1].Value = confeccion.PrendasEnConfeccion.Count;
                    fila.Cells[2].Value = confeccion.FechaFinal.ToShortDateString();
                    fila.Cells[3].Value = confeccion.FechaInicio.ToShortDateString();
                    fila.Cells[4].Value = cantidadDiasConfeccion; 

                    // Agregar la fila al DataGridView
                    DtgFechasPrevistas.Rows.Add(fila);
                }
            }
        }
        private void VaciarInformacion()
        {
            if (GestionDatos.PrendasParaConfeccion is not null && GestionDatos.PrendasParaConfeccion.Count > 0)
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
