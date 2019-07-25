using CotizacionesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Services.Interfaces
{
    public interface ICotizacionService
    {
        Cotizacion GetCotizacion(Moneda moneda);
    }
}
