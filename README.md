# Cotizaciones API
API para consultar la cotizacion del dolar, euro y real.

### Datos a tener en cuenta
- Se utilizó la API de https://www.currencyconverterapi.com/ debido a que la API del BCRA no expone métodos para obtener la cotización del Real y del Euro (o, por lo menos, no están en su documentación) y la API de cambio.today hasta el dia de la fecha (25-07-2019) retorna un 520 impidiendo su utilización. Cabe destacar que la API que está siendo utilizada necesita un apiKey que se obtiene mediante un registro en el sitio mencionado.
- Se implementó Swagger para documentar la API de manera simple y práctica, así como también para poder probar los métodos aprovechando su UI.
