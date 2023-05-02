using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaConfeccion
{
    public partial class FrmAltaConfeccion : Form
    {
        public FrmAltaConfeccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAltaConfeccion_Load(object sender, EventArgs e)
        {
            DtgPrendasConfeccion.DataSource = GestionDatos.PrendasCreadas;
        }
    }
}
