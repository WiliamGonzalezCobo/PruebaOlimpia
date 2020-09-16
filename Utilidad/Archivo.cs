using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Utilidad
{
    public class Archivo
    {
        public static void crearArchivo(string outputFile, string texto) {
            try
            {
                if (File.Exists(outputFile))
                    File.Delete(outputFile);

                using (FileStream fs = File.Create(outputFile))
                {
                    byte[] byteText = new UTF8Encoding(true).GetBytes(texto);
                    fs.Write(byteText, 0, byteText.Length);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
