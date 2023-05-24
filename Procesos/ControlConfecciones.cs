using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Procesos
{
    public static class ControlConfecciones
    {
        public static bool EncontrarConfeccion(Confeccion confeccionBuscada)
        {
            try
            {
                if (confeccionBuscada is not null)
                {

                    foreach (KeyValuePair<DateTime, List<Confeccion>> par in GestionDatos.ConfeccionesPorFecha)
                    {
                        List<Confeccion> confecciones = par.Value;
                        if (confecciones.Contains(confeccionBuscada))
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

        public static List<Confeccion>? ObtenerEntregasEnDias(DateTime fechaSeleccionada, int cantidadDiasProduccion)
        {
            try
            {
                List<DateTime> fechasEvaluadas = new();

                List<Confeccion>? entregasObtenidas = new();
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

        public static List<Confeccion> BuscarEntregas(List<DateTime> fechasParaProduccion)
        {
            List<DateTime> fechasOrdenadas = fechasParaProduccion.OrderBy(fecha => fecha).ToList();
            int contadorFechasValidas = 0;

            Confeccion? confeccionEntregaEncontrada = null;

            List<Confeccion>? confeccionesEncontradasConEntrega = new();
            foreach (DateTime fechaProduccion in fechasOrdenadas)
            {
                foreach (DateTime fechaConfecciones in GestionDatos.ConfeccionesPorFecha.Keys)
                {
                    if (fechaProduccion == fechaConfecciones)
                    {
                        if (!Administracion.TieneEntrega(fechaConfecciones, out confeccionEntregaEncontrada))
                        {
                            contadorFechasValidas++;
                        }
                        else if (confeccionEntregaEncontrada is not null)
                        {
                            confeccionesEncontradasConEntrega.Add(confeccionEntregaEncontrada);
                        }
                    }
                }
            }

            return confeccionesEncontradasConEntrega;
        }

    }
}
