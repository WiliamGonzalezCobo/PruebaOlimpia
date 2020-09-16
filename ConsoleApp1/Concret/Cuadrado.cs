using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concret
{

    //sobre carga de metodos en el costructor de nuestra clase
    public class Cuadrado:Figura
    {
        public Cuadrado(int prmBasef, int prmAltura) {
            this.basef = prmBasef;
            this.altura = prmAltura;
        }

        public Cuadrado()
        {
        }

    }
}
