using System.ComponentModel.Design;
using System.Text;

namespace Entidades
{
    public enum TallePrenda
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL
    }
    

    public class Corte
    {
        private DateTime _fechaFinal;
        private DateTime _fechaInicio;
       
        private int _horasTotalesCorte;
        private SortedDictionary<TallePrenda, List<Prenda>> _prendasEnConfeccion;
        private int _identificadorDeConfeccion;
        private static int _contadorConfecciones;
        static Corte()
        {
            _contadorConfecciones = 0;

        }
        public Corte()
        {
        }
        public Corte(DateTime fechaFinal, DateTime fechaInicio):this()
        {
           // PrendasEnConfeccion = new();
            FechaFinal = fechaFinal;
            FechaInicio = fechaInicio;
            _contadorConfecciones++;
            IdentificadorDeConfeccion = _contadorConfecciones;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("Fecha de entrega: ");
            sb.AppendLine(FechaFinal.ToString());
            sb.AppendLine("Fecha de inicio: ");
            sb.AppendLine(FechaInicio.ToString());
            if (PrendasEnConfeccion is not null)
            {

                foreach (KeyValuePair<TallePrenda, List<Prenda>> par in PrendasEnConfeccion)
                {
                    foreach (Prenda prenda in par.Value)
                    {
                        for(int i = 1; i <= par.Value.Count() ; i++)
                        {
                            sb.AppendLine("Prenda "+ i);
                            sb.AppendLine(prenda.ToString());
                            sb.AppendLine(prenda.Etapa.ToString());
                        }
                    }
                }
            }
            
            

            return sb.ToString();
        }

       
        public int HorasTotalesCorte
        {
            get => _horasTotalesCorte;
            set => _horasTotalesCorte = value;
        }
        public SortedDictionary<TallePrenda, List<Prenda>> PrendasEnConfeccion
        {
            set
            {
                _prendasEnConfeccion = value;
            }
            get
            {
                    return _prendasEnConfeccion;
            }
        }

        public DateTime FechaFinal
        {
            get => _fechaFinal;
            set => _fechaFinal = value;
        }
        public DateTime FechaInicio
        {
            get => _fechaInicio;
            set => _fechaInicio = value;
        }

        public int IdentificadorDeConfeccion
        {
            get => _identificadorDeConfeccion;
            set => _identificadorDeConfeccion = value;
        }

        public void ObtenerHorasTotalesCorte()
        {
            HorasTotalesCorte = 0;
            if (PrendasEnConfeccion is not null)
            {
                foreach (KeyValuePair<TallePrenda, List<Prenda>> par in PrendasEnConfeccion)
                {
                    foreach (Prenda prenda in par.Value)
                    {
                        HorasTotalesCorte += prenda.HorasProduccion;
                    }
                }
            }

        }
        public bool EncontrarPrenda(Prenda prendaBuscada)
        {

            if (this is not null)
            {
                if (prendaBuscada is not null)
                {
                    if (PrendasEnConfeccion is not null && PrendasEnConfeccion.Count > 0)
                    {
                        foreach (KeyValuePair<TallePrenda, List<Prenda>> par in PrendasEnConfeccion)
                        {
                            if (par.Value.Contains(prendaBuscada))
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new NullReferenceException("La prenda que buscas no es valida");
                }
            }
            else
            {
                throw new NullReferenceException("El corte no es valido");
            }
            return false;
        }

    }
}
