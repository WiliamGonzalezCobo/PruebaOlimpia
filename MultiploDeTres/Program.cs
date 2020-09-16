using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidad;

namespace MultiploDeTres
{
    class Program
    {
        static readonly string archivoEntrada = @"D:\Documentos\TEMP\archivoEntrada.txt";
        static readonly string archivoSalida = @"D:\Documentos\TEMP\archivoSalida.txt";
        static string textoSalida = string.Empty;

        static void Main(string[] args)
        {
            try
            {
                if (File.Exists(archivoEntrada))
                {
                    int numero = 3;
                    string[] lineas = File.ReadAllLines(archivoEntrada);
                    foreach (string linea in lineas)
                        textoSalida += Calculos.esMultiplo(numero, linea);

                    Archivo.crearArchivo(archivoSalida, textoSalida);
                    Console.WriteLine("Archivo de salida generado: " + archivoSalida);
                }
                else
                {
                    Console.WriteLine("No existe el arhivo de entrada: " + archivoEntrada);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }


    }
}
