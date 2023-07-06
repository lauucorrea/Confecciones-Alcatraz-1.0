using Entidades;
using System.Text;
namespace Vista
{
    public partial class FrmEdicionJornada : Form
    {
        private Dictionary<string, bool> DiasLaborales;
        Persona PersonaLogueada;
        public FrmEdicionJornada(Persona personaLogueada)
        {
            InitializeComponent();
            if (PersonaLogueada is not null)
            {

                PersonaLogueada = personaLogueada;
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

        private void FrmEdicionJornada_Load(object sender, EventArgs e)
        {
            CmbApertura.SelectedIndex = Convert.ToInt32(PersonaLogueada.HorarioApertura.TotalHours) - 1;
            CmbCierre.SelectedIndex = Convert.ToInt32(PersonaLogueada.HorarioCierre.TotalHours) - 1;
            MostrarDiasLaborales();
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
                int horaApertura = Convert.ToInt32(CmbApertura.SelectedItem);
                int horaCierre = Convert.ToInt32(CmbCierre.SelectedItem);

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
    }
}
