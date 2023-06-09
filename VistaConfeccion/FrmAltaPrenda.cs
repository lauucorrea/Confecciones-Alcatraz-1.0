﻿using Entidades;
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
                            MessageBox.Show(prendaCreada.ToString());
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
                LblErrores.Text = "No se pudo crear una prenda :" + ex.Message;
            }

        }
        private void CargarDatagridPrendasSistema()
        {
            // Suponiendo que tienes un DataGridView llamado dataGridViewConfecciones
            DtgPrendasSistema.DataSource = null;
            // Limpiar las columnas existentes en el DataGridView
            DtgPrendasSistema.Columns.Clear();

            // Agregar las columnas necesarias al DataGridView
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
                fila.Cells[0].Value = prenda.Categoria; // Suponiendo que Prenda tiene una propiedad "Nombre"
                fila.Cells[1].Value = prenda.CantidadPrendas; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[2].Value = prenda.HorasProduccion; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[3].Value = prenda.PrendasHora; // Suponiendo que Prenda tiene una propiedad "Tipo"
                fila.Cells[4].Value = prenda.Detalles; // Suponiendo que TallePrenda tiene una propiedad "Talle"
                fila.Cells[5].Value = prenda.Adicional; // Suponiendo que Prenda tiene una propiedad "Cantidad"

                // Agregar la fila al DataGridView
                DtgPrendasSistema.Rows.Add(fila);
            }
        }

        private void FrmAltaPrenda_Load(object sender, EventArgs e)
        {
            string[] categorias = Enum.GetNames(typeof(CategoriaPrenda));
            CmbCategoria.DataSource = categorias;
            CargarDatagridPrendasSistema();

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
            NumHoras.Value = 1;
        }
    }
}

