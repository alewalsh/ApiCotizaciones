using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class Cotizacion
    {
        public virtual string Moneda { get; set; }
        public double Precio { get; set; }
    }

    public enum EnumMoneda
    {
        [Description("Dolar")]
        USD = 1,
        [Description("Euro")]
        Euro,
        [Description("Real")]
        Real
    }
}
