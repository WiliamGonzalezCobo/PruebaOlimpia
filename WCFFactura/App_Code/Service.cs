using Entities;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{

    public SumaFacturasRespuesta SumarTotales(List<Factura> facturas)
    {
        double sumaTotal = 0;
        SumaFacturasRespuesta respuesta = new SumaFacturasRespuesta();
        try
        {
            if (Validacion.validarIdFacturaRepetido(facturas))
                respuesta.Mensaje = "Id de Facturas repetido";

            if (string.IsNullOrEmpty(respuesta.Mensaje))
            {
                foreach (var factura in facturas)
                {
                    respuesta.Mensaje = Validacion.validarFactura(factura);
                    if (!string.IsNullOrEmpty(respuesta.Mensaje))
                    {
                        sumaTotal = 0;
                        break;
                    }
                    else
                    {
                        sumaTotal += factura.ValorTotal;
                    }
                }
            }
            respuesta.Suma = sumaTotal;
            return respuesta;
        }
        catch (Exception ex)
        {
            respuesta.Mensaje = ex.ToString();
            return respuesta;
        }
    }

    public ValidarFacturaRespuesta validarFactura(Factura factura)
    {
        ValidarFacturaRespuesta respuesta = new ValidarFacturaRespuesta();
        try
        {
            respuesta.Mensaje = Validacion.validarFactura(factura);
            respuesta.FacturaValida = string.IsNullOrEmpty(respuesta.Mensaje);
            return respuesta;
        }
        catch (Exception ex)
        {
            respuesta.Mensaje = ex.ToString();
            respuesta.FacturaValida = false;
            return respuesta;
        }
    }

    public CalcularIvaRespuesta calcularIva(Factura factura)
    {
        CalcularIvaRespuesta respuesta = new CalcularIvaRespuesta();
        try
        {
            respuesta.Mensaje = Validacion.validarFactura(factura);
            if (string.IsNullOrEmpty(respuesta.Mensaje))
                respuesta.MontoIva = factura.ValorTotal * factura.porcentajeIva / 100;
            return respuesta;
        }
        catch (Exception ex)
        {
            respuesta.Mensaje = ex.ToString();
            respuesta.MontoIva = 0;
            return respuesta;
        }
    }
}
