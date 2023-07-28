using Entidades;
using Procesos;

namespace Vista
{
    public partial class FrmRegistro : Form
    {
        Persona PersonaCreada;
        public FrmRegistro()
        {
            InitializeComponent();
            PersonaCreada = new();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadElementos = 0;
                if (int.TryParse(NumDni.Value.ToString(), out _))
                {
                    PersonaCreada = new(TxtNombre.Text, TxtApellido.Text, Convert.ToInt32(NumDni.Value), TxtUsuario.Text, TxtPassword.Text);
                    if (PersonaCreada is not null)
                    {
                        cantidadElementos = GestionDatos.PersonasSistema.Count;
                        GestionDatos.PersonasSistema.Add(PersonaCreada);
                        Rol rolSeleccioando = (Rol)Enum.Parse(typeof(Rol), CmbRolUsuario.SelectedIndex.ToString());
                        PersonaCreada.RolPersona = rolSeleccioando;
                        if (cantidadElementos < GestionDatos.PersonasSistema.Count)
                        {
                            MessageBox.Show(PersonaCreada.ToString());
                            Serializadora.GuardarPersonasJSON();

                            FrmEdicionJornada frmEdicion = new(PersonaCreada);

                            if (frmEdicion.ShowDialog() != DialogResult.OK)
                            {
                                frmEdicion.Close();
                            }
                            VaciarDatos();
                        }
                        else
                        {
                            throw new Exception("No se pudo crear el usuario");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VaciarDatos()
        {
            TxtApellido.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            TxtUsuario.Text = string.Empty;
            NumDni.Value = 0;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            string[] rolUsuario = Enum.GetNames(typeof(Rol));
            CmbRolUsuario.DataSource = rolUsuario;
            this.ControlBox = false;
        }

        private void LnkAlternarModo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
