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


    public class Prenda
    {
        private CategoriaPrenda _categoria;
        private int _prendasPorHora;
        private string? _detallePrenda;
        private string? _informacionAdicional;

        static Prenda()
        {

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
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Prenda other = (Prenda)obj;
            return string.Equals(Categoria, other.Categoria) && string.Equals(Detalles, other.Detalles);
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
