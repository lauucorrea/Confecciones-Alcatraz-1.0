using Entidades;

namespace Vista
{
    public partial class FrmTareaDiaria : Form
    {
        private List<Corte> cortesTarea = null;
        private List<Prenda> prendasCorte = new();
        private Dictionary<Prenda, List<int>> dictPrendasTalle;
        private DateTime fechaMuestra = DateTime.MinValue;
        public FrmTareaDiaria(DateTime fechaBusqueda)
        {
            InitializeComponent();
            cortesTarea = new();
            dictPrendasTalle = new();
            if (fechaBusqueda != DateTime.MinValue)
            {
                fechaMuestra = fechaBusqueda;

            }
        }

        private void FrmTareaDiaria_Load(object sender, EventArgs e)
        {
            cortesTarea = Administracion.ObtenerCortesPorFecha(fechaMuestra);

            if (cortesTarea != null)
            {
                ObtenerPrendasCortes();
                if (prendasCorte is not null)
                {
                    EmparejarPrendasConTalles();
                    CargarDatagridTareaDiaria();
                }
            }
            else
            {
                throw new Exception("No hay cortes en esta fecha");
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
            foreach (Prenda prenda in prendasCorte)
            {
                List<int> conteoTallePrendas = ObtenerConteoPorPrenda(prenda.IdPrenda, TienePrenda(prenda));
                if (dictPrendasTalle is not null)
                {
                    if (TienePrenda(prenda))
                    {
                        //agregamos el conteo que necesitamos. tendriamos que agregar una lista de enteros

                        dictPrendasTalle[prenda] = conteoTallePrendas;
                    }
                    else
                    {
                        dictPrendasTalle.Add(prenda, conteoTallePrendas);
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
                foreach (KeyValuePair<Prenda, List<int>> kvp in dictPrendasTalle)
                {
                    if (kvp.Key.IdPrenda == idPrenda)
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

            foreach (Prenda prenda in prendasCorte)
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
                foreach (KeyValuePair<Prenda, List<int>> kvp in dictPrendasTalle)
                {
                    if (kvp.Key.IdPrenda == prenda.IdPrenda)
                    {
                        return true;
                    }
                }
            }
            return false;

        }



        private void ObtenerPrendasCortes()
        {
            foreach (Corte corte in cortesTarea)
            {
                    foreach (Prenda prenda in corte.PrendasEnCorte)
                    {
                        if (!Administracion.ExistePrendaEnLista(prendasCorte, prenda))
                        {
                            prendasCorte.Add(prenda);
                        }
                    }
                
            }
        }

        private decimal ObtenerHorasTrabajo(int idPrenda)
        {
            decimal horas = 0;
            foreach (Corte corte in cortesTarea)
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

                if (cortesTarea is not null && cortesTarea.Count > 0)
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
                    foreach (KeyValuePair<Prenda, List<int>> kvp in dictPrendasTalle)
                    {
                        int acumPrendasTotal = 0;
                        foreach (int num in kvp.Value)
                        {
                            acumPrendasTotal += num;
                        }

                        DataGridViewRow fila = new();
                        fila.CreateCells(DtgTareaDiaria);
                        fila.Cells[0].Value = kvp.Key.IdPrenda;
                        fila.Cells[1].Value = kvp.Key.Categoria;
                        fila.Cells[2].Value = kvp.Value[0];
                        fila.Cells[3].Value = kvp.Value[0];
                        fila.Cells[4].Value = kvp.Value[0];
                        fila.Cells[5].Value = kvp.Value[0];
                        fila.Cells[6].Value = kvp.Value[0];
                        fila.Cells[7].Value = kvp.Value[0];
                        fila.Cells[8].Value = acumPrendasTotal;
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
        }
    }
