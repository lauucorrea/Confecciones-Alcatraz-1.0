using System.Text;

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

    [Serializable]
    public class Corte
    {
        private DateTime _fechaFinal;
        private DateTime _fechaInicio;
        private List<DateTime> fechasCorte;
        private decimal _horasTotalesCorte;
        private List<Prenda> _prendasEnCorte;
        private int _identificadorDeCorte;
        private static int _contadorCortes;
        static Corte()
        {
            _contadorCortes = 0;

        }
        public Corte()
        {
        }
        //[JsonConstructor]
        public Corte(DateTime fechaFinal, DateTime fechaInicio) : this()
        {
            // PrendasEnConfeccion = new();
            FechaFinal = fechaFinal;
            FechaInicio = fechaInicio;
            ContadorCortes++;
            IdentificadorDeCorte = _contadorCortes;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            if (PrendasEnCorte is not null)
            {
                sb.Clear();
                sb.Append($"Identificador del corte: C{IdentificadorDeCorte}\n");
                //sb.Append(ContarTallesPrendas());
            }

            return sb.ToString();
        }

        /* public string ContarTallesPrendas()
         {
             StringBuilder sb = new();

             sb.Append($"Prendas en corte: \n");
             foreach (KeyValuePair<TallePrenda, List<Prenda>> kvp in PrendasEnCorte)
             {
                 if (PrendasEnCorte.Count > 0)
                 {
                     sb.Append($"{kvp.Key.ToString()} | {kvp.Value.Count} prendas\n");
                 }
             }
             return sb.ToString();
         }*/
        public decimal HorasTotalesCorte
        {
            get => _horasTotalesCorte;
            set => _horasTotalesCorte = Math.Round(value, 1);
        }
        public List<Prenda> PrendasEnCorte
        {
            set
            {
                if (value is not null)
                {
                    _prendasEnCorte = value;
                }
            }
            get
            {
                return _prendasEnCorte;
            }
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

        public int IdentificadorDeCorte
        {
            get => _identificadorDeCorte;
            set => _identificadorDeCorte = value;
        }

        public int ContadorCortes
        {
            get => _contadorCortes;
            set => _contadorCortes = value;
        }
        public void ObtenerHorasTotalesCorte()
        {
            HorasTotalesCorte = 0;
            if (PrendasEnCorte is not null)
            {
                foreach (Prenda prenda in PrendasEnCorte)
                {
                    HorasTotalesCorte += prenda.TiempoFinalEtapa;
                }

            }

        }
        public bool EncontrarPrenda(Prenda prendaBuscada)
        {

            if (this is not null)
            {
                if (prendaBuscada is not null)
                {
                    if (PrendasEnCorte is not null && PrendasEnCorte.Count > 0)
                    {
                        if (PrendasEnCorte.Contains(prendaBuscada))
                        {
                            return true;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new NullReferenceException("La prenda que buscas no es valida");
                }
            }
            else
            {
                throw new NullReferenceException("El corte no es valido");
            }
            return false;
        }

    }
}
