using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CotizacionesApi.Models;
using CotizacionesApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CotizacionesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CotizacionController : ControllerBase
    {
        private readonly ICotizacionService _bcraService;

        public CotizacionController(ICotizacionService bcraService)
        {
            _bcraService = bcraService;
        }

        [HttpGet("dolar")]
        public ActionResult<Cotizacion> GetCotizacionDolar()
        {
            return _bcraService.GetCotizacion(new Dolar());
        }
        [HttpGet("euro")]
        public ActionResult<Cotizacion> GetCotizacionEuro()
        {
            return _bcraService.GetCotizacion(new Euro());
        }
        [HttpGet("real")]
        public ActionResult<Cotizacion> GetCotizacionReal()
        {
            return _bcraService.GetCotizacion(new Real());
        }
    }
}