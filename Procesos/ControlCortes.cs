using Entidades;
namespace Procesos
{
    public static class ControlCortes
    {
        private static List<Corte>? _cortesConEntregas;
        public static List<Corte>? CortesConEntregas
        {
            get
            {

                return _cortesConEntregas;

            }
            set => _cortesConEntregas = value;
        }


        public static List<Corte>? ObtenerEntregasEnDias(DateTime fechaSeleccionada, int cantidadDiasProduccion)
        {
            try
            {
                List<DateTime> fechasEvaluadas = new();

                List<Corte>? entregasObtenidas = new();
                DateTime diaRecorrido = fechaSeleccionada;

                for (int diasRecorridos = 1; diasRecorridos <= cantidadDiasProduccion; diasRecorridos++)
                {
                    if (diasRecorridos > cantidadDiasProduccion)
                    {
                        break;
                    }
                    else
                    {
                        fechasEvaluadas.Add(diaRecorrido);

                        if (fechasEvaluadas.Count == cantidadDiasProduccion)
                        {
                            //aca terminamos de evaluar todos los dias que hay desde la fecha de hoy hasta la fecha final
                            entregasObtenidas = BuscarEntregas(fechasEvaluadas);
                        }
                        diaRecorrido = diaRecorrido.AddDays(1);
                    }
                }
                return entregasObtenidas;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        /// <summary>
        /// recibe un listado de fechas para ver si hay entregas en esos dias
        /// </summary>
        /// <param name="fechasParaProduccion"></param>
        /// <returns></returns>
        public static List<Corte> BuscarEntregas(List<DateTime> fechasParaProduccion)
        {
            List<DateTime> fechasOrdenadas = fechasParaProduccion.OrderBy(fecha => fecha).ToList();
            int contadorFechasValidas = 0;

            List<Corte>? confeccionesEncontradasConEntrega = new();

            List<Corte> listaRetorno = new();
            foreach (DateTime fechaProduccion in fechasOrdenadas)
            {
                confeccionesEncontradasConEntrega = ObtenerCortesEntrega(fechaProduccion);

                if(confeccionesEncontradasConEntrega is not null)
                {
                    listaRetorno.AddRange(confeccionesEncontradasConEntrega.ToArray());
                }

            }

            return confeccionesEncontradasConEntrega;
        }
        /// <summary>
        /// Este metodo me avisa si el corte tiene fecha de entrega coincidente con el Datetime
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="CorteConEntrega"></param>
        /// <returns>true si tiene entrega, false si no</returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="NullReferenceException">La lista de cortes del corte </exception>
        public static List<Corte> ObtenerCortesEntrega(DateTime fecha)
        {
            List<Corte>? Cortes = new();

            foreach (Corte corte in GestionDatos.CortesSistema)
            {
                if (corte.FechaFinal == fecha)
                {
                    Cortes.Add(corte);
                }
            }

            return Cortes;

        }
    }
}
