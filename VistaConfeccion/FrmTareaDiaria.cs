using Entidades;

namespace Vista
{
    public partial class FrmTareaDiaria : Form
    {
        private List<Corte> CortesTarea = new();
        private List<Prenda> PrendasCorte = new();
        private Corte CorteSeleccionado = new();

        private Persona PersonaLogueada = new();
        private Dictionary<int, List<int>> dictPrendasTalle;

        public FrmTareaDiaria(List<Corte> listaCortes, Persona persona)
        {
            InitializeComponent();
            CortesTarea = new();
            dictPrendasTalle = new();
            if (listaCortes is not null && persona is not null)
            {
                CortesTarea = listaCortes;
                PersonaLogueada = persona;
            }
        }

        private void FrmTareaDiaria_Load(object sender, EventArgs e)
        {
            if (CortesTarea != null)
            {

                CrearDatagridCortes_General(CortesTarea);
                //CargarDatagridTareaDiaria();

            }
            else
            {
                throw new Exception("No hay cortes en esta fecha");
                Close();
            }
        }
        private void CrearDatagridCortes_General(List<Corte> lista)
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            dtgCortes.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            dtgCortes.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            dtgCortes.Columns.Add("ColumnaID", "ID Corte");
            dtgCortes.Columns.Add("ColumnaFechaInicio", "Fecha Inicio");
            dtgCortes.Columns.Add("ColumnaFechaFin", "Fecha Fin");
            dtgCortes.Columns.Add("ColumnaDuracionHs", "Horas Produccion");
            dtgCortes.Columns.Add("ColumnaDuracionDias", "Dias Produccion");
            dtgCortes.Columns.Add("ColumnaPrendas", "Prendas en corte");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Corte corte in lista)
            {
                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(dtgCortes);
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
                dtgCortes.Rows.Add(fila);

            }
        }
        /// <summary>
        /// XS,
        ///S,
        /// M,
        ///L,
        /// XL,
        /// XXL
        /// </summary>
        private void EmparejarPrendasConTalles()
        {
            foreach (Prenda prenda in PrendasCorte)
            {
                List<int> conteoTallePrendas = ObtenerConteoPorPrenda(prenda.IdPrenda, TienePrenda(prenda));
                if (dictPrendasTalle is not null)
                {
                    if (TienePrenda(prenda))
                    {
                        //agregamos el conteo que necesitamos. tendriamos que agregar una lista de enteros

                        dictPrendasTalle[prenda.IdPrenda] = conteoTallePrendas;
                    }
                    else
                    {
                        dictPrendasTalle.Add(prenda.IdPrenda, conteoTallePrendas);
                    }
                }
            }
        }


        private List<int> ObtenerConteoPorPrenda(int idPrenda, bool tienePrenda)
        {
            List<int> conteo = new();
            int acumuladorXS = 0;
            int acumuladorS = 0;
            int acumuladorM = 0;
            int acumuladorL = 0;
            int acumuladorXL = 0;
            int acumuladorXXL = 0;

            //si ya tenemos una prenda con el mismo id, entonces a esa prenda le sumamos el conteo
            if (tienePrenda)
            {
                foreach (KeyValuePair<int, List<int>> kvp in dictPrendasTalle)
                {
                    if (kvp.Key == idPrenda)
                    {
                        List<int> conteoExistente = dictPrendasTalle[kvp.Key];
                        foreach (int acum in conteoExistente)
                        {
                            switch (conteoExistente.IndexOf(acum))
                            {
                                case 0:
                                    acumuladorXS += acum;
                                    break;
                                case 1:
                                    acumuladorS += acum;
                                    break;
                                case 2:
                                    acumuladorM += acum;
                                    break;
                                case 3:
                                    acumuladorL += acum;
                                    break;
                                case 4:
                                    acumuladorXL += acum;
                                    break;
                                case 5:
                                    acumuladorXXL += acum;
                                    break;
                            }
                        }
                    }


                }
            }

            foreach (Prenda prenda in PrendasCorte)
            {
                if (prenda.IdPrenda == idPrenda)
                {
                    switch (prenda.TallePrenda.ToString())
                    {
                        case "XS":
                            acumuladorXS += prenda.UnidadesCorte;
                            break;
                        case "S":
                            acumuladorS += prenda.UnidadesCorte;
                            break;
                        case "M":
                            acumuladorM += prenda.UnidadesCorte;
                            break;
                        case "L":
                            acumuladorL += prenda.UnidadesCorte;
                            break;
                        case "XL":
                            acumuladorXL += prenda.UnidadesCorte;
                            break;
                        case "XXL":
                            acumuladorXXL += prenda.UnidadesCorte;
                            break;
                    }
                }


            }

            conteo.Add(acumuladorXS);
            conteo.Add(acumuladorS);
            conteo.Add(acumuladorM);
            conteo.Add(acumuladorL);
            conteo.Add(acumuladorXL);
            conteo.Add(acumuladorXXL);

            return conteo;
        }
        private bool TienePrenda(Prenda prenda)
        {
            if (dictPrendasTalle is not null && dictPrendasTalle.Count > 0)
            {
                foreach (KeyValuePair<int, List<int>> kvp in dictPrendasTalle)
                {
                    if (kvp.Key == prenda.IdPrenda)
                    {
                        return true;
                    }
                }
            }
            return false;

        }



        private decimal ObtenerHorasTrabajo(int idPrenda)
        {
            decimal horas = 0;
            foreach (Corte corte in CortesTarea)
            {
                foreach (Prenda prenda in corte.PrendasEnCorte)
                {
                    if (prenda.IdPrenda == idPrenda)
                    {
                        horas += prenda.TiempoFinalEtapa;
                    }
                }


            }
            return horas;
        }
        private void CargarDatagridTareaDiaria()
        {
            if (CortesTarea is not null && CortesTarea.Count > 0)
            {
                // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
                DtgTareaDiaria.DataSource = null;
                // Limpiar las columnas existentes en el DataGridView
                DtgTareaDiaria.Columns.Clear();

                // Agregar las columnas necesarias al DataGridView
                DtgTareaDiaria.Columns.Add("ColumnaId", "IdPrenda");
                DtgTareaDiaria.Columns.Add("ColumnaCategoria", "Categoria");
                DtgTareaDiaria.Columns.Add("ColumnaTalleXS", "Talle XS");
                DtgTareaDiaria.Columns.Add("ColumnaTalleS", "Talle S");
                DtgTareaDiaria.Columns.Add("ColumnaTalleM", "Talle M");
                DtgTareaDiaria.Columns.Add("ColumnaTalleL", "Talle L");
                DtgTareaDiaria.Columns.Add("ColumnaTalleXL", "Talle XL");
                DtgTareaDiaria.Columns.Add("ColumnaTalleXXL", "Talle XXL");
                // DtgTareaDiaria.Columns.Add("ColumnaTotalPrendas", "Total Prendas");
                //DtgTareaDiaria.Columns.Add("ColumnaHorasTrabajo", "Horas fin");

                // Recorrer el diccionario y agregar filas al DataGridView
                foreach (KeyValuePair<int, List<int>> kvp in dictPrendasTalle)
                {
                    int acumPrendasTotal = 0;
                    foreach (int num in kvp.Value)
                    {
                        acumPrendasTotal += num;
                    }

                    DataGridViewRow fila = new();
                    fila.CreateCells(DtgTareaDiaria);
                    fila.Cells[0].Value = kvp.Key;

                    Prenda prendaEncontrada = new();
                    foreach (Corte corte in CortesTarea)
                    {

                        foreach (Prenda prenda in corte.PrendasEnCorte)
                        {
                            if (prenda.IdPrenda == kvp.Key)
                            {
                                prendaEncontrada = prenda;
                            }
                        }
                    }
                    fila.Cells[1].Value = prendaEncontrada.Categoria;
                    fila.Cells[2].Value = kvp.Value[0];
                    fila.Cells[3].Value = kvp.Value[1];
                    fila.Cells[4].Value = kvp.Value[2];
                    fila.Cells[5].Value = kvp.Value[3];
                    fila.Cells[6].Value = kvp.Value[4];
                    fila.Cells[7].Value = kvp.Value[5];
                    //fila.Cells[8].Value = acumPrendasTotal;
                    // fila.Cells[9].Value = conteo[5];
                    //fila.Cells[10].Value = corte.HorasTotalesCorte;
                    DtgTareaDiaria.Rows.Add(fila);
                }



            }
            else
            {
                throw new Exception("No hay prendas para hacer en esta fecha");
            }
        }

        private void dtgCortes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgCortes.SelectedRows[0];

            if (filaSeleccionada is not null)
            {
                int IdCorte = Convert.ToInt32(filaSeleccionada.Cells["ColumnaId"].Value);
                PrendasCorte = ObtenerPrendas_CorteSeleccionado(IdCorte);
                EmparejarPrendasConTalles();
                CargarDatagridTareaDiaria();
            }
            else
            {
                MessageBox.Show("El corte seleccionado no es valido");
            }
        }


        private List<Prenda> ObtenerPrendas_CorteSeleccionado(int IdCorte)
        {
            List<Prenda> prendas = new();
            if (dtgCortes.SelectedRows.Count > 0)
            {
                // Crear una instancia de la prenda seleccionada
                foreach (Corte corte in CortesTarea)
                {
                    if (corte.IdentificadorDeCorte == IdCorte)
                    {
                        prendas = corte.PrendasEnCorte;
                        break;
                    }
                }


            }
            return prendas;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar?";
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show("Desea volver al menu principal?", comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
