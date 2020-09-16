using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utilidad
{
    public class Intercepcion
    {
        /// <summary>
        /// Author de la logica https://stackoverflow.com/questions/19723641/find-intersecting-point-of-three-circles-programmatically/19724186#19724186
        /// lo adapte a c# ya que estaba en c y recorte solo lo que se requiere para la funcionalidad.
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="r0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="r1"></param>
        /// <returns></returns>
        public static bool seInterceptan(double x0, double y0, double r0,
                                         double x1, double y1, double r1)
        {
            double dx, dy, d;

            /* dx and dy are the vertical and horizontal distances between
            * the circle centers.
            */
            dx = x1 - x0;
            dy = y1 - y0;

            /* Determine the straight-line distance between the centers. */
            d = Math.Sqrt((dy * dy) + (dx * dx));

            /* Check for solvability. */
            if (d > (r0 + r1))
            {
                /* no solution. circles do not intersect. */
                return false;
            }
            else if (d < Math.Abs(r0 - r1))
            {
                /* no solution. one circle is contained in the other */
                return false;
            }
            else {
                /*the circle intersect*/
                return true;
            }
        }

        /// <summary>
        /// Calcula si dos circulos se interceptan
        /// </summary>
        /// <param name="circunferenciaUno">Coordenadas de la circunferencia uno</param>
        /// <param name="circunferenciaDos">Coordenadas de la circunferencia dos</param>
        /// <returns></returns>
        public static bool seInterceptan(Circunferencia circunferenciaUno, Circunferencia circunferenciaDos)
        {
            double dx, dy, d;

            /* dx and dy are the vertical and horizontal distances between
            * the circle centers.
            */
            dx = circunferenciaDos.CenterX - circunferenciaUno.CenterX;
            dy = circunferenciaDos.CenterY - circunferenciaUno.CenterY
;

            /* Determine the straight-line distance between the centers. */
            d = Math.Sqrt((dy * dy) + (dx * dx));

            /* Check for solvability. */
            if (d > (circunferenciaUno.Radio + circunferenciaDos.Radio))
            {
                /* no solution. circles do not intersect. */
                return false;
            }
            else if (d < Math.Abs(circunferenciaUno.Radio - circunferenciaDos.Radio))
            {
                /* no solution. one circle is contained in the other */
                return false;
            }
            else
            {
                /*the circle intersect*/
                return true;
            }
        }
    }
}
