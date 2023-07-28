using System.Text;
using System.Text.Json.Serialization;
using Validaciones_Testings;
namespace Entidades
{
    public enum CategoriaPrenda
    {
        Remera,
        Pantalon,
        Campera,
        Chomba
    }
    public enum EtapaCorte
    {
        Pendiente,
        Tizando,
        Encimando,
        Cortando,
        Terminado
    }
    [Serializable]
    public class Prenda 
    {
        private CategoriaPrenda _categoria;
        private TallePrenda _talle;
        //datos de calculo de produccion
        private int _cantidadEnHoras;
        private int _horasParaCantidad;
        private int _prendasHora;

        private decimal _unidadesCorte;
        private decimal _tiempoFinalEtapa;
        private EtapaCorte _etapa;
        //informacion adicional
        private string? _detallePrenda;
        private string? _informacionAdicional;

        //identificador
        private int idPrenda;
        private static int contadorPrendas;
        static Prenda()
        {
            contadorPrendas = 0;
        }
        //[JsonConstructor]
        public Prenda()
        {

        }
        public Prenda(CategoriaPrenda categoria, int cantidadPrendas, int horasProduccion):this()
        {
            Categoria = categoria;
            CantidadEnHoras = cantidadPrendas;
            HorasParaCantidad = horasProduccion;
            ContadorPrendas++;
            IdPrenda = contadorPrendas;
            PrendasHora = CantidadEnHoras / HorasParaCantidad ;

            if(PrendasHora <= 0)
            {
                PrendasHora = 1;
            }
        }

        public Prenda(CategoriaPrenda categoria, int cantidadPrendas, int horasProduccion, string detallePrenda) : this(categoria, cantidadPrendas,horasProduccion)
        {
            Detalles = detallePrenda;
        }
        public Prenda(CategoriaPrenda categoria, int cantidadPrendas, int horasProduccion, string? detallePrenda, string informacionAdicional) : this(categoria, cantidadPrendas, horasProduccion, detallePrenda)
        {
            Adicional = informacionAdicional;
            if (string.IsNullOrEmpty(detallePrenda))
            {
                Detalles = string.Empty;
            }
            else
            {
                Detalles = detallePrenda;
            }
        }
        public int ContadorPrendas
        {
            get => contadorPrendas;
            set => contadorPrendas = value;
        }

        public decimal UnidadesCorte
        {
            get => _unidadesCorte;
            set
            {
                _unidadesCorte = Math.Round(value);

                
            }
        }
        public int IdPrenda
        {
            get => idPrenda;
            set => idPrenda = value;
        }
        public EtapaCorte Etapa
        {
            get => _etapa;
            set => _etapa = value;
        }
        public decimal TiempoFinalEtapa
        {
            get => _tiempoFinalEtapa;
            set => _tiempoFinalEtapa = Math.Round(value,1);
        }
        public int PrendasHora
        {
            get => _prendasHora;
            set => _prendasHora = value;
        }

        public CategoriaPrenda Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }
        public TallePrenda TallePrenda
        {
            get => _talle;
            set => _talle = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(Categoria.ToString());
            sb.Append("Horas para completar: ");
            sb.AppendLine(HorasParaCantidad.ToString());
            sb.AppendLine(CantidadEnHoras.ToString());
            sb.AppendLine(Detalles.ToString());
            sb.AppendLine(Adicional.ToString());

            return sb.ToString();
        }
        /*public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (!string.IsNullOrEmpty(Categoria.ToString()) ? Categoria.GetHashCode() : 0);
                hash = hash * 23 + (!string.IsNullOrEmpty(Detalles) ? Detalles.GetHashCode() : 0);
                return hash;
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                bool ret = false;

                if (obj is null || GetType() != obj.GetType())
                {
                    ret = false;
                }
                else
                {

                    Prenda other = (Prenda)obj;

                    if(CompareTo(other) == 0)
                    {
                        ret = true;
                    }
                }
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj is null)
            {
                return 1; // El objeto other es nulo, por lo que el objeto actual es mayor
            }

            if (GetType() != obj.GetType())
            {
                throw new ArgumentException("El objeto no es del mismo tipo.", nameof(obj));
            }

            Prenda other = (Prenda)obj;

            // Comparar las propiedades relevantes del objeto
            int comparacion = idPrenda.CompareTo(other.idPrenda);

            // Si las propiedades son iguales, se podría realizar una comparación adicional
            if (comparacion == 0)
            {
                comparacion = Categoria.CompareTo(other.Categoria);
            }

            return comparacion;
        }*/

        public string Detalles
        {
            get
            {
                if (!string.IsNullOrEmpty(_detallePrenda))
                {
                    return _detallePrenda;

                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (Validaciones.ValidarString(value))
                {
                    _detallePrenda = value;
                }
            }
        }

        public string Adicional
        {
            get
            {
                if (!string.IsNullOrEmpty(_informacionAdicional))
                {
                    return _informacionAdicional;

                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (Validaciones.ValidarString(value))
                {
                    _informacionAdicional = value;

                }

            }
        }

        public int HorasParaCantidad { get => _horasParaCantidad; set => _horasParaCantidad = value; }
        public int CantidadEnHoras { get => _cantidadEnHoras; set => _cantidadEnHoras = value; }
    }
}
