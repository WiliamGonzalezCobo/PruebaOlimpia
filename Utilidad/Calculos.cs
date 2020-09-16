using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidad
{
    public class Calculos
    {
        /// <summary>
        /// Calcula si un numero es multiplo del otro, sumando sus digitos
        /// </summary>
        /// <param name="divisor"></param>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string esMultiplo(int divisor, string cadena)
        {
            try
            {
                long dividendo = 0;

                for (int x = 0; x < cadena.Length; x++)
                {
                    dividendo += Convert.ToInt32(cadena[x].ToString());
                }

                return (dividendo % divisor) == 0
                            ? string.Format("El numero {0} SI es multiplo de {1} \n", cadena, divisor)
                            : string.Format("El numero {0} NO es multiplo de {1} \n", cadena, divisor);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
