using System;
using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class FacturasVentas
    {
        public int IdFacturaVenta { get; set; }
        public string NumeroFactura { get; set; } = string.Empty;
        public DateTime FechaFactura { get; set; }
        public int IdCliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public bool Pagada { get; set; }

        public Entes? _Cliente { get; set; }
        public List<DetallesFacturasVentas> DetallesFacturasVentas { get; set; } = new();
    }
}
