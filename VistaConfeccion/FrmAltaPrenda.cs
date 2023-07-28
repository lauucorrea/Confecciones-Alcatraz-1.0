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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCategoria.SelectedIndex > -1 && NumHoras.Value > 0)
                {
                    CategoriaPrenda categoriaSeleccionada = (CategoriaPrenda)Enum.Parse(typeof(CategoriaPrenda), CmbCategoria.SelectedIndex.ToString());

                    Prenda prendaCreada = Administracion.CrearPrenda(categoriaSeleccionada, (int)NumUnidaes.Value, (int)NumHoras.Value, TxtDistintivo.Text, RchDescripcion.Text);

                    if (prendaCreada is not null)
                    {
                        if (Administracion.AgregarPrenda_Lista(prendaCreada))
                        {
                            MessageBox.Show($"Prenda creada con exito. \n{prendaCreada.ToString()}");
                            Serializadora.GuardarPrendasJSON();
                            VaciarDatos();
                            CargarDatagridPrendasSistema();

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
                MessageBox.Show("No se pudo crear una prenda :" + ex.Message);
            }

        }
        private void CargarDatagridPrendasSistema()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasSistema.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasSistema.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
            DtgPrendasSistema.Columns.Add("ColumnaId", "Id");
            DtgPrendasSistema.Columns.Add("ColumnaCategoria", "Categoria");
            DtgPrendasSistema.Columns.Add("ColumnaPrendas", "Unidades Produccion");
            DtgPrendasSistema.Columns.Add("ColumnaHoras", "Horas Produccion");
            DtgPrendasSistema.Columns.Add("ColumnaPrendasHora", "Promedio Prendas/Hora");
            DtgPrendasSistema.Columns.Add("ColumnaDetalle", "Detalle");
            DtgPrendasSistema.Columns.Add("ColumnaAdicionales", "Adicionales");

            // Recorrer el diccionario y agregar filas al DataGridView
            foreach (Prenda prenda in GestionDatos.PrendasSistema)
            {
                // Crear una nueva fila y asignar los valores de las celdas
                DataGridViewRow fila = new();
                fila.CreateCells(DtgPrendasSistema);
                fila.Cells[0].Value = prenda.IdPrenda;
                fila.Cells[1].Value = prenda.Categoria;
                fila.Cells[2].Value = prenda.CantidadEnHoras;
                fila.Cells[3].Value = prenda.HorasParaCantidad;
                fila.Cells[4].Value = prenda.PrendasHora; 
                fila.Cells[5].Value = prenda.Detalles; 
                fila.Cells[6].Value = prenda.Adicional; 

                // Agregar la fila al DataGridView
                DtgPrendasSistema.Rows.Add(fila);
            }
        }

        private void FrmAltaPrenda_Load(object sender, EventArgs e)
        {
            string[] categorias = Enum.GetNames(typeof(CategoriaPrenda));
            CmbCategoria.DataSource = categorias;
            CargarDatagridPrendasSistema();
            this.ControlBox = false;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            VaciarDatos();
            const string mensaje = "Estas seguro de que queres cerrar? No se guardaran los cambios sin guardar";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clase_serializadora serializadora = new();
                // serializadora.GuardarPersonasXML();
                // serializadora.GuardarAvionesXML();

                DialogResult = DialogResult.Cancel;
            }
        }
        private void VaciarDatos()
        {
            TxtDistintivo.Text = string.Empty;
            RchDescripcion.Clear();
            NumHoras.Value = 1;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar sesion? Se perderan los cambios sin guardar";
            const string comentario = "Cerrando sesion";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Clase_serializadora serializadora = new();
                //serializadora.GuardarPersonasXML();
                //serializadora.GuardarAvionesXML();
                Application.Exit();
            }
        }

    }
}

