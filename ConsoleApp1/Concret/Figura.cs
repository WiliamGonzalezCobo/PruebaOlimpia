using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concret
{
    public class Figura:IFigura
    {
        public int basef { get; set; }

        public int altura { get; set; }

        public int calcularArea()
        {
            return this.basef * this.altura;
        }
    }
}
