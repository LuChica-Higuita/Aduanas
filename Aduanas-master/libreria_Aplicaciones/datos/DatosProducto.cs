using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosProducto
    {
        public static List<Productos> ProductosList = new List<Productos>
        {
            new Productos { IdProducto = 1, CodigoProducto = "TEC001", NombreProducto = "Laptop Lenovo", Descripcion = "Laptop de 15 pulgadas", PrecioUnitario = 2500000m, Stock = 50, Activo = true },
            new Productos { IdProducto = 2, CodigoProducto = "TEC002", NombreProducto = "Smartphone Samsung", Descripcion = "Teléfono inteligente Galaxy", PrecioUnitario = 1800000m, Stock = 100, Activo = true },
            new Productos { IdProducto = 3, CodigoProducto = "ALI001", NombreProducto = "Café Colombiano", Descripcion = "Café premium exportación", PrecioUnitario = 35000m, Stock = 500, Activo = true },
            new Productos { IdProducto = 4, CodigoProducto = "TXT001", NombreProducto = "Camisa de algodón", Descripcion = "Camisa manga larga", PrecioUnitario = 85000m, Stock = 200, Activo = true },
            new Productos { IdProducto = 5, CodigoProducto = "MAQ001", NombreProducto = "Excavadora Caterpillar", Descripcion = "Excavadora hidráulica", PrecioUnitario = 45000000m, Stock = 5, Activo = false }
        };
    }
}