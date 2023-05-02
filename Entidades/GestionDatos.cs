namespace Entidades
{
    public static class GestionDatos
    {
        private static List<Prenda>? _prendasCreadas;

        static GestionDatos()
        {
            PrendasCreadas = new();
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

       
    }
}
