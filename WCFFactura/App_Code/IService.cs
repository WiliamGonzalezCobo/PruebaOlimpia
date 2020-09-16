using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
	[OperationContract]
	SumaFacturasRespuesta SumarTotales(List<Factura> facturas);

	[OperationContract]
	ValidarFacturaRespuesta validarFactura(Factura factura);

	[OperationContract]
	CalcularIvaRespuesta calcularIva(Factura factura);
}
