using ConsoleApp1.Concret;
using ConsoleApp1.Generics;
using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura figura;
            figura = new Cuadrado(5, 10);
            Console.WriteLine("la base del cuadrado es: " + figura.calcularArea());

            figura = new Rectangulo(6, 10);
            Console.WriteLine("la base del rectangulo es: " + figura.calcularArea());


            MiGenerico<int> entero = new MiGenerico<int>();
            entero.Objeto = 10;

            MiGenerico<string> texto = new MiGenerico<string>();
            texto.Objeto = "mi texto";



            Console.ReadKey();
        }

    }
}
