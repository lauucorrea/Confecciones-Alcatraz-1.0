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
        private DateTime _fechaEstimada;
        private CondicionEntrega _condicion;
        private TallePrenda _talle;
        private List<Prenda> _prendasEnConfeccion;
        private static int _identificadorDeConfeccion;

        static Confeccion()
        {
            IdentificadorDeConfeccion = 0;
        }
        public Confeccion(DateTime fechaEstimada, TallePrenda talle, CondicionEntrega condicion, List<Prenda> prendasEnConfeccion)
        {
            FechaEstimada = fechaEstimada;
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

        public DateTime FechaEstimada
        {
            get => _fechaEstimada;
            set => _fechaEstimada = value;
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
