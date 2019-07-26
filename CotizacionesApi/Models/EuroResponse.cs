using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class EuroResponse : CotizacionResponse
    {
        [JsonProperty("EUR_ARS")]
        public override double Valor { get; set; }
    }
}
