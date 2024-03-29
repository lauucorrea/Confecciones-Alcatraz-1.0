﻿using Entidades;
using Procesos;
using System.Text;
namespace Vista
{
    public partial class FrmEdicionJornada : Form
    {
        private Dictionary<string, bool> DiasLaborales;
        Persona PersonaLogueada;
        public FrmEdicionJornada()
        {
            InitializeComponent();


        }

        private void FrmEdicionJornada_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            MostrarDiasLaborales();
            lstUsuariosSistema.DataSource = GestionDatos.PersonasSistema;

            if ((Persona)lstUsuariosSistema.SelectedItem is not null)
            {

                PersonaLogueada = (Persona)lstUsuariosSistema.SelectedItem;
                CmbApertura.SelectedIndex = Convert.ToInt32(PersonaLogueada.HorarioApertura.TotalHours) - 1;
                CmbCierre.SelectedIndex = Convert.ToInt32(PersonaLogueada.HorarioCierre.TotalHours) - 1;

                DiasLaborales = new()
            {
                {"Lunes",ChkLunes.Checked },
                {"Martes",ChkMartes.Checked},
                {"Miercoles",ChkMiercoles.Checked },
                {"Jueves", ChkJueves.Checked },
                {"Viernes", ChkViernes.Checked },
                {"Sabado",ChkSabado.Checked },
                {"Domingo",ChkDomingo.Checked}
            };
            }
            else
            {
                throw new ArgumentNullException("La persona recibida no es valida");
            }
        }

        private void MostrarDiasLaborales()
        {
            if (DiasLaborales is not null)
            {

                foreach (string dia in PersonaLogueada.DiasLaborales)
                {
                    if (DiasLaborales.ContainsKey(dia))
                    {
                        switch (dia)
                        {
                            case "Lunes":
                                ChkLunes.Checked = true; break;
                            case "Martes":
                                ChkMartes.Checked = true; break;
                            case "Miercoles":
                                ChkMiercoles.Checked = true; break;
                            case "Jueves":
                                ChkJueves.Checked = true; break;
                            case "Viernes":
                                ChkViernes.Checked = true; break;
                            case "Sabado":
                                ChkSabado.Checked = true; break;
                            case "Domingo":
                                ChkDomingo.Checked = true; break;
                        }
                    }
                }
            }
        }
        private void ObtenerDiasLaborales()
        {
            DiasLaborales = new()
            {
                {"Lunes",ChkLunes.Checked },
                {"Martes",ChkMartes.Checked},
                {"Miercoles",ChkMiercoles.Checked },
                {"Jueves", ChkJueves.Checked },
                {"Viernes", ChkViernes.Checked },
                {"Sabado",ChkSabado.Checked },
                {"Domingo",ChkDomingo.Checked}
            };

            PersonaLogueada.DiasLaborales.Clear();

            foreach (KeyValuePair<string, bool> kp in DiasLaborales)
            {
                if (kp.Value)
                {
                    PersonaLogueada.DiasLaborales.Add(kp.Key);
                }
            }

        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                int horaApertura = Convert.ToInt32(CmbApertura.SelectedIndex + 1);
                int horaCierre = Convert.ToInt32(CmbCierre.SelectedIndex + 1);

                if (horaCierre != -1 && horaApertura != -1)
                {

                    ObtenerDiasLaborales();

                    PersonaLogueada.HorarioApertura = new(horaApertura, 0, 0);
                    PersonaLogueada.HorarioCierre = new(horaCierre, 0, 0);

                    StringBuilder sb = new();
                    sb.AppendLine("Jornada modificada.");
                    sb.AppendLine(" ");
                    sb.AppendLine("Dias laborales:");
                    sb.AppendLine(" ");
                    foreach (string dia in PersonaLogueada.DiasLaborales)
                    {
                        sb.AppendLine(dia);
                    }
                    sb.AppendLine(" ");
                    sb.AppendLine("Horario de apertura de " + PersonaLogueada.Nombre + ":");
                    sb.AppendLine(PersonaLogueada.HorarioApertura.ToString());
                    sb.AppendLine(" ");
                    sb.AppendLine("Horario de cierre de " + PersonaLogueada.Nombre + ":");
                    sb.AppendLine(PersonaLogueada.HorarioCierre.ToString());
                    MessageBox.Show(sb.ToString());
                    Serializadora.GuardarPersonasJSON();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new Exception("Debe elegir un horario valido para continuar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar? Se perderan los cambios sin guardar";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clase_serializadora serializadora = new();
                //serializadora.GuardarPersonasXML();
                //serializadora.GuardarAvionesXML();
                DialogResult = DialogResult.Cancel;
            }
        }

        private void lstUsuariosSistema_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((Persona)lstUsuariosSistema.SelectedItem is not null)
            {

                PersonaLogueada = (Persona)lstUsuariosSistema.SelectedItem;
                //aca deberia completar los datos segun el usuario seleccionado de la lista
                MostrarDiasLaborales();
                CmbApertura.SelectedIndex = Convert.ToInt32(PersonaLogueada.HorarioApertura.TotalHours) - 1;
                CmbCierre.SelectedIndex = Convert.ToInt32(PersonaLogueada.HorarioCierre.TotalHours) - 1;
            }
            else
            {
                throw new ArgumentNullException("La persona recibida no es valida");
            }
        }
    }
}
