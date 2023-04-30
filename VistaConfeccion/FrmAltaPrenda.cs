using Entidades;
using Procesos;
namespace VistaConfeccion
{
    public partial class FrmAltaPrenda : Form
    {
        public FrmAltaPrenda()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCategoria.SelectedIndex > -1 && NumPrendasHora.Value > 0)
                {
                    CategoriaPrenda categoriaSeleccionada = (CategoriaPrenda)Enum.Parse(typeof(CategoriaPrenda), CmbCategoria.SelectedIndex.ToString());

                    Prenda prendaCreada = Administracion.CrearPrenda(categoriaSeleccionada, (int)NumPrendasHora.Value, TxtDistintivo.Text, RchDescripcion.Text);

                    if (prendaCreada is not null)
                    {
                        MessageBox.Show(prendaCreada.ToString());
                    }

                }
                else
                {
                    throw new Exception("Deben completarse los campos marcados en rojo");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear una prenda :" + ex.Message);
            }

        }

        private void FrmAltaPrenda_Load(object sender, EventArgs e)
        {
            string[] categorias = Enum.GetNames(typeof(CategoriaPrenda));
            CmbCategoria.DataSource = categorias;
        }
    }
}

