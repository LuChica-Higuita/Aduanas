using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosDetalleFacturaVenta
    {
        public static List<DetallesFacturasVentas> DetallesFacturasVentasList = new List<DetallesFacturasVentas>
        {
            new DetallesFacturasVentas { IdDetalleFacturaVenta = 1, IdFacturaVenta = 1, IdProducto = 1, Cantidad = 2, PrecioUnitario = 2500000m, Subtotal = 5000000m },
            new DetallesFacturasVentas { IdDetalleFacturaVenta = 2, IdFacturaVenta = 2, IdProducto = 3, Cantidad = 100, PrecioUnitario = 35000m, Subtotal = 3500000m },
            new DetallesFacturasVentas { IdDetalleFacturaVenta = 3, IdFacturaVenta = 3, IdProducto = 2, Cantidad = 5, PrecioUnitario = 1800000m, Subtotal = 9000000m },
            new DetallesFacturasVentas { IdDetalleFacturaVenta = 4, IdFacturaVenta = 4, IdProducto = 4, Cantidad = 20, PrecioUnitario = 85000m, Subtotal = 1700000m },
            new DetallesFacturasVentas { IdDetalleFacturaVenta = 5, IdFacturaVenta = 5, IdProducto = 5, Cantidad = 1, PrecioUnitario = 45000000m, Subtotal = 45000000m }
        };
    }
}