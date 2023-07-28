namespace Entidades
{
    public static class Administracion
    {
        /// <summary>
        /// Creamos la prenda segun los datos ingresados. detallePrenda e informacionAdicional son campos opcionales de la clase Prenda
        /// Talle forma parte de Confecciones ahora, ya que la tanda va a depender del talle, y no se pueden crear 5
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="horasProduccion"></param>
        /// <param name="detallePrenda"></param>
        /// <param name="informacionAdicional"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Prenda CrearPrenda(CategoriaPrenda categoria, int cantidadPrendas, int horasProduccion, string detallePrenda, string informacionAdicional)
        {
            Prenda PrendaCreada;

            if (!string.IsNullOrEmpty(detallePrenda) && !string.IsNullOrEmpty(informacionAdicional))
            {
                PrendaCreada = new(categoria, cantidadPrendas, horasProduccion, detallePrenda, informacionAdicional);

            }
            else if (!string.IsNullOrEmpty(detallePrenda) && string.IsNullOrEmpty(informacionAdicional))
            {
                PrendaCreada = new(categoria, cantidadPrendas, horasProduccion, detallePrenda);
            }
            else if (string.IsNullOrEmpty(detallePrenda) && !string.IsNullOrEmpty(informacionAdicional))
            {
                PrendaCreada = new(categoria, cantidadPrendas, horasProduccion, informacionAdicional);
            }
            else
            {
                PrendaCreada = new(categoria, cantidadPrendas, horasProduccion);
            }

            if (PrendaCreada is not null)
            {
                return PrendaCreada;
            }
            else
            {
                throw new Exception("No se pudo crear la prenda");
            }
        }


        public static bool AgregarPrenda_Lista(Prenda unaPrenda)
        {
            try
            {
                if (unaPrenda is not null)
                {
                    if (!GestionDatos.PrendasSistema.Contains(unaPrenda))
                    {
                        GestionDatos.PrendasSistema.Add(unaPrenda);
                        return true;
                    }
                    else
                    {
                        throw new Exception("La prenda que queres agregar, ya existe en el sistema");
                    }
                }
                else
                {
                    throw new NullReferenceException("No se pudo instanciar la prenda");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error. Detalle: " + ex.Message);
            }
        }
        public static bool EncontrarCorte(Corte corteBuscado)
        {
            try
            {
                if (corteBuscado is not null)
                {
                    if (GestionDatos.CortesSistema.Contains(corteBuscado))
                    {
                        return true;
                    }

                }
                else
                {
                    throw new NullReferenceException("No se encontro la confeccion especificada");
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }

        //aca metodo que resuelve
        public static List<Corte> ObtenerCorte_Lista(DateTime fechaBusqueda)
        {
            if (GestionDatos.CortesSistema is not null)
            {
                foreach (Corte corte in GestionDatos.CortesSistema)
                {
                    
                }
                return new List<Corte>();
            }
            else
            {
                throw new NullReferenceException("No hay cortes cargados en el sistema");
            }
        }


        public static bool AgregarPrenda_Corte(Corte corte, Prenda prendaSeleccionada)
        {
            // Verificar si el corte es nulo
            if (corte is null)
            {
                throw new ArgumentNullException("El corte recibido no es válido");
            }

            // Verificar si la prenda seleccionada es nula
            if (prendaSeleccionada is null)
            {
                throw new ArgumentNullException("La prenda recibida no es válida");
            }

            // Verificar si la prenda ya existe en el corte
            if (corte.EncontrarPrenda(prendaSeleccionada))
            {
                // La prenda ya existe en el corte, retornar false
                return false;
            }

            // Verificar si PrendasEnCorte es nulo y crear una nueva instancia si es necesario
            if (corte.PrendasEnCorte is null)
            {
                corte.PrendasEnCorte = new SortedDictionary<TallePrenda, List<Prenda>>();
            }

            // Verificar si la prenda pertenece a un talle existente en el corte
            if (corte.PrendasEnCorte.ContainsKey(prendaSeleccionada.TallePrenda))
            {
                // La prenda pertenece a un talle existente en el corte
                List<Prenda> prendas = corte.PrendasEnCorte[prendaSeleccionada.TallePrenda];
                prendaSeleccionada.Etapa = EtapaCorte.Pendiente;
                prendas.Add(prendaSeleccionada);
            }
            else
            {
                // La prenda no pertenece a un talle existente en el corte

                // Crear una nueva lista para el talle de la prenda y agregar la prenda a esa lista
                List<Prenda> prendas = new List<Prenda> { prendaSeleccionada };

                // Agregar la lista al diccionario PrendasEnCorte con la clave del talle
                corte.PrendasEnCorte.Add(prendaSeleccionada.TallePrenda, prendas);
            }

            return true; // Retornar true indicando que se agregó la prenda correctamente
        }
        public static List<int> ObtenerConteoDeEstado(List<Corte> listaCortes)
        {
            List<int> conteo = new();
            int contadorPendiente = 0;
            int contadorTizando = 0;
            int contadorEncimando = 0;
            int contadorCortando = 0;
            int contadorTerminando = 0;

            foreach (Corte corte in listaCortes)
            {
                foreach (KeyValuePair<TallePrenda, List<Prenda>> kp in corte.PrendasEnCorte)
                {
                    foreach (Prenda prenda in kp.Value)
                    {
                        switch (prenda.Etapa.ToString())
                        {
                            case "Pendiente":
                                contadorPendiente++;
                                break;
                            case "Tizando":
                                contadorTizando++;
                                break;
                            case "Encimando":
                                contadorEncimando++;
                                break;
                            case "Cortando":
                                contadorCortando++;
                                break;
                            case "Terminando":
                                contadorTerminando++;
                                break;
                        }
                    }
                }
            }

            conteo.Add(contadorPendiente);
            conteo.Add(contadorTizando);
            conteo.Add(contadorEncimando);
            conteo.Add(contadorCortando);
            conteo.Add(contadorTerminando);
            return conteo;
        }
        public static List<int> ObtenerConteoDeTalles(Corte corte)
        {
            List<int> conteo = new();
            int contadorXS = 0;
            int contadorS = 0;
            int contadorM = 0;
            int contadorL = 0;
            int contadorXL = 0;
            int contadorXXL = 0;

            foreach (KeyValuePair<TallePrenda, List<Prenda>> kvp in corte.PrendasEnCorte)
            {
                foreach (Prenda prenda in kvp.Value)
                {

                    switch (prenda.TallePrenda.ToString())
                    {
                        case "XS":
                            contadorXS++;
                            break;
                        case "S":
                            contadorS++;
                            break;
                        case "M":
                            contadorM++;
                            break;
                        case "L":
                            contadorL++;
                            break;
                        case "XL":
                            contadorXL++;
                            break;
                        case "XXL":
                            contadorXXL++;
                            break;
                    }
                }

            }

            conteo.Add(contadorXS);
            conteo.Add(contadorS);
            conteo.Add(contadorM);
            conteo.Add(contadorL);
            conteo.Add(contadorXL);
            conteo.Add(contadorXXL);

            return conteo;
        }

        public static List<Prenda> ObtenerPrendasCorte(Corte corte)
        {
            List<Prenda> listaObtenida = new();

            if (corte.PrendasEnCorte is not null)
            {

                foreach (KeyValuePair<TallePrenda, List<Prenda>> kp in corte.PrendasEnCorte)
                {
                    foreach (Prenda prenda in kp.Value)
                    {
                        listaObtenida.Add(prenda);
                    }
                }
            }
            else
            {
                throw new ArgumentNullException("Las prendas recibidas no son validas");
            }

            return listaObtenida;

        }

        public static List<Corte> ObtenerCortesPorFecha(DateTime fechaBusqueda)
        {
            List<Corte> ListaCortesEncontrados = new();

            foreach (Corte corte in GestionDatos.CortesSistema)
            {
                List<DateTime> fechas = ObtenerListaFechasEnRango(corte.FechaInicio, corte.FechaFinal);

                if (fechas.Any(fecha => fecha.Date == fechaBusqueda.Date))
                {
                    ListaCortesEncontrados.Add(corte);
                }
            }


            return ListaCortesEncontrados;

        }


        public static Dictionary<DateTime, List<Corte>> ObtenerCortesEnFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
            Dictionary<DateTime, List<Corte>> CortesEnFechas = new();
            if (fechaInicio != DateTime.MinValue && fechaFinal != DateTime.MinValue)
            {
                List<DateTime> fechas = ObtenerListaFechasEnRango(fechaInicio, fechaFinal);
                if (fechas is not null)
                {
                    foreach (DateTime fecha in fechas)
                    {
                        foreach (Corte corte in GestionDatos.CortesSistema)
                        {
                            List<DateTime> fechasEnRango = ObtenerListaFechasEnRango(corte.FechaInicio, corte.FechaFinal);

                            // Verificar si hay fechas en común entre fechasEnRango y la lista fechas
                            List<DateTime> fechasComunes = fechas.Intersect(fechasEnRango).ToList();

                            if (fechasComunes.Count > 0)
                            {
                                foreach (DateTime fechaComun in fechasComunes)
                                {
                                    if (!CortesEnFechas.ContainsKey(fechaComun))
                                    {
                                        CortesEnFechas[fechaComun] = new List<Corte>();
                                    }
                                    CortesEnFechas[fechaComun].Add(corte);
                                }
                            }

                        }
                    }
                }
                else
                {
                    throw new NullReferenceException("No se pudo obtener fechas en Administracion.ObtenerCortesEnFechas:null return");
                }
            }
            else
            {
                throw new ArgumentNullException("Fechas recibidas no validas en ObtenerCortesEnFechas(PARAM)");
            }
            return CortesEnFechas;

        }
        public static List<DateTime> ObtenerListaFechasEnRango(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<DateTime> listaFechas = new List<DateTime>
            {
                // Agregar la fecha de inicio a la lista
                fechaInicio
            };

            // Calcular el número de días en el rango
            int diasEnRango = (int)(fechaFinal - fechaInicio).TotalDays - 1;
            DateTime fechaActual = fechaInicio;

            // Agregar las fechas intermedias al rango
            for (int i = 1; i <= diasEnRango; i++)
            {
                fechaActual = fechaActual.AddDays(1);
                listaFechas.Add(fechaActual);
            }

            return listaFechas;
        }

        public static bool ExisteFechaFinalEnCortes(DateTime fechaBusqueda, out Corte? corteConFinal)
        {
            bool ret = false;
            Corte corteEncontrado = new();
            if (GestionDatos.CortesSistema is not null && GestionDatos.CortesSistema.Count > 0)
            {
                foreach (Corte corte in GestionDatos.CortesSistema)
                {
                    if (corte.FechaFinal == fechaBusqueda)
                    {
                        corteEncontrado = corte;
                        ret = true;
                    }

                }
            }
            corteConFinal = corteEncontrado;
            return ret;
        }


    }
}
