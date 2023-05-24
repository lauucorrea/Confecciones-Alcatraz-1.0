namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasSistema;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static SortedDictionary<Prenda, TallePrenda>? _prendasParaConfeccion;
        private static SortedDictionary<DateTime, List<Confeccion>>? _confeccionesPorFecha;
        private static List<Confeccion>? _confeccionesConEntregas;
        static GestionDatos()
        {
            PrendasSistema = new();
            ConfeccionesPorFecha = new();
            PrendasParaConfeccion = new();

        }

        public static List<Prenda> PrendasSistema
        {
            get
            {
                if (_prendasSistema is not null)
                {

                    return _prendasSistema;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _prendasSistema = value;
        }
        public static SortedDictionary<DateTime, List<Confeccion>> ConfeccionesPorFecha
        {
            get
            {
                if (_confeccionesPorFecha is not null)
                {

                    return _confeccionesPorFecha;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _confeccionesPorFecha = value;
        }

        public static List<Confeccion>? ConfeccionesConEntregas
        {
            get
            {

                return _confeccionesConEntregas;

            }
            set => _confeccionesConEntregas = value;
        }
        public static SortedDictionary<Prenda, TallePrenda> PrendasParaConfeccion
        {
            get
            {
                if (_prendasParaConfeccion is not null)
                {

                    return _prendasParaConfeccion;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _prendasParaConfeccion = value;
        }


    }
}
