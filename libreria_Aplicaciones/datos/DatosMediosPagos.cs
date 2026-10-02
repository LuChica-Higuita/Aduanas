using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosMedioPago
    {
        public static List<MediosPago> MediosPagoList = new List<MediosPago>
        {
            new MediosPago { IdMedioPago = 1, CodigoMedioPago = "MP001", NombreMedioPago = "Efectivo", Activo = true },
            new MediosPago { IdMedioPago = 2, CodigoMedioPago = "MP002", NombreMedioPago = "Transferencia Bancaria", Activo = true },
            new MediosPago { IdMedioPago = 3, CodigoMedioPago = "MP003", NombreMedioPago = "Tarjeta de Crédito", Activo = true },
            new MediosPago { IdMedioPago = 4, CodigoMedioPago = "MP004", NombreMedioPago = "Tarjeta Débito", Activo = true }
        };
    }
}
