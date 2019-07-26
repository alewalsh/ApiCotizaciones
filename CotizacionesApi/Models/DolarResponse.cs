﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class DolarResponse : CotizacionResponse
    {
        [JsonProperty("USD_ARS")]
        public override double Valor { get; set; }
    }
}
