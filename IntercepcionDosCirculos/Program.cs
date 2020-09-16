using Entities;
using System;
using Utilidad;

namespace IntercepcionDosCirculos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circunferencia crUno = new Circunferencia();
                Console.WriteLine("Primera circunferencia");
                Console.WriteLine("Centro en X:");
                crUno.CenterX = double.Parse(Console.ReadLine());
                Console.WriteLine("Centro en Y:");
                crUno.CenterY = double.Parse(Console.ReadLine());
                Console.WriteLine("Radio:");
                crUno.Radio = double.Parse(Console.ReadLine());

                Circunferencia crDos = new Circunferencia();
                Console.WriteLine("Segunda circunferencia");
                Console.WriteLine("Centro en X:");
                crDos.CenterX = double.Parse(Console.ReadLine());
                Console.WriteLine("Centro en Y:");
                crDos.CenterY = double.Parse(Console.ReadLine());
                Console.WriteLine("Radio:");
                crDos.Radio = double.Parse(Console.ReadLine());

                bool result = Intercepcion.seInterceptan(crUno, crDos);

                Console.WriteLine(result ? "Si se interceptan" : "No se interceptan");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
