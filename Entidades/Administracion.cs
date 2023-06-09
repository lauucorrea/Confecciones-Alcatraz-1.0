﻿namespace Entidades
{
    public static class Administracion
    {
        static List<string> EnumALista<T>()
        {
            var enumType = typeof(T);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("El tipo especificado no es un enum.");
            }

            var names = Enum.GetNames(enumType);
            var list = new List<string>(names.Length);

            foreach (string name in names)
            {
                list.Add(name);
            }

            return list;
        }
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

                    foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
                    {
                        List<Corte> Cortes = par.Value;
                        if (Cortes.Contains(corteBuscado))
                        {
                            return true;
                        }
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

        public static List<Corte> ObtenerCorte_Diccionario(DateTime fechaBusqueda)
        {
            if (GestionDatos.CortesPorFecha is not null)
            {
                foreach (KeyValuePair<DateTime, List<Corte>> kp in GestionDatos.CortesPorFecha)
                {
                    if (kp.Key == fechaBusqueda)
                    {
                        return kp.Value;
                    }
                }
                return new List<Corte>();
            }
            else
            {
                throw new NullReferenceException("No hay cortes cargados en el sistema");
            }
        }
        public static bool AgregarCorte_Diccionario(Corte unCorte)
        {
            try
            {
                if (unCorte is not null)
                {
                    if (!EncontrarCorte(unCorte))
                    {
                        if (GestionDatos.CortesPorFecha.ContainsKey(unCorte.FechaInicio))
                        {

                            foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
                            {
                                if (par.Key == unCorte.FechaInicio)
                                {
                                    par.Value.Add(unCorte);
                                    return true;
                                }

                            }

                        }
                        else
                        {
                            //el corte no existe aun en el sistema
                            List<Corte> cortes = new()
                            {
                                unCorte
                            };

                            if (cortes is not null)
                            {
                                GestionDatos.CortesPorFecha.Add(unCorte.FechaInicio, cortes);
                                return true;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("El corte: " + unCorte.ToString() + " ya existe en nuestro sistema");
                    }

                    return false;
                }
                else
                {
                    throw new ArgumentNullException("Los datos ingresados no son validos");
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentException("Ocurrio un error. Detalle: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("Ocurrio un error. Detalle: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error. Detalle: " + ex.Message);
            }
        }

        public static bool AgregarPrenda_Corte(Corte corte, Prenda prendaSeleccionada)
        {
            if (corte is not null)
            {
                if (prendaSeleccionada is not null)
                {
                    if (!corte.EncontrarPrenda(prendaSeleccionada) && corte.PrendasEnConfeccion is not null)
                    {
                        if (corte.PrendasEnConfeccion.ContainsKey(prendaSeleccionada.TallePrenda))
                        {

                            if (corte.PrendasEnConfeccion.Count > 0)
                            {

                                foreach (KeyValuePair<TallePrenda, List<Prenda>> par in corte.PrendasEnConfeccion)
                                {
                                    if (par.Key == prendaSeleccionada.TallePrenda)
                                    {
                                        prendaSeleccionada.Etapa = EtapaCorte.Pendiente;
                                        par.Value.Add(prendaSeleccionada);
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                    else if (corte.PrendasEnConfeccion is null || corte.PrendasEnConfeccion.Count == 0)
                    {

                        //la prenda no existe aun en el corte
                        List<Prenda> prendas = new()
                            {
                                prendaSeleccionada
                            };

                        if (prendas is not null)
                        {
                            corte.PrendasEnConfeccion = new()
                            {
                                { prendaSeleccionada.TallePrenda, prendas }
                            };
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    throw new ArgumentNullException("La prenda recibida no es valida");
                }
            }
            else
            {
                throw new ArgumentNullException("El corte recibido no es valido");
            }
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
                foreach (KeyValuePair<TallePrenda, List<Prenda>> kp in corte.PrendasEnConfeccion)
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

            foreach (KeyValuePair<TallePrenda, List<Prenda>> kvp in corte.PrendasEnConfeccion)
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

            if (corte.PrendasEnConfeccion is not null)
            {

                foreach (KeyValuePair<TallePrenda, List<Prenda>> kp in corte.PrendasEnConfeccion)
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
            foreach(KeyValuePair<DateTime,List<Corte>> kvp in GestionDatos.CortesPorFecha)
            {
                foreach(Corte corte in kvp.Value)
                {
                    List<DateTime> fechas = ObtenerListaFechasEnRango(corte.FechaInicio, corte.FechaFinal);

                    if (fechas.Contains(fechaBusqueda))
                    {
                        ListaCortesEncontrados.Add(corte);
                    }
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
                        foreach (KeyValuePair<DateTime, List<Corte>> kvp in GestionDatos.CortesPorFecha)
                        {
                            foreach (Corte corte in kvp.Value)
                            {

                                if (CortesEnFechas.ContainsKey(fecha) && !kvp.Value.Contains(corte))
                                {
                                    kvp.Value.Add(corte);
                                }
                                else if (!CortesEnFechas.ContainsKey(fecha))
                                {
                                    List<Corte> lista = new List<Corte>
                                {
                                    corte
                                };
                                    CortesEnFechas.Add(fecha, lista);

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
        static List<DateTime> ObtenerListaFechasEnRango(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<DateTime> listaFechas = new List<DateTime>
            {
                // Agregar la fecha de inicio a la lista
                fechaInicio
            };

            // Calcular el número de días en el rango
            int diasEnRango = (int)(fechaFinal - fechaInicio).TotalDays;

            // Agregar las fechas intermedias al rango
            for (int i = 1; i <= diasEnRango; i++)
            {
                DateTime fechaIntermedia = fechaInicio.AddDays(i);
                listaFechas.Add(fechaIntermedia);
            }

            return listaFechas;
        }

        public static bool ExisteFechaEnCortes(DateTime fechaBusqueda, List<KeyValuePair<DateTime, Corte>> keyValuesList)
        {
            bool ret = false;
            foreach (KeyValuePair<DateTime, Corte> kvp in keyValuesList)
            {
                List<DateTime> fechasRango = ObtenerListaFechasEnRango(kvp.Value.FechaInicio, kvp.Value.FechaFinal);
                if (fechasRango.Contains(fechaBusqueda))
                {
                    ret = true;
                }

            }
            return ret;
        }


    }
}
