using Entidades;
namespace Procesos
{
    public static class EstimacionCortes
    {

        public static int CalcularHorasCorte(SortedDictionary<TallePrenda, List<Prenda>> PrendasCorte, int cantidadPrendasRequeridas)
        {
            try
            {

                int totalHorasProduccion;

                if (PrendasCorte is not null && PrendasCorte.Count > 0)
                {
                    int totalPrendas = 0;
                    int totalHoras = 0;

                    foreach (KeyValuePair<TallePrenda, List<Prenda>> par in PrendasCorte)
                    {
                        List<Prenda> prendas = par.Value;

                        foreach (Prenda prenda in prendas)
                        {
                            if (prenda is not null)
                            {
                                totalPrendas += prenda.CantidadPrendas;
                                totalHoras += prenda.HorasProduccion;
                            }
                        }


                    }
                    if (totalPrendas != 0 && totalHoras != 0)
                    {
                        totalHorasProduccion = (cantidadPrendasRequeridas * totalHoras) / totalPrendas;

                    }
                    else
                    {
                        totalHorasProduccion = -1;
                    }
                }
                else
                {
                    throw new NullReferenceException("La lista de prendas no esta cargada");
                }
                return totalHorasProduccion;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}

