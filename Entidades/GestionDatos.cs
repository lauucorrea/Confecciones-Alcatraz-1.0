namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasSistema;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static Dictionary<Prenda, TallePrenda>? _prendasParaConfeccion;
        private static Dictionary<DateTime, List<Confeccion>>? _confeccionesPorFecha;
        
        static GestionDatos()
        {
            PrendasSistema = new();
            ConfeccionesPorFecha = new();
            _prendasParaConfeccion = new();
            
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

        public static Dictionary<Prenda, TallePrenda> PrendasParaConfeccion
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
