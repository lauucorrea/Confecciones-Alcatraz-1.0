using System.Text;

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
        private int _cantidadPrendasHora;
        private string? _detallePrenda;
        private string? _informacionAdicional;


        public Prenda(CategoriaPrenda categoria, int cantidadPrendasHora)
        {
            Categoria = categoria;
            CantidadPrendasHora = cantidadPrendasHora;
        }

        public Prenda(CategoriaPrenda categoria, int cantidadPrendasHora, string detallePrenda) : this(categoria, cantidadPrendasHora)
        {
            DetallePrenda = detallePrenda;
        }
        public Prenda(CategoriaPrenda categoria, int cantidadPrendasHora, string detallePrenda, string informacionAdicional) : this(categoria, cantidadPrendasHora, detallePrenda)
        {
            InformacionAdicional = informacionAdicional;
        }

        public CategoriaPrenda Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        public int CantidadPrendasHora
        {
            get => _cantidadPrendasHora;
            set => _cantidadPrendasHora = value;
        }
        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine(Categoria.ToString());
            sb.AppendLine(CantidadPrendasHora.ToString());
            sb.AppendLine(DetallePrenda.ToString());
            sb.AppendLine(InformacionAdicional.ToString());

            return sb.ToString();
        }
        public string DetallePrenda
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
            set => _detallePrenda = value;
        }

        public string InformacionAdicional
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
            set => _informacionAdicional = value;
        }
    }
}
