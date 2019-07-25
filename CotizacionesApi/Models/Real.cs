using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class Real : Cotizacion
    {
        public override string Moneda => "Real";
    }
}
