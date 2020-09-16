using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Entities
{
    [DataContract]
    public class Factura
    {
        /// <summary>
        /// Codigo unico de la factura
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Nit de la empresa emisora
        /// </summary>
        [DataMember]
        public int Nit { get; set; }

        /// <summary>
        /// Descripcion de la factura
        /// </summary>
        [DataMember]
        public string Descripcion { get; set; }

        /// <summary>
        /// Valor total a cobrar de la factura
        /// </summary>
        [DataMember]
        public double ValorTotal { get; set; }

        /// <summary>
        /// valor porcentual del impuesto de IVA
        /// </summary>
        [DataMember]
        public double porcentajeIva { get; set; }

    }
}
