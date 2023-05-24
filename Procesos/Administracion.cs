using Entidades;
namespace Procesos
{
    public static class Administracion
    {
        /// <summary>
        /// Creamos la prenda segun los datos ingresados. detallePrenda e informacionAdicional son campos opcionales de la clase Prenda
        /// Talle forma parte de Confecciones ahora, ya que la tanda va a depender del talle, y no se pueden crear 5
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="cantidadPrendasHora"></param>
        /// <param name="detallePrenda"></param>
        /// <param name="informacionAdicional"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Prenda CrearPrenda(CategoriaPrenda categoria, int cantidadPrendasHora, string detallePrenda, string informacionAdicional)
        {
            Prenda PrendaCreada;

            if (!string.IsNullOrEmpty(detallePrenda) && !string.IsNullOrEmpty(informacionAdicional))
            {
                PrendaCreada = new(categoria, cantidadPrendasHora, detallePrenda, informacionAdicional);

            }
            else if (!string.IsNullOrEmpty(detallePrenda) && string.IsNullOrEmpty(informacionAdicional))
            {
                PrendaCreada = new(categoria, cantidadPrendasHora, detallePrenda);
            }
            else if (string.IsNullOrEmpty(detallePrenda) && !string.IsNullOrEmpty(informacionAdicional))
            {
                PrendaCreada = new(categoria, cantidadPrendasHora, informacionAdicional);
            }
            else
            {
                PrendaCreada = new(categoria, cantidadPrendasHora);
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

        public static bool AgregarPrendaConfeccion_Diccionario(Confeccion unaConfeccion)
        {
            try
            {
                if (unaConfeccion is not null)
                {
                    if (ControlConfecciones.EncontrarConfeccion(unaConfeccion))
                    {
                        foreach (KeyValuePair<DateTime, List<Confeccion>> par in GestionDatos.ConfeccionesPorFecha)
                        {
                            List<Confeccion> confecciones = par.Value;
                            foreach (Confeccion confeccion in confecciones)
                            {
                                if (confeccion is not null)
                                {
                                    confecciones.Add(unaConfeccion);
                                    GestionDatos.ConfeccionesPorFecha[unaConfeccion.FechaFinal] = confecciones;
                                }
                                else
                                {
                                    throw new NullReferenceException("Se encontro una confeccion invalida.");
                                }
                            }
                        }
                        return true;
                    }
                    else
                    {
                        throw new Exception("La prenda que queres agregar, ya existe en el sistema");
                    }
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

        public static bool TieneEntrega(DateTime fecha, out Confeccion? _confeccionEntrega)
        {
            List<Confeccion> Confecciones = new();
            if (Confecciones is not null)
            {
                if (GestionDatos.ConfeccionesPorFecha.ContainsKey(fecha) && GestionDatos.ConfeccionesPorFecha.TryGetValue(fecha, out Confecciones))
                {
                    foreach(Confeccion confeccion in Confecciones)
                    {
                        if(confeccion.FechaFinal == fecha)
                        {
                            _confeccionEntrega = confeccion;
                            return true;
                        }
                    }
                }
                else
                {
                    throw new Exception("Hubo un problema buscando la fecha en el sistema");
                }
                _confeccionEntrega = null;
                return false;
            }
            else
            {
                throw new NullReferenceException();
            }
        }



    }
}
