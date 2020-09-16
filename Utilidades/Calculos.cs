using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Calculos
    {
        /// <summary>
        /// Calcula si un numero es multiplo del otro, sumando sus digitos
        /// </summary>
        /// <param name="numberSource"></param>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool isMultiples(int numberSource, string cadena)
        {
            long sumatoriaDigitos = 0;

            for (int x = 0; x < cadena.Length; x++)
            {
                sumatoriaDigitos += Convert.ToInt32(cadena[x].ToString());
            }

            return (sumatoriaDigitos % numberSource) == 0;
        }
    }
}
