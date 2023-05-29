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
    public enum CondicionEntrega
    {
        Programado,
        Procesando,
        Terminado,
        Entregado,
        Suspendido
    }

    public class Confeccion
    {
        private DateTime _fechaFinal;
        private DateTime _fechaInicio;
        private CondicionEntrega _condicion;
        private TallePrenda _talle;
        private List<Prenda>? _prendasEnConfeccion;
        private int _identificadorDeConfeccion;
        private static int _contadorConfecciones;
        static Confeccion()
        {
            _contadorConfecciones = 0;
            
        }
        public Confeccion(TallePrenda talle, CondicionEntrega condicion)
        {
            PrendasEnConfeccion = new();
            Talle = talle;
            Condicion = condicion;
        }
        public Confeccion(TallePrenda talle, CondicionEntrega condicion, DateTime fechaFinal, DateTime fechaInicio) : this(talle, condicion)
        {
            PrendasEnConfeccion = new();
            FechaFinal = fechaFinal;
            FechaInicio = fechaInicio;
        }
        public Confeccion(TallePrenda talle, CondicionEntrega condicion, DateTime fechaFinal, DateTime fechaInicio, List<Prenda> prendasEnConfeccion) : this(talle, condicion, fechaFinal, fechaInicio)
        {
            try
            {
                if (prendasEnConfeccion is not null && prendasEnConfeccion.Count > 0)
                {
                    PrendasEnConfeccion = prendasEnConfeccion;
                    _contadorConfecciones++;
                    IdentificadorDeConfeccion = _contadorConfecciones;
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
        
        public CondicionEntrega Condicion
        {
            get => _condicion;
            set => _condicion = value;
        }
        public List<Prenda> PrendasEnConfeccion
        {
            get
            {
                if (_prendasEnConfeccion is not null)
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

        public int IdentificadorDeConfeccion
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
