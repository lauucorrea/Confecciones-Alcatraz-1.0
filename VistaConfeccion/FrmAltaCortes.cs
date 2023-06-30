using Entidades;
using Procesos;
using Vista;

namespace VistaConfeccion
{
    public partial class FrmAltaCortes : Form
    {
        DateTime fechaInicio;
        DateTime fechaFinal;
        Corte CorteCreado;
        Prenda? PrendaSeleccionada;
        int cantidadHorasCorte;
        public FrmAltaCortes()
        {
            InitializeComponent();
        }

        private void BtnAgregarConfeccion_Click(object sender, EventArgs e)
        {
            FrmCalendario registro = new();
            if (registro.ShowDialog() != DialogResult.OK)
            {
                registro.Close();
            }
            /*
            if (CorteCreado != null && GestionDatos.PrendasParaCortes is not null)
            {
                fechaInicio = McFechaEntrega.SelectionStart;
                if (CorteCreado is not null && CorteCreado.PrendasEnConfeccion is not null)
                {

                    if (CorteCreado.PrendasEnConfeccion.Count > 0)
                    {

                        cantidadHorasCorte = EstimacionCortes.CalcularHorasCorte(CorteCreado.PrendasEnConfeccion, Convert.ToInt32(NumUnidades.Value));
                        if (cantidadHorasCorte != -1)
                        {
                            fechaFinal = fechaInicio.AddDays(cantidadHorasCorte);
                            GestionDatos.CortesConEntregas = ControlCortes.ObtenerEntregasEnDias(fechaInicio, cantidadHorasCorte);
                            if (GestionDatos.CortesConEntregas is not null)
                            {
                                CargarDatagridConfeccionesConEntrega();
                                lblDiasEntrega.Text = cantidadHorasCorte.ToString() + " dias estimados para entrega";
                            }
                            McFechaEntrega.SelectionEnd = fechaFinal;
                        }
                        else
                        {
                            LblErrores.Text = "Error al crear esta confeccion. no se pudo calcular el tiempo";
                        }
                    }
                }
                else
                {
                    LblErrores.Text = "Debe elegir prendas del sistema para mandar a produccion";
                }
            }*/
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
            lblDiasEntrega.Text = string.Empty;
            //TEMPORALMENTE HARDCODE
            //GestionDatos.PrendasSistema.Clear();



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

                            //si el corte es nulo se crea uno nuevo
                            if (CorteCreado is null)
                            {
                                CorteCreado = new(EtapaCorte.Tizando);
                            }
                            PrendaSeleccionada.UnidadesCorte = (int)NumUnidades.Value;
                            PrendaSeleccionada.TallePrenda = talle;
                            //Agrego la prenda a la lista de prendas guardada en el corte creado
                            if (CorteCreado.PrendasEnConfeccion is not null)
                            {
                                Administracion.AgregarPrenda_Corte(CorteCreado, PrendaSeleccionada);
                                CargarDatagridPrendasCorte();
                            }
                            else
                            {
                                LblErrores.Text = "Hubo un problema en la creacion de el corte";
                            }

                        }
                        else
                        {
                            LblErrores.Text = "Debes seleccionar al menos una prenda para continuar";
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

        private void McFechaEntrega_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {

                if (CorteCreado is not null && GestionDatos.PrendasParaCortes is not null)
                {
                    CorteCreado.FechaInicio = McFechaEntrega.SelectionRange.Start;
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
            if (GestionDatos.PrendasParaCortes is not null && GestionDatos.PrendasParaCortes.Count > 0)
            {
                fechaInicio = fechaInicio.AddDays(cantidadHorasCorte);
                fechaFinal = fechaInicio.AddDays(cantidadHorasCorte);
                McFechaEntrega.SelectionRange.End = fechaFinal;
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
                fila.Cells[1].Value = prenda.CantidadPrendas; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[2].Value = prenda.HorasProduccion; // Suponiendo que Prenda tiene una propiedad "Tipo"
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
            DtgPrendasConfeccion.Columns.Add("ColumnaTiempoEstimado", "Tiempo Estimado (HS)");

            // Recorrer el diccionario y agregar filas al DataGridView
            if (CorteCreado.PrendasEnConfeccion is not null && CorteCreado.PrendasEnConfeccion.Count > 0)
            {
                foreach (KeyValuePair<TallePrenda, List<Prenda>> par in CorteCreado.PrendasEnConfeccion)
                {
                    List<Prenda> listaPrendas = par.Value;
                    TallePrenda talle = par.Key;

                    // Crear una nueva fila y asignar los valores de las celdas
                    foreach (Prenda prenda in listaPrendas)
                    {
                        DataGridViewRow fila = new();
                        fila.CreateCells(DtgPrendasConfeccion);
                        fila.Cells[0].Value = prenda.Categoria;
                        fila.Cells[1].Value = prenda.Detalles;
                        fila.Cells[2].Value = prenda.TallePrenda;
                        fila.Cells[3].Value = prenda.UnidadesCorte;


                        if (NumUnidades.Value == PrendaSeleccionada.PrendasHora && prenda == PrendaSeleccionada)
                        {
                            prenda.HorasProduccion = PrendaSeleccionada.HorasProduccion;
                        }
                        fila.Cells[4].Value = prenda.HorasDeProduccion;

                        DtgPrendasConfeccion.Rows.Add(fila);
                    }
                }


            }
            else
            {
                throw new Exception("Debe cargar al menos una prenda");
            }
        }
        private void CargarDatagridConfeccionesConEntrega()
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
        }
        private void VaciarInformacion()
        {
            if (GestionDatos.PrendasParaCortes is not null && GestionDatos.PrendasParaCortes.Count > 0)
            {
                GestionDatos.PrendasParaCortes.Clear();
                CorteCreado = null;
                DtgFechasPrevistas.DataSource = null;
                DtgPrendasConfeccion.DataSource = null;
                NumUnidades.Value = 1;
            }
        }

        private void DtgPrendasSistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
