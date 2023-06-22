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


        public static bool AgregarCorte_Diccionario(Corte unCorte)
        {
            try
            {
                if (unCorte is not null)
                {
                    if (EncontrarCorte(unCorte))
                    {
                        foreach (KeyValuePair<DateTime, List<Corte>> par in GestionDatos.CortesPorFecha)
                        {
                            if (par.Key == unCorte.FechaFinal)
                            {
                                par.Value.Add(unCorte);
                            }

                        }
                        return true;
                    }
                    else
                    {
                        //el corte no existe aun en el sistema
                        List<Corte> cortes = new();
                        cortes.Add(unCorte);
                        if (cortes is not null)
                        {
                            GestionDatos.CortesPorFecha.Add(unCorte.FechaFinal, cortes);
                            return true;
                        }
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
                    if (!corte.EncontrarPrenda(prendaSeleccionada))
                    {

                        if (corte.PrendasEnConfeccion.ContainsKey(prendaSeleccionada.TallePrenda))
                        {
                            if (corte.PrendasEnConfeccion is not null && corte.PrendasEnConfeccion.Count > 0)
                            {

                                foreach (KeyValuePair<TallePrenda, List<Prenda>> par in corte.PrendasEnConfeccion)
                                {
                                    if (par.Key == prendaSeleccionada.TallePrenda)
                                    {
                                        par.Value.Add(prendaSeleccionada);
                                        return true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //la prenda no existe aun en el corte
                            List<Prenda> prendas = new();
                            prendas.Add(prendaSeleccionada);

                            if (prendas is not null)
                            {
                                corte.PrendasEnConfeccion.Add(prendaSeleccionada.TallePrenda, prendas);
                                return true;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Ya existe una prenda con estas caracteristicas");
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




    }
}
