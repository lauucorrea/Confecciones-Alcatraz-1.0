
namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasSistema;
        private static List<Persona>? _personasSistema;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static List<Prenda>? _prendasParaCortes;
        private static List<Corte> _cortesSistema;

        private static List<DateTime> _diasNoLaborales;
        private static Dictionary<string, List<Prenda>> calendarioPrendasCorte;
        static GestionDatos()
        {
            PrendasSistema = new();
            CortesSistema = new();
            PrendasParaCortes = new();
            PersonasSistema = new();
            CalendarioPrendasCorte = new();
            DiasNoLaborales = new();
            HardcodeListas();

        }

        public static List<DateTime> DiasNoLaborales
        {
            get
            {
                if (_diasNoLaborales is not null)
                {

                    return _diasNoLaborales;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _diasNoLaborales = value;
        }
        public static Dictionary<string, List<Prenda>> CalendarioPrendasCorte
        {
            get
            {
                if (calendarioPrendasCorte is not null)
                {

                    return calendarioPrendasCorte;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => calendarioPrendasCorte = value;
        }
        public static List<Persona> PersonasSistema
        {
            get
            {
                if (_personasSistema is not null)
                {

                    return _personasSistema;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _personasSistema = value;
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
        public static List<Corte> CortesSistema
        {
            get
            {
                if (_cortesSistema is not null)
                {

                    return _cortesSistema;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _cortesSistema = value;
        }

        public static List<Prenda> PrendasParaCortes
        {
            get
            {
                if (_prendasParaCortes is not null)
                {

                    return _prendasParaCortes;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _prendasParaCortes = value;
        }
        public static void HardcodeListas()
        {

            List<DateTime> diasno = CrearDiasNoLaborales();

            if(diasno is not null)
            {
                DiasNoLaborales = diasno;
            }
            else
            {
                throw new Exception("No se pudo obtener las fechas no laborales");
            }


        }


        public static List<DateTime> CrearDiasNoLaborales()
        {
            List<DateTime> feriados = new()
                {
                    // 1 de enero - Año nuevo
                    new DateTime(DateTime.Now.Year, 1, 1),

                    // 20 de febrero - Carnaval
                    new DateTime(DateTime.Now.Year, 2, 20),

                    // 21 de febrero - Carnaval
                    new DateTime(DateTime.Now.Year, 2, 21),

                    // 24 de marzo - Día Nacional de la Memoria por la Verdad y la Justicia
                    new DateTime(DateTime.Now.Year, 3, 24),

                    // 2 de abril - Día del Veterano y de los Caídos en la Guerra de Malvinas
                    new DateTime(DateTime.Now.Year, 4, 2),

                    // 7 de abril - Viernes Santo
                    new DateTime(DateTime.Now.Year, 4, 7),

                    // 1 de mayo - Día del Trabajador
                    new DateTime(DateTime.Now.Year, 5, 1),

                    // 25 de mayo - Día de la Revolución de Mayo
                    new DateTime(DateTime.Now.Year, 5, 25),

                    // 20 de junio - Paso a la Inmortalidad del General Manuel Belgrano
                    new DateTime(DateTime.Now.Year, 6, 20),

                    // 9 de julio - Día de la Independencia
                    new DateTime(DateTime.Now.Year, 7, 9),

                    // 8 de diciembre - Día de la Inmaculada Concepción de María
                    new DateTime(DateTime.Now.Year, 12, 8),

                    // 25 de diciembre - Navidad
                    new DateTime(DateTime.Now.Year, 12, 25),

                    new DateTime(DateTime.Now.Year, 9, 21)

            };

            return feriados;
        }
    }
}
