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


    public class Corte
    {
        private DateTime _fechaFinal;
        private DateTime _fechaInicio;

        private decimal _horasTotalesCorte;
        private SortedDictionary<TallePrenda, List<Prenda>> _prendasEnCorte;
        private int _identificadorDeCorte;
        private static int _contadorCortes;
        static Corte()
        {
            _contadorCortes = 0;

        }
        public Corte()
        {
        }
        public Corte(DateTime fechaFinal, DateTime fechaInicio) : this()
        {
            // PrendasEnConfeccion = new();
            FechaFinal = fechaFinal;
            FechaInicio = fechaInicio;
            _contadorCortes++;
            IdentificadorDeCorte = _contadorCortes;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            if (PrendasEnCorte is not null)
            {
                // sb.Append($"Identificador del corte: {IdentificadorDeConfeccion}/n");
                sb.Clear();
                sb.Append(ContarTallesPrendas());
            }

            return sb.ToString();
        }

        public string ContarTallesPrendas()
        {
            StringBuilder sb = new();

            sb.Append($"Prendas en corte: \n");
            foreach (KeyValuePair<TallePrenda, List<Prenda>> kvp in PrendasEnCorte)
            {
                if (kvp.Value.Count > 0)
                {
                    sb.Append($"{kvp.Key.ToString()} | {kvp.Value.Count} prendas\n");
                }
            }
            return sb.ToString();
        }
        public decimal HorasTotalesCorte
        {
            get => _horasTotalesCorte;
            set => _horasTotalesCorte = Math.Round(value, 1);
        }
        public SortedDictionary<TallePrenda, List<Prenda>> PrendasEnCorte
        {
            set
            {
                if (value is not null)
                {
                    _prendasEnCorte = value;
                    ObtenerHorasTotalesCorte();
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

        public void ObtenerHorasTotalesCorte()
        {
            HorasTotalesCorte = 0;
            if (PrendasEnCorte is not null)
            {
                foreach (KeyValuePair<TallePrenda, List<Prenda>> par in PrendasEnCorte)
                {
                    foreach (Prenda prenda in par.Value)
                    {
                        HorasTotalesCorte += prenda.TiempoFinalEtapa;
                    }
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
                        foreach (KeyValuePair<TallePrenda, List<Prenda>> par in PrendasEnCorte)
                        {
                            if (par.Value.Contains(prendaBuscada))
                            {
                                return true;
                            }
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
