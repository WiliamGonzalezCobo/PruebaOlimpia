using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Validacion
    {
        public static bool validarFormatoNumero(string valor)
        {
            double resultado = 0;
            return double.TryParse(valor, out resultado);
        }

        public static bool validarNumeroPositivo(double numero)
        {
            return numero > 0;
        }

        public static bool validarIdFacturaRepetido(List<Factura> lstFacturas)
        {
            var queryFacturaAgrupada =
            from factura in lstFacturas
            group factura by factura.Id into newGroup
            orderby newGroup.Key
            select newGroup;
            return queryFacturaAgrupada.Count() < lstFacturas.Count();
        }

        public static bool validarRangoNumerico(double numero,int inicia, int termina)
        {
            return numero >= inicia && numero <= termina;
        }

        public static string validarFactura(Factura factura) {
            if (!validarFormatoNumero(factura.Id.ToString()))
                return string.Format("Factura {0}: Id no tiene un formato numerico", factura.Id);

            if (!validarNumeroPositivo(factura.Id))
                return string.Format("Factura {0}: Id debe ser un numero positivo", factura.Id);

            if (!validarFormatoNumero(factura.Nit.ToString()))
                return string.Format("Factura {0}: Nit no tiene un formato numerico", factura.Id);

            if (!validarNumeroPositivo(factura.ValorTotal))
                return string.Format("Factura {0}: Total debe ser un numero positivo", factura.Id);

            int inicio = 0, fin = 100;
            if (!validarRangoNumerico(factura.porcentajeIva, inicio, fin))
                return string.Format("Factura {0}: Iva debe ser un numero entre {1} y {2} ", factura.Id, inicio, fin);
            return string.Empty;
        }


    }
}
