using CotizacionesApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CotizacionesApi.Helpers
{
    public class ApiHandler
    {
        public async Task<Cotizacion> Get(Moneda moneda)
        {
            const string currencyKey = "d0da54f39a6420a5c247";
            using (var client = new HttpClient())
            {
                var url = new Uri($"https://free.currconv.com/api/v7/convert?q={moneda.CodigoISO4217}_ARS&compact=ultra&apiKey={currencyKey}");
                var response = await client.GetAsync(url);
                string json = String.Empty;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                CotizacionResponse conversion = JsonConvert.DeserializeObject(json, moneda.Response.GetType()) as CotizacionResponse;
                return new Cotizacion
                {
                    Moneda = moneda.Nombre.ToLower(),
                    Precio = conversion.Valor
                };
            }
        }
    }
}
