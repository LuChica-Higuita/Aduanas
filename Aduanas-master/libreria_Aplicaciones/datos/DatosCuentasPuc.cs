using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosCuentaPuc
    {
        public static List<CuentasPucs> CuentasPucsList = new List<CuentasPucs>
        {
            new CuentasPucs { IdCuentaPuc = 1, CodigoCuenta = "110505", NombreCuenta = "Caja", TipoCuenta = "Activo", Activo = true },
            new CuentasPucs { IdCuentaPuc = 2, CodigoCuenta = "130505", NombreCuenta = "Clientes", TipoCuenta = "Activo", Activo = true },
            new CuentasPucs { IdCuentaPuc = 3, CodigoCuenta = "220505", NombreCuenta = "Proveedores", TipoCuenta = "Pasivo", Activo = true },
            new CuentasPucs { IdCuentaPuc = 4, CodigoCuenta = "410505", NombreCuenta = "Ingresos por Ventas", TipoCuenta = "Ingreso", Activo = true },
            new CuentasPucs { IdCuentaPuc = 5, CodigoCuenta = "510505", NombreCuenta = "Gastos Administrativos", TipoCuenta = "Gasto", Activo = true }
        };
    }
}   