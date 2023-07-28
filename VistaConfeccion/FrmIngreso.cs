using Entidades;
using Procesos;
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
            TxtUsuario.Text = "tomimc";
            TxtPassword.Text = "tomas";
            Serializadora.LevantarCortesJSON();
            Serializadora.LevantarPrendasJSON();
            Serializadora.LevantarPersonasJSON();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaLogueada = LogCredenciales(TxtUsuario.Text,TxtPassword.Text);
                if (PersonaLogueada is not null)
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
        private Persona LogCredenciales(string usuario, string passwd )
        {
            Persona personaEncontrada = null;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(passwd))
            {
                foreach (Persona persona in GestionDatos.PersonasSistema)
                {

                    if (persona.AdministrarLogIn(usuario, passwd))
                    {
                        personaEncontrada = persona;
                    }

                }
                if (personaEncontrada is null)
                {
                    TxtUsuario.Text = string.Empty;
                    TxtPassword.Text = string.Empty;
                    throw new Exception("No hay usuario registrado con estas credenciales");
                }
                else
                {
                    return personaEncontrada;
                }
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
