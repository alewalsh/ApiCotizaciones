﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CotizacionesApi.Models
{
    public class Real : Moneda
    {
        public override string Nombre => "Real";
        public override string Abreviatura => "REA";
    }
}
