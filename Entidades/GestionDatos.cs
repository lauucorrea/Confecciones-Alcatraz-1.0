namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasCreadas;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static List<Prenda>? _prendasParaConfeccion;
        private static Dictionary<DateTime, List<Confeccion>>? _confeccionesPorFecha;

        static GestionDatos()
        {
            PrendasCreadas = new();
            ConfeccionesPorFecha = new();
            _prendasParaConfeccion = new();
        }

        public static List<Prenda> PrendasCreadas
        {
            get
            {
                if (_prendasCreadas is not null)
                {

                    return _prendasCreadas;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _prendasCreadas = value;
        }
        public static Dictionary<DateTime, List<Confeccion>> ConfeccionesPorFecha
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

        public static List<Prenda> PrendasParaConfeccion
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
