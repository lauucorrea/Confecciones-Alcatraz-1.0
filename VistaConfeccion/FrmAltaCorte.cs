using Entidades;
using Procesos;

namespace Vista
{
    public partial class FrmAltaCorte : Form
    {
        DateTime fechaInicio;
        DateTime fechaFinal;
        Corte CorteCreado;
        List<DateTime> posiblesFechas;
        Prenda? PrendaSeleccionada_Sistema;
        Prenda? PrendaSeleccionada_Corte;
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
                GestionDatos.PrendasParaCortes.Clear();
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
                        CorteCreado.ObtenerHorasTotalesCorte();
                        GestionDatos.CortesSistema.Add(CorteCreado);
                        Serializadora.GuardarCortesJSON();

                        FrmCalendario calendario = new(PersonaLogueada);
                        if (calendario.ShowDialog() != DialogResult.OK)
                        {
                            calendario.Close();
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
            DtgPrendasCorte.AutoGenerateColumns = true;
            this.ControlBox = false;
            CargarDatagridPrendasSistema();


        }

        private void BtnAgregarPrenda_Click(object sender, EventArgs e)
        {
            try
            {

                if (DtgPrendasSistema.SelectedRows.Count != 0)
                {
                    PrendaSeleccionada_Sistema = ObtenerPrendaSeleccionada_Sistema();

                    if (PrendaSeleccionada_Sistema is not null)
                    {
                        if (NumUnidades.Value > 0)
                        {

                            //Guardo el talle selecionado en la preconfeccion
                            TallePrenda[] talles = (TallePrenda[])Enum.GetValues(typeof(TallePrenda));
                            TallePrenda talle = talles[CmbTalle.SelectedIndex];

                            PrendaSeleccionada_Sistema.UnidadesCorte = (int)NumUnidades.Value;
                            PrendaSeleccionada_Sistema.TiempoFinalEtapa = PrendaSeleccionada_Sistema.UnidadesCorte / PrendaSeleccionada_Sistema.PrendasHora;

                            PrendaSeleccionada_Sistema.TallePrenda = talle;

                            //Administracion.AgregarPrenda_Corte(CorteCreado, PrendaSeleccionada);
                            GestionDatos.PrendasParaCortes.Add(PrendaSeleccionada_Sistema);
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

        private void DtgPrendasCorte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DtgPrendasCorte.Rows[e.RowIndex].Selected = true;
            }
        }

        private Prenda? ObtenerPrendaSeleccionada_Sistema()
        {
            PrendaSeleccionada_Sistema = null;
            if (DtgPrendasSistema.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DtgPrendasSistema.SelectedRows[0];
                string? categoriaPrenda = filaSeleccionada.Cells["ColumnaCategoria"].Value.ToString();

                if (filaSeleccionada is not null && !string.IsNullOrEmpty(categoriaPrenda))
                {

                    // Obtener los valores de las celdas
                    int IdPrenda = Convert.ToInt32(filaSeleccionada.Cells["ColumnaId"].Value);

                    // Crear una instancia de la prenda seleccionada
                    foreach (Prenda prenda in GestionDatos.PrendasSistema)
                    {
                        if (prenda.IdPrenda == IdPrenda)
                        {

                            if (string.IsNullOrEmpty(prenda.Detalles) && !string.IsNullOrEmpty(prenda.Distintivo))
                            {
                                PrendaSeleccionada_Sistema = new (prenda.Categoria, prenda.CantidadEnHoras, prenda.HorasParaCantidad, prenda.Distintivo);
                                PrendaSeleccionada_Sistema.IdPrenda = IdPrenda;
                            }
                            else if (!string.IsNullOrEmpty(prenda.Distintivo))
                            {
                                PrendaSeleccionada_Sistema = new (prenda.Categoria, prenda.CantidadEnHoras, prenda.HorasParaCantidad, prenda.Distintivo, prenda.Detalles);
                                PrendaSeleccionada_Sistema.IdPrenda = IdPrenda;
                            }
                            
                        }
                    }
                }
                else
                {
                    throw new NullReferenceException("La prenda seleccionada no tiene categoria asignada");
                }

            }
            return PrendaSeleccionada_Sistema;
        }
        private Prenda? ObtenerPrendaSeleccionada_Corte()
        {
            PrendaSeleccionada_Sistema = null;
            if (DtgPrendasSistema.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DtgPrendasCorte.SelectedRows[0];

                if (filaSeleccionada is not null)
                {

                    // Obtener los valores de las celdas
                    int IdPrenda = Convert.ToInt32(filaSeleccionada.Cells["ColumnaId"].Value);

                    // Crear una instancia de la prenda seleccionada
                    foreach (Prenda prenda in GestionDatos.PrendasParaCortes)
                    {
                        if (prenda.IdPrenda == IdPrenda)
                        {
                            PrendaSeleccionada_Corte = prenda;
                            break;
                        }
                    }
                }
                else
                {
                    throw new NullReferenceException("La prenda seleccionada no tiene categoria asignada");
                }

            }
            return PrendaSeleccionada_Corte;
        }

        private void CargarDatagridPrendasSistema()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasSistema.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasSistema.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgPrendasSistema.Columns.Add("ColumnaID", "ID");
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
                fila.Cells[0].Value = prenda.IdPrenda;
                fila.Cells[1].Value = prenda.Categoria; // Suponiendo que Prenda tiene una propiedad "Nombre"
                fila.Cells[2].Value = prenda.CantidadEnHoras; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[3].Value = prenda.HorasParaCantidad; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[4].Value = prenda.PrendasHora; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[5].Value = prenda.Detalles; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[6].Value = prenda.Distintivo; // Suponiendo que Prenda tiene una propiedad "Cantidad"

                // Agregar la fila al DataGridView
                DtgPrendasSistema.Rows.Add(fila);
            }
        }
        private void CargarDatagridPrendasCorte()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasCorte.DataSource = null; // Limpia el origen de datos
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasCorte.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgPrendasCorte.Columns.Add("ColumnaID", "ID");
            DtgPrendasCorte.Columns.Add("ColumnaTipo", "Tipo");
            DtgPrendasCorte.Columns.Add("ColumnaDetallePrenda", "Detalle");
            DtgPrendasCorte.Columns.Add("ColumnaTalle", "Talle");
            DtgPrendasCorte.Columns.Add("ColumnaCantidadPrendas", "Cantidad de Prendas");
            DtgPrendasCorte.Columns.Add("ColumnaTiempoEstimadoHoras", "Tiempo Estimado (HS)");
            DtgPrendasCorte.Columns.Add("ColumnaTiempoEstimadoDias", "Tiempo Estimado (Dias)");

            // Recorrer el diccionario y agregar filas al DataGridView
            if (GestionDatos.PrendasParaCortes is not null && GestionDatos.PrendasParaCortes.Count > 0)
            {  // Crear una nueva fila y asignar los valores de las celdas
                foreach (Prenda prenda in GestionDatos.PrendasParaCortes)
                {
                    DataGridViewRow fila = new();
                    fila.CreateCells(DtgPrendasCorte);
                    fila.Cells[0].Value = prenda.IdPrenda;
                    fila.Cells[1].Value = prenda.Categoria;
                    fila.Cells[2].Value = prenda.Detalles;
                    fila.Cells[3].Value = prenda.TallePrenda;
                    fila.Cells[4].Value = prenda.UnidadesCorte;
                    //si la cantidad elegida, es igual al tiempo por hora, las prendas se hacen en una hora
                    if (PrendaSeleccionada_Sistema is not null)
                    {

                        if (NumUnidades.Value == PrendaSeleccionada_Sistema.PrendasHora && prenda == PrendaSeleccionada_Sistema)
                        {
                            prenda.HorasParaCantidad = PrendaSeleccionada_Sistema.HorasParaCantidad;
                        }
                    }
                    fila.Cells[5].Value = Math.Round(prenda.TiempoFinalEtapa, 1);

                    decimal calculo = prenda.TiempoFinalEtapa / PersonaLogueada.HorasJornada;

                    if (calculo < (decimal)0.2)
                    {
                        fila.Cells[6].Value = $"< 1 dia ({Math.Round(calculo, 2)})";

                    }
                    else
                    {
                        fila.Cells[6].Value = Math.Round(calculo, 1);
                    }
                    DtgPrendasCorte.Rows.Add(fila);
                }



            }
        }

