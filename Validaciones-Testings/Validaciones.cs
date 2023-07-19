using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones_Testings
{
    public static class Validaciones
    {
        static List<string> EnumALista<T>()
        {
            var enumType = typeof(T);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("El tipo especificado no es un enum.");
            }

            var names = Enum.GetNames(enumType);
            var list = new List<string>(names.Length);

            foreach (string name in names)
            {
                list.Add(name);
            }

            return list;
        }
        /// <summary>
        /// Si la palabra completa se convierte, es un numero
        /// Si la letra recorrida se convierte, es alfanumerico
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool ValidarString(string cadena)
        {
            if (!string.IsNullOrEmpty(cadena))
            {
                return int.TryParse(cadena, out _) ? throw new Exception("Los campos no admiten numeros") : true;
            }
            else
            {
                return false;
            }

        }

        public static string GenerarCodigoAlfanumericoRandom()
        {
            string caracteresPermitidos = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";

            Char[] codigo = new char[12];
            Random random = new();

            for (int i = 0; i < codigo.Length; i++)
            {
                codigo[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            string stringRetorno = new(codigo);

            return stringRetorno;
        }
        public static bool ValidarAlfanumerico(string cadena)
        {
            if (cadena is not null)
            {

                for (int i = 0; i < cadena.Length; i++)
                {
                    if (!char.IsLetter(cadena[i]))
                    {
                        if (cadena.Length == 8)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("El largo de la matricula debe ser de 8 caracteres");
                        }
                    }
                }

            }
            else
            {
                throw new ArgumentNullException();
            }
            return false;
        }

        public static bool VerificarDni(int dni)
        {
            int digitos = Math.Abs(dni).ToString().Length; // Obtener la cantidad de dígitos

            if (digitos >= 8)
            {
                return true; // El DNI tiene al menos 8 dígitos
            }
            else
            {
                return false; // El DNI tiene menos de 8 dígitos
            }
        }

    }
}
