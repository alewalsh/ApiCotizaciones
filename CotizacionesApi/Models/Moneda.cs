using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public abstract class Moneda
    {
        public virtual string Nombre { get; set; }
        public virtual string CodigoISO4217 { get; set; }
        public virtual CotizacionResponse Response { get; set; }
    }
}
