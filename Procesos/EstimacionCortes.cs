using Entidades;
namespace Procesos
{
    public static class EstimacionCortes
    {


        public static List<DateTime> ObtenerFechasPosibles(int horasJornada, List<Prenda> prendas)
        {
            List<DateTime> fechasPosibles = new();
            int diasPreparacion = 0;
            bool seEncontroRango = false;
            DateTime fechaActual;
            DateTime fechaRecorrida;
            Corte? corteConFinal = null;

            if (prendas is not null)
            {

                foreach (Prenda prenda in prendas)
                {
                    diasPreparacion += (int)Math.Ceiling(prenda.TiempoFinalEtapa / 24);
                }

                if (GestionDatos.CortesSistema is not null && GestionDatos.CortesSistema.Count > 0)
                {
                    //ordeno las fechas de los cortes registrados en el sistema
                    GestionDatos.CortesSistema.Sort((corte1, corte2) => corte1.FechaInicio.CompareTo(corte2.FechaInicio));
                    //cuando vamos a definir fecha final, es importante que esta fecha tenga las horas registradas del ultimo dia solo para verificar si se pueden ocupar
                    fechaActual = GestionDatos.CortesSistema[^1].FechaFinal;

                }
                else
                {
                }
                fechaActual = DateTime.Now;
                //Mientras no se haya encontrado rango, se sigue buscando
                while (!seEncontroRango)
                {
                    int contadorHabiles = 0;

                    //primer paso, encontrar el primer dia y sumarle fechas
                    fechasPosibles = Administracion.ObtenerListaFechasEnRango(fechaActual, fechaActual.AddDays(diasPreparacion));
                    fechaRecorrida = fechaActual;

                    //este while es el bloque que verifica si me sirve o no el rango
                    while (contadorHabiles < diasPreparacion)
                    {
                        //le agregamos un dia al dia que estamos recorriendo
                        fechaRecorrida = fechaRecorrida.AddDays(1);

                        //buscamos si hay fecha final. obtengo por puntero el corte si lo encontre
                        if (!Administracion.ExisteFechaFinalEnCortes(fechaRecorrida, out corteConFinal))
                        {
                            //si no tiene fecha final ese dia, lo contamos como valido
                            contadorHabiles++;
                        }
                        else if (corteConFinal is not null)
                        {
                            //si tiene fecha final,me fijo cuantas horas ocupadas tiene cargadas

                            int horasOcupadas = corteConFinal.FechaFinal.Hour;

                            //si las horas ocupadas son menores a los de la jornada, ese dia me sirve
                            if (horasOcupadas < horasJornada)
                            {
                                contadorHabiles++;
                            }
                            else
                            {
                                fechaActual = fechaActual.AddDays(1);
                                break;

                            }
                        }
                    }

                    if (contadorHabiles >= diasPreparacion)
                    {
                        seEncontroRango = true;
                    }
                }

            }
            else
            {
                throw new Exception("Deben elegirse prendas antes de crear el corte");
            }
            
            return fechasPosibles;
        }


        public static List<DateTime> ReacomodoPorFeriados(List<DateTime> fechasObtenidas)
        {
            List<DateTime> fechasFinal = new();
            bool seCompleto = false;
            DateTime fechaActual = fechasObtenidas[0];
            int contadorFeriados = 0;
            int diasCorte;
            while (!seCompleto)
            {
                if (!Administracion.EsDiaFeriado(fechaActual))
                {
                    fechasFinal.Add(fechaActual);
                    diasCorte = fechasFinal.Count + contadorFeriados;

                    if (diasCorte == fechasObtenidas.Count)
                    {
                        seCompleto = true; 
                    }
                }
                else
                {
                    contadorFeriados++;
                }

                fechaActual = fechaActual.AddDays(1);
            }
            return fechasFinal;
        }

        

    }
}