        private void VaciarInformacion()
        {
            if (GestionDatos.PrendasParaCortes is not null && GestionDatos.PrendasParaCortes.Count > 0)
            {
                GestionDatos.PrendasParaCortes.Clear();
                CorteCreado = null;
                DtgPrendasCorte.DataSource = null;
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
                Application.Exit();
            }
        }

        private void BtnQuitarPrenda_Click(object sender, EventArgs e)
        {
            try
            {

                if (DtgPrendasCorte.SelectedRows.Count != 0)
                {
                    PrendaSeleccionada_Corte = ObtenerPrendaSeleccionada_Corte();

                    if (PrendaSeleccionada_Corte is not null)
                    {
                        int index = GestionDatos.PrendasParaCortes.IndexOf(PrendaSeleccionada_Corte);

                        if (GestionDatos.PrendasParaCortes[index] != null && GestionDatos.PrendasParaCortes[index] == PrendaSeleccionada_Corte)
                        {
                            // Eliminar el elemento en la posición index
                            GestionDatos.PrendasParaCortes.RemoveAt(index);

                        }
                        else if (PrendaSeleccionada_Corte is not null)
                        {
                            foreach (Prenda prenda in GestionDatos.PrendasParaCortes)
                            {
                                if (prenda.IdPrenda == PrendaSeleccionada_Corte.IdPrenda)
                                {
                                    GestionDatos.PrendasParaCortes.Remove(prenda);

                                    break;
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("No se encontro la prenda");
                        }
                        CargarDatagridPrendasCorte();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
