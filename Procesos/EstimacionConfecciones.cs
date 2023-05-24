using Entidades;
namespace Procesos
{
    public static class EstimacionConfecciones
    {

        public static int CalcularTiempoConfeccion(SortedDictionary<Prenda, TallePrenda> PrendasConfeccion, int cantidadPrendasRequeridas, int horasJornada)
        {
            try
            {

                int cantidadDiasProduccion;
                int totalHorasProduccion;

                if (PrendasConfeccion is not null && PrendasConfeccion.Count > 0)
                {
                    int totalPrendasHora = 0;

                    foreach (KeyValuePair<Prenda, TallePrenda> par in PrendasConfeccion)
                    {
                        Prenda prenda = par.Key;

                        if (prenda is not null)
                        {
                            totalPrendasHora += prenda.PrendasHora;
                        }


                    }
                    if (totalPrendasHora != 0)
                    {
                        totalHorasProduccion = cantidadPrendasRequeridas / totalPrendasHora;

                        cantidadDiasProduccion = totalHorasProduccion / horasJornada;
                    }
                    else
                    {
                        cantidadDiasProduccion = -1;
                    }
                }
                else
                {
                    throw new NullReferenceException("La lista de prendas no esta cargada");
                }
                return cantidadDiasProduccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        


    }
}

