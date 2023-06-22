using Entidades;
using VistaConfeccion;

namespace Vista
{
    public partial class FrmIngreso : Form
    {
        Persona PersonaLogueada;
        public FrmIngreso()
        {
            InitializeComponent();
            PersonaLogueada = new();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            TxtUsuario.Text = "Rober";
            TxtPassword.Text = "asd123";
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (LogCredenciales(TxtUsuario.Text, TxtPassword.Text))
                {
                    FrmMain menu = new(PersonaLogueada);
                    menu.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool LogCredenciales(string usuario, string passwd)
        {
            bool seEncontroPersona = false;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(passwd))
            {
                foreach (Persona persona in GestionDatos.PersonasSistema)
                {

                    if (persona.AdministrarLogIn(usuario, passwd))
                    {
                        seEncontroPersona = true;
                    }

                }
                if (!seEncontroPersona)
                {
                    TxtUsuario.Text = string.Empty;
                    TxtPassword.Text = string.Empty;
                    throw new Exception("Los registros del usuario no coinciden");
                }
                return seEncontroPersona;
            }
            throw new Exception("Los campos deben completarse para loguear");


        }

        private void LnkAlternarModo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frmRegistro = new();

            if (frmRegistro is not null)
            {
                if (frmRegistro.ShowDialog() != DialogResult.OK)
                {
                    frmRegistro.Close();
                }
            }
        }
    }
}
