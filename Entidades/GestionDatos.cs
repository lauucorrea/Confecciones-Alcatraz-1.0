
namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasSistema;
        private static List<Persona>? _personasSistema;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static SortedDictionary<TallePrenda, List<Corte>>? _prendasParaCortes;
        private static Dictionary<DateTime, List<Corte>>? _cortesPorFecha;
        private static List<Corte>? _cortesConEntregas;

        static GestionDatos()
        {
            PrendasSistema = new();
            CortesPorFecha = new();
            PrendasParaCortes = new();
            PersonasSistema = new();
            CortesConEntregas = new();
            
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
        public static Dictionary<DateTime, List<Corte>> CortesPorFecha
        {
            get
            {
                if (_cortesPorFecha is not null)
                {

                    return _cortesPorFecha;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _cortesPorFecha = value;
        }
        public static List<Corte> CortesConEntregas
        {
            get
            {
                if (_cortesConEntregas is not null)
                {

                    return _cortesConEntregas;
                }
                else
                {
                    throw new NullReferenceException();
                }

            }
            set => _cortesConEntregas = value;
        }


        public static SortedDictionary<TallePrenda, List<Corte>> PrendasParaCortes
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
            Prenda prenda1 = new(CategoriaPrenda.Remera, 300, 8);
            prenda1.TallePrenda = TallePrenda.M;
            Prenda prenda2 = new(CategoriaPrenda.Pantalon, 500, 15);
            prenda2.TallePrenda = TallePrenda.M;
            Prenda prenda3 = new(CategoriaPrenda.Campera, 350, 12);
            prenda3.TallePrenda = TallePrenda.L;
            Prenda prenda4 = new(CategoriaPrenda.Chomba, 300, 9);
            prenda4.TallePrenda = TallePrenda.XL;

            Persona roberto = new("Roberto", "Correa", 50666452, "Rober", "asd123");

            roberto.DiasLaborales = new(){
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"
            };

            // Ejemplo 1
            Persona persona1 = new Persona
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Dni = 51888999,
                Usuario = "juanperez",
                Password = "secreto",
                RolPersona = Rol.Empleado
            };

            // Ejemplo 2
            Persona persona2 = new Persona
            {
                Nombre = "María",
                Apellido = "Gómez",
                Dni = 52888999,
                Usuario = "mariagomez",
                Password = "password",
                RolPersona = Rol.Administrador
            };

            // Ejemplo 3
            Persona persona3 = new Persona
            {
                Nombre = "Carlos",
                Apellido = "López",
                Dni = 53888999,
                Usuario = "carloslopez",
                Password = "123456",
                RolPersona = Rol.Propietario
            };

            // Ejemplo 4
            Persona persona4 = new Persona
            {
                Nombre = "Laura",
                Apellido = "Rodríguez",
                Dni = 54888999,
                Usuario = "laurarodriguez",
                Password = "abcd1234",
                RolPersona = Rol.Empleado
            };

            // Ejemplo 5
            Persona persona5 = new Persona
            {
                Nombre = "Pedro",
                Apellido = "Martínez",
                Dni = 55888999,
                Usuario = "pedromartinez",
                Password = "qwerty",
                RolPersona = Rol.Administrador
            };

            // Ejemplo 6
            Persona persona6 = new Persona
            {
                Nombre = "Ana",
                Apellido = "Sánchez",
                Dni = 56888999,
                Usuario = "anasanchez",
                Password = "abc123",
                RolPersona = Rol.Propietario
            };

            // Ejemplo 7
            Persona persona7 = new Persona
            {
                Nombre = "Luis",
                Apellido = "Torres",
                Dni = 57888999,
                Usuario = "luistorres",
                Password = "p@ssw0rd",
                RolPersona = Rol.Empleado
            };

            // Ejemplo 8
            Persona persona8 = new Persona
            {
                Nombre = "Marta",
                Apellido = "Fernández",
                Dni = 58888999,
                Usuario = "martafdez",
                Password = "martita123",
                RolPersona = Rol.Administrador
            };

            // Ejemplo 9
            Persona persona9 = new Persona
            {
                Nombre = "Roberto",
                Apellido = "Ramírez",
                Dni = 59888999,
                Usuario = "robertramirez",
                Password = "987654",
                RolPersona = Rol.Propietario
            };
            roberto.RolPersona = Rol.Propietario;
            TimeSpan horasTrabajo = roberto.HorarioCierre.Subtract(roberto.HorarioApertura);
            roberto.HorasJornada = (int)horasTrabajo.TotalHours;

            PersonasSistema.Add(roberto);
            PersonasSistema.Add(persona1);
            PersonasSistema.Add(persona2);
            PersonasSistema.Add(persona3);
            PersonasSistema.Add(persona4);
            PersonasSistema.Add(persona5);
            PersonasSistema.Add(persona6);
            PersonasSistema.Add(persona7);
            PersonasSistema.Add(persona8);
            PersonasSistema.Add(persona9);

            PrendasSistema.Add(prenda1);
            PrendasSistema.Add(prenda2);
            PrendasSistema.Add(prenda3);
            PrendasSistema.Add(prenda4);

            //creo un corte ficticio
            Corte corte1 = new(new DateTime(2023, 7, 25), new DateTime(2023, 7, 25));

            Administracion.AgregarPrenda_Corte(corte1, prenda1);
            Administracion.AgregarPrenda_Corte(corte1, prenda3);
            Administracion.AgregarPrenda_Corte(corte1, prenda4);

            Corte corte2 = new(new DateTime(2023, 8, 25), new DateTime(2023, 7, 3));

            Administracion.AgregarPrenda_Corte(corte2, prenda1);
            Administracion.AgregarPrenda_Corte(corte2, prenda2);

            Corte corte3 = new( new DateTime(2023, 8, 25), new DateTime(2023, 7, 4));

            Administracion.AgregarPrenda_Corte(corte3, prenda3);
            Administracion.AgregarPrenda_Corte(corte3, prenda4);

            Corte corte4 = new(new DateTime(2023, 8, 25), DateTime.Now.Date);

            Administracion.AgregarPrenda_Corte(corte4, prenda1);
            Administracion.AgregarPrenda_Corte(corte4, prenda2);;
            Administracion.AgregarPrenda_Corte(corte4, prenda4);

            Corte corte5 = new(new DateTime(2023, 8, 25), new DateTime(2023, 7, 5));

            Administracion.AgregarPrenda_Corte(corte5, prenda2);
            Administracion.AgregarPrenda_Corte(corte5, prenda3);
            Administracion.AgregarPrenda_Corte(corte5, prenda4);

            Corte corte6 = new(new DateTime(2023, 8, 24), new DateTime(2023, 7, 6));

            Administracion.AgregarPrenda_Corte(corte6, prenda1);
            Administracion.AgregarPrenda_Corte(corte6, prenda2);
            Administracion.AgregarPrenda_Corte(corte6, prenda3);

            Corte corte7 = new(new DateTime(2023, 8, 25), DateTime.Now.Date);

            Administracion.AgregarPrenda_Corte(corte7, prenda1);
            Administracion.AgregarPrenda_Corte(corte7, prenda3);
            Administracion.AgregarPrenda_Corte(corte7, prenda4);


            corte1.ObtenerHorasTotalesCorte();
            corte2.ObtenerHorasTotalesCorte();
            corte3.ObtenerHorasTotalesCorte();
            corte4.ObtenerHorasTotalesCorte();
            corte5.ObtenerHorasTotalesCorte();
            corte6.ObtenerHorasTotalesCorte();
            corte7.ObtenerHorasTotalesCorte();

            Administracion.AgregarCorte_Diccionario(corte1);
            Administracion.AgregarCorte_Diccionario(corte2);
            Administracion.AgregarCorte_Diccionario(corte3);
            Administracion.AgregarCorte_Diccionario(corte4);
            Administracion.AgregarCorte_Diccionario(corte5);
            Administracion.AgregarCorte_Diccionario(corte6);
            Administracion.AgregarCorte_Diccionario(corte7);

        }

       


    }
}
