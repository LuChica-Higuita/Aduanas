using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosSucursal
    {
        public static List<Sucursales> SucursalesList = new List<Sucursales>
        {
            new Sucursales { IdSucursal = 1, Prefijo = "SUC01", IdMunicipio = 2, NombreSucursal = "Sucursal Medellín Centro", DireccionSucursal = "Calle 10 #20-30", BaseReteICA = 2.5m, Activo = true },
            new Sucursales { IdSucursal = 2, Prefijo = "SUC02", IdMunicipio = 3, NombreSucursal = "Sucursal Bogotá Norte", DireccionSucursal = "Carrera 15 #100-20", BaseReteICA = 3.0m, Activo = true },
            new Sucursales { IdSucursal = 3, Prefijo = "SUC03", IdMunicipio = 4, NombreSucursal = "Sucursal Cali Sur", DireccionSucursal = "Av. Pasoancho #45-67", BaseReteICA = 2.8m, Activo = true },
            new Sucursales { IdSucursal = 4, Prefijo = "SUC04", IdMunicipio = 1, NombreSucursal = "Sucursal Itagüí", DireccionSucursal = "Cra 50 #30-40", BaseReteICA = 2.2m, Activo = true },
            new Sucursales { IdSucursal = 5, Prefijo = "SUC05", IdMunicipio = 5, NombreSucursal = "Sucursal Madrid España", DireccionSucursal = "Gran Vía 123", BaseReteICA = 4.0m, Activo = true }
        };
    }
}