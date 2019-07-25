using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class Euro : Moneda
    {
        public override string Nombre => "Euro";
        public override string Abreviatura => "EUR";
    }
}
