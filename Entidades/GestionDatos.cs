
namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasSistema;
        private static List<Persona>? _personasSistema;
        //se limpia cuando se apreta el boton de agregar confeccion
        private static SortedDictionary<TallePrenda,List<Corte>>? _prendasParaCortes;
        private static SortedDictionary<DateTime, List<Corte>>? _cortesPorFecha;
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

            Persona roberto = new("Roberto", "Correa", 50666452,"Rober","asd123");
            roberto.RolPersona = Rol.Propietario;

            PersonasSistema.Add(roberto);



            PrendasSistema.Add(prenda1);
            PrendasSistema.Add(prenda2);
            PrendasSistema.Add(prenda3);
            PrendasSistema.Add(prenda4);

            //creo un corte ficticio
            Corte corte1 = new(EtapaCorte.Tizando, new DateTime(2023, 5, 25), new DateTime(2023, 5, 10));
            
            Administracion.AgregarPrenda_Corte(corte1, prenda1);
            Administracion.AgregarPrenda_Corte(corte1, prenda2);
            Administracion.AgregarPrenda_Corte(corte1, prenda3);
            Administracion.AgregarPrenda_Corte(corte1, prenda4);
            corte1.ObtenerHorasTotalesCorte();

            Administracion.AgregarCorte_Diccionario(corte1);
            
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
        public static SortedDictionary<DateTime, List<Corte>> CortesPorFecha
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


        public static SortedDictionary<TallePrenda,List<Corte>> PrendasParaCortes
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


    }
}
