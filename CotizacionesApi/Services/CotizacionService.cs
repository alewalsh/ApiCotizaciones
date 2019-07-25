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
        public Cotizacion GetCotizacion(Moneda moneda)
        {
            return new Cotizacion
            {
               Moneda = moneda.Nombre,
               Precio = 32.8
            };
        }
    }
}
