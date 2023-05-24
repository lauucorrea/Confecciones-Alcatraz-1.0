using System.Text;
using Validaciones_Testings;
namespace Entidades
{
    public enum CategoriaPrenda
    {
        Remera,
        Pantalon,
        Campera
    }


    public class Prenda : IComparable
    {
        private CategoriaPrenda _categoria;
        private int _prendasPorHora;
        private string? _detallePrenda;
        private string? _informacionAdicional;

        private int idPrenda;
        private static int contadorPrendas;
        static Prenda()
        {
            contadorPrendas = 0;
        }
        public Prenda(CategoriaPrenda categoria, int cantidadPrendasHora)
        {
            Categoria = categoria;
            PrendasHora = cantidadPrendasHora;
        }

        public Prenda(CategoriaPrenda categoria, int cantidadPrendasHora, string detallePrenda) : this(categoria, cantidadPrendasHora)
        {
            Detalles = detallePrenda;
        }
        public Prenda(CategoriaPrenda categoria, int cantidadPrendasHora, string? detallePrenda, string informacionAdicional) : this(categoria, cantidadPrendasHora, detallePrenda)
        {
            Adicional = informacionAdicional;
            contadorPrendas++;
            idPrenda = contadorPrendas;
            if (string.IsNullOrEmpty(detallePrenda))
            {
                Detalles = string.Empty;
            }
        }

        public CategoriaPrenda Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        public int PrendasHora
        {
            get => _prendasPorHora;
            set => _prendasPorHora = value;
        }
        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(Categoria.ToString());
            sb.AppendLine(PrendasHora.ToString());
            sb.AppendLine(Detalles.ToString());
            sb.AppendLine(Adicional.ToString());

            return sb.ToString();
        }
        public override int GetHashCode()
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
        }

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

    }
}
