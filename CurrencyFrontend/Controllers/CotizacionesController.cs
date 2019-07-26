using CotizacionesApi.Models;
using CotizacionesApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CotizacionesApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class CotizacionesController : ControllerBase
    {
        private readonly ICotizacionService _currencyService;

        public CotizacionesController(ICotizacionService curencyService)
        {
            _currencyService = curencyService;
        }
        /// <summary>
        /// Devuelve la cotización del dolar a la fecha.
        /// </summary>
        /// <returns>Un objeto Cotización</returns>
        /// <response code="200">Devuelve el objeto cotización</response>
        /// <response code="404">Si la cotización llega como objeto nulo</response> 
        /// <response code="500">Si no hay conexión o hubo un error interno del servidor</response> 
        [HttpGet("dolar")]
        public async Task<ActionResult<Cotizacion>> GetCotizacionDolar()
        {
            Cotizacion cotizacion = await _currencyService.GetCotizacionAsync(new Dolar());
            if (cotizacion != null)
            {
                return Ok(cotizacion);
            }
            else
            {
                return NotFound();
            }
        }
        /// <summary>
        /// Devuelve la cotizacion del euro a la fecha.
        /// </summary>
        /// <returns>Un objeto Cotizacion con atributos Moneda y Precio</returns>
        /// <response code="200">Devuelve el objeto cotización</response>
        /// <response code="404">Si la cotización llega como objeto nulo</response> 
        /// <response code="500">Si no hay conexión o hubo un error interno del servidor</response> 
        [HttpGet("euro")]
        public async Task<ActionResult<Cotizacion>> GetCotizacionEuro()
        {
            Cotizacion cotizacion = await _currencyService.GetCotizacionAsync(new Euro());
            if (cotizacion != null)
            {
                return Ok(cotizacion);
            }
            else
            {
                return NotFound();
            }
        }
        /// <summary>
        /// Devuelve la cotizacion del real a la fecha.
        /// </summary>
        /// <returns>Un objeto Cotizacion con atributos Moneda y Precio</returns>
        /// <response code="200">Devuelve el objeto cotización</response>
        /// <response code="404">Si la cotización llega como objeto nulo</response> 
        /// <response code="500">Si no hay conexión o hubo un error interno del servidor</response> 
        [HttpGet("real")]
        public async Task<ActionResult<Cotizacion>> GetCotizacionReal()
        {
            Cotizacion cotizacion = await _currencyService.GetCotizacionAsync(new Real());
            if (cotizacion != null)
            {
                return Ok(cotizacion);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<Cotizacion>>> GetCotizaciones()
        {
            List<Cotizacion> cotizaciones = new List<Cotizacion>();
            Cotizacion cotizacionDolar = await _currencyService.GetCotizacionAsync(new Dolar());
            Cotizacion cotizacionEuro = await _currencyService.GetCotizacionAsync(new Euro());
            Cotizacion cotizacionReal = await _currencyService.GetCotizacionAsync(new Real());
            cotizaciones.Add(cotizacionDolar);
            cotizaciones.Add(cotizacionEuro);
            cotizaciones.Add(cotizacionReal);
            if (cotizaciones != null)
            {
                return Ok(cotizaciones);
            }
            else
            {
                return NotFound();
            }
        }
    }
}