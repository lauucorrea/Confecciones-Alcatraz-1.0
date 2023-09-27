using System.Globalization;
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
        /// <param name="distintivo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Prenda CrearPrenda(CategoriaPrenda categoria, int cantidadPrendas, int horasProduccion, string distintivo, string detallePrenda)
        {
            Prenda PrendaCreada = null;

            if (string.IsNullOrEmpty(detallePrenda) && !string.IsNullOrEmpty(distintivo))
            {
                PrendaCreada = new(categoria, cantidadPrendas, horasProduccion, distintivo);

            }
            else if (!string.IsNullOrEmpty(distintivo))
            {
                PrendaCreada = new(categoria, cantidadPrendas, horasProduccion, distintivo, detallePrenda);
            }
            else
            {
                throw new Exception("Debe cargarse el distintivo para continuar");
            }

            return PrendaCreada;
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
            corte.PrendasEnCorte ??= new();

            prendaSeleccionada.IdCorte = corte.IdentificadorDeCorte;
            corte.PrendasEnCorte.Add(prendaSeleccionada);


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
                foreach (Prenda prenda in corte.PrendasEnCorte)
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

            conteo.Add(contadorPendiente);
            conteo.Add(contadorTizando);
            conteo.Add(contadorEncimando);
            conteo.Add(contadorCortando);
            conteo.Add(contadorTerminando);
            return conteo;
        }
        public static List<int> ObtenerConteoDeTalles_Corte(Corte corte)
        {
            List<int> conteo = new();
            int contadorXS = 0;
            int contadorS = 0;
            int contadorM = 0;
            int contadorL = 0;
            int contadorXL = 0;
            int contadorXXL = 0;

            foreach (Prenda prenda in corte.PrendasEnCorte)
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



            conteo.Add(contadorXS);
            conteo.Add(contadorS);
            conteo.Add(contadorM);
            conteo.Add(contadorL);
            conteo.Add(contadorXL);
            conteo.Add(contadorXXL);

            return conteo;
        }


        public static bool ExistePrendaEnLista(List<Prenda> prendas, Prenda prendaBusqueda)
        {
            foreach (Prenda prenda in prendas)
            {
                if (prendaBusqueda.IdPrenda == prenda.IdPrenda)
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Corte> ObtenerCortesPorFecha(DateTime fechaBusqueda)
        {
            List<Corte> ListaCortesEncontrados = new();

            if (!EsDiaFeriado(fechaBusqueda))
            {
                foreach (Corte corte in GestionDatos.CortesSistema)
                {
                    if (corte.FechasCorte.Any(fecha => fecha.Date == fechaBusqueda.Date))
                    {
                        ListaCortesEncontrados.Add(corte);
                    }
                }
            }


            return ListaCortesEncontrados;

        }
        public static bool EsDiaFeriado(DateTime fechaBusqueda)
        {
            bool ret = false;

            foreach (DateTime feriado in GestionDatos.DiasNoLaborales)
            {
                if (feriado.Date == fechaBusqueda.Date)
                {
                    ret = true;
                }
            }

            return ret;

        }
        public static List<Corte> ObtenerCortesEnFechas(List<DateTime> fechasBusqueda)
        {
            List<Corte> cortesEncontrados = new List<Corte>();

            foreach (Corte corte in GestionDatos.CortesSistema)
            {
                foreach (DateTime fechaBusqueda in fechasBusqueda)
                {
                    if (fechaBusqueda.Date >= corte.FechaInicio.Date && fechaBusqueda.Date <= corte.FechaFinal.Date)
                    {
                        cortesEncontrados.Add(corte);
                        break;
                    }
                }
            }

            return cortesEncontrados;
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
            int diasEnRango = (int)(fechaFinal - fechaInicio).TotalDays + 1;
            DateTime fechaActual = fechaInicio;

            // Agregar las fechas intermedias al rango
            for (int i = 1; i <= diasEnRango; i++)
            {
                fechaActual = fechaActual.AddDays(1);
                listaFechas.Add(fechaActual.Date);
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

        public static List<DateTime> ObtenerFechasParaCorte(Corte corte)
        {
            List<DateTime> lista = new();

            DateTime fechaActual = corte.FechaInicio;

            while (fechaActual <= corte.FechaFinal)
            {
                if (!GestionDatos.DiasNoLaborales.Contains(fechaActual))
                {
                    lista.Add(fechaActual);
                }
                fechaActual.AddDays(1);
            }

            return lista;
        }


    }
}
