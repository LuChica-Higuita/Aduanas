namespace libreria_Aplicaciones.Entidades
{
    public class DetallesFacturasVentas
    {
        public int IdDetalleFacturaVenta { get; set; }
        public int IdFacturaVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public FacturasVentas? _FacturaVenta { get; set; }
        public Productos? _Producto { get; set; }
    }
}
