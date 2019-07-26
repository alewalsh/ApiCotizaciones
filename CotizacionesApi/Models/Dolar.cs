namespace CotizacionesApi.Models
{
    public class Dolar : Moneda
    {
        public override string Nombre => "Dolar";
        public override string CodigoISO4217 => "USD";
        public override CotizacionResponse Response => new DolarResponse();
    }
}

