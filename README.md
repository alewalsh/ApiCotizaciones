# Cotizaciones API
API para consultar la cotizacion del dolar, euro y real.

### Datos a tener en cuenta
- Se utilizó la API de https://www.currencyconverterapi.com/ debido a que la API del BCRA no expone métodos para obtener la cotización del Real y del Euro (o, por lo menos, no están en su documentación) y la API de cambio.today hasta el dia de la fecha (25-07-2019) retorna un 520 impidiendo su utilización. Cabe destacar que la API que está siendo utilizada necesita un apiKey que se obtiene mediante un registro en el sitio mencionado.
- Se implementó Swagger para documentar la API de manera simple y práctica, así como también para poder probar los métodos aprovechando su UI.
- Se creó una WebApp en paralelo para ejemplificar el uso de la API, cabe destacar que la API utilizada tiene limitaciones a las consultas por hora. Esto fue manejado haciendo que luego de superar ese límite devuelve 0 en todas las cotizaciones para evitar errores inesperados o crashes.
- Por limitaciones de CORS, no se levantan paralelamente la API y la WebApp, si no que se hizo un controller en la WebApp que consume el mismo Service. Idealmente, para realmente evitar el CORS, debería probarse publicando la API en un ambiente de desarrollo o testing y probar si la App llega correctamente
- Implementé un método adicional a los pedidos, el "all" (solo en el controller de la WebApp), que devuelve las 3 cotizaciones en una sola llamada logrando así una mayor simplicidad en el Component correspondiente.
