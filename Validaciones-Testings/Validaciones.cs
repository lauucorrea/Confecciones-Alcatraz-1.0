using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones_Testings
{
    public static class Validaciones
    {
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
                throw new ArgumentNullException();
            }

        }
        
        

    }
}
