using CotizacionesApi.Helpers;
using CotizacionesApi.Models;
using CotizacionesApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Services
{
    public class CotizacionService : ICotizacionService
    {
        public async Task<Cotizacion> GetCotizacionAsync(Moneda moneda)
        {
            ApiHandler api = new ApiHandler();
            return await api.Get(moneda);
        }
    }
}
