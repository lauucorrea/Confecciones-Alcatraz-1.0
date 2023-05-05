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
    public class Confeccion
    {
        private DateTime _fechaFinal;
        private DateTime _fechaInicio;
        private CondicionEntrega _condicion;
        private TallePrenda _talle;
        private List<Prenda>? _prendasEnConfeccion;
        private static int _identificadorDeConfeccion;

        static Confeccion()
        {
            IdentificadorDeConfeccion = 0;
        }
        public Confeccion(TallePrenda talle, CondicionEntrega condicion)
        {
            IdentificadorDeConfeccion++;
            Talle = talle;
            Condicion = condicion;
        }
        public Confeccion(TallePrenda talle, CondicionEntrega condicion, DateTime fechaFinal, DateTime fechaInicio):this(talle,condicion)
        {
            FechaFinal = fechaFinal;
            FechaInicio = fechaInicio;
        }
        public Confeccion(TallePrenda talle, CondicionEntrega condicion, DateTime fechaFinal, DateTime fechaInicio, List<Prenda> prendasEnConfeccion):this(talle,condicion, fechaFinal, fechaInicio)
        {
                try
                {
                    if (prendasEnConfeccion is not null && prendasEnConfeccion.Count > 0)
                    {
                        PrendasEnConfeccion = prendasEnConfeccion;
                    }
                    else
                    {
                        throw new NullReferenceException("Debe agregar al menos una prenda para crear la confeccion");
                    }
                }
                catch (NullReferenceException ex)
                {
                    throw new Exception("Ocurrio un error: " + ex.Message);
                }
            }
        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(Talle.ToString());
            sb.AppendLine(Condicion.ToString());

            return sb.ToString();
        }
        public enum CondicionEntrega
        {
            Procesando,
            Entregado,
            Suspendido
        }

        public CondicionEntrega Condicion
        {
            get => _condicion;
            set => _condicion = value;
        }
        public List<Prenda> PrendasEnConfeccion
        {
            get
            {
                if(_prendasEnConfeccion is not null)
                {
                    return _prendasEnConfeccion;
                }
                else
                {
                    throw new Exception("No hay datos registrados de prendas");
                }
            }
            set => _prendasEnConfeccion = value;
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

        public static int IdentificadorDeConfeccion
        {
            get => _identificadorDeConfeccion;
            set => _identificadorDeConfeccion = value;
        }

        public TallePrenda Talle
        {
            get => _talle;
            set => _talle = value;
        }
    }
}
