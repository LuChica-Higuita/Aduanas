using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }

        public List<DetallesFacturasVentas> DetallesFacturasVentas { get; set; } = new();
    }
}