
namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasSistema;
        private static List<Persona>? _personasSistema;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static List<Prenda>? _prendasParaCortes;
        private static List<Corte> _cortesSistema;
        private static Dictionary<Prenda, List<DateTime>> calendarioPrendasCorte;
        static GestionDatos()
        {
            PrendasSistema = new();
            CortesSistema = new();
            PrendasParaCortes = new();
            PersonasSistema = new();

            HardcodeListas();

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
            Prenda prenda1 = new(CategoriaPrenda.Remera, 300, 8)
            {
                TallePrenda = TallePrenda.M
            };
            Prenda prenda2 = new(CategoriaPrenda.Pantalon, 500, 15)
            {
                TallePrenda = TallePrenda.M
            };
            Prenda prenda3 = new(CategoriaPrenda.Campera, 350, 12)
            {
                TallePrenda = TallePrenda.L
            };
            Prenda prenda4 = new(CategoriaPrenda.Chomba, 300, 9)
            {
                TallePrenda = TallePrenda.XL
            };

            Persona roberto = new("Roberto", "Correa", 50666452, "Rober", "asd123")
            {
                DiasLaborales = new(){
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"
            }
            };

            // Ejemplo 1
            Persona persona1 = new()
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Dni = 51888999,
                Usuario = "juanperez",
                Password = "secreto",
                RolPersona = Rol.Empleado,
                DiasLaborales = new(){
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"
            }

            };


            roberto.RolPersona = Rol.Propietario;
            TimeSpan horasTrabajo = roberto.HorarioCierre.Subtract(roberto.HorarioApertura);
            roberto.HorasJornada = (int)horasTrabajo.TotalHours;

            PersonasSistema.Add(roberto);
            PersonasSistema.Add(persona1);

            PrendasSistema.Add(prenda1);
            PrendasSistema.Add(prenda2);
            PrendasSistema.Add(prenda3);
            PrendasSistema.Add(prenda4);



        }




    }
}
