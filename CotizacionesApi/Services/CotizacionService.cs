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
        public Cotizacion GetCotizacion(Cotizacion cotizacion)
        {
            return new Cotizacion
            {
               Moneda = cotizacion.Moneda,
               Precio = 32.8
            };
        }
    }
}
