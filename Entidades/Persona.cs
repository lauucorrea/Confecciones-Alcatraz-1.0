using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entidades;
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
        public Persona(string nombre, string apellido, int dni, string usuario, string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Usuario = usuario;
            Password = password;
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