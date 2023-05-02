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
        private List<Prenda> _prendasEnConfeccion;
        private static int _identificadorDeConfeccion;

        static Confeccion()
        {
            IdentificadorDeConfeccion = 0;
        }
        public Confeccion(DateTime fechaFinal,DateTime fechaInicio, TallePrenda talle, CondicionEntrega condicion, List<Prenda> prendasEnConfeccion)
        {
            FechaFinal = fechaFinal;
            FechaInicio = fechaInicio;
            Condicion = condicion;
            PrendasEnConfeccion = prendasEnConfeccion;
            IdentificadorDeConfeccion++;
            Talle = talle;
        }

        public enum CondicionEntrega
        {
            Confeccionando,
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
            get => _prendasEnConfeccion;
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
