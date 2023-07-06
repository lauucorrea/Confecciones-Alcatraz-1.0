using System.Text;
using Validaciones_Testings;

namespace Entidades
{
    public enum Rol
    {
        Empleado,
        Administrador,
        Propietario
    }
    [Serializable]
    public class Persona
    {
        private TimeSpan horarioApertura;
        private TimeSpan horarioCierre;
        private List<string> diasLaborales;
        private string nombre;
        private string apellido;
        private int dni;
        private string usuario;
        private string password;
        private Rol rolPersona;

        private static int horasJornada;
        public Persona()
        {

        }
        //[JsonConstructor]
        public Persona(string nombre, string apellido, int dni, string usuario, string password) : this()
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Usuario = usuario;
            Password = password;

            DiasLaborales = new(){
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"
            };
            HorarioApertura = new(8, 30, 0);
            HorarioCierre = new(16, 30, 0);

        }


        public Rol RolPersona
        {
            set => rolPersona = value;
            get => rolPersona;
        }
        public int HorasJornada
        {
            set => horasJornada = value;
            get => horasJornada;
        }
        public List<string> DiasLaborales
        {
            set => diasLaborales = value;
            get => diasLaborales;
        }
        public TimeSpan HorarioApertura
        {
            get => horarioApertura;
            set
            {
                horarioApertura = value;
            }
        }
        public TimeSpan HorarioCierre
        {
            get => horarioCierre;
            set
            {
                if (value > horarioApertura)
                {
                    horarioCierre = value;
                }
                else
                {
                    throw new Exception("El horario de cierre debe ser mayor al de apertura");
                }

            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (Validaciones.ValidarString(value.ToLower()))
                {
                    nombre = value;
                }

                else
                {
                    throw new Exception("Nombre incorrecto");
                }

            }

        }

        public string Apellido
        {
            get => apellido;
            set
            {
                if (Validaciones.ValidarString(value.ToLower()))
                {
                    apellido = value;
                }

                else
                {
                    throw new Exception("Apellido incorrecto");
                }

            }
        }
        public string Password
        {
            set => password = value;
            get => password;
        }

        public string Usuario
        {
            set => usuario = value;
            get => usuario;
        }


        public int Dni
        {
            get => dni;
            set
            {
                if (Validaciones.VerificarDni(value))
                {
                    dni = value;
                }
                else
                {
                    throw new Exception("Dni incorrecto");
                }
            }
        }

        public bool AdministrarLogIn(string usuario, string password)
        {
            if (Password == password && Usuario == usuario)
            {
                return true;
            }
            return false;
        }
        public string NombreApellido()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Nombre}-{Apellido}");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Nombre}-{Apellido}-{Dni}");

            return sb.ToString();
        }



    }
}