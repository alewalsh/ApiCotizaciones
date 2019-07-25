using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class Euro : Cotizacion
    {
        public override string Moneda => "Euro";
    }
}
