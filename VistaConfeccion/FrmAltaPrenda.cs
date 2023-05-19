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
                        if (Administracion.AgregarPrenda_Lista(prendaCreada))
                        {
                            MessageBox.Show(prendaCreada.ToString());
                            VaciarDatos();

                        }

                    }

                }
                else
                {
                    throw new Exception("Deben completarse los campos marcados en rojo");
                }

            }
            catch (Exception ex)
            {
               LblErrores.Text = "No se pudo crear una prenda :" + ex.Message;
            }

        }

        private void FrmAltaPrenda_Load(object sender, EventArgs e)
        {
            string[] categorias = Enum.GetNames(typeof(CategoriaPrenda));
            CmbCategoria.DataSource = categorias;
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            VaciarDatos();
            DialogResult = DialogResult.Cancel;
        }
        private void VaciarDatos()
        {
            TxtDistintivo.Text = string.Empty;
            RchDescripcion.Clear();
            NumPrendasHora.Value = 1;
        }
    }
}

