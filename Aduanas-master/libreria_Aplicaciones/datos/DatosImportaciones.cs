using System;
using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosImportaciones
    {
        public static List<Importaciones> ImportacionesList = new List<Importaciones>
        {
            new Importaciones { IdImportacion = 1, NumeroRegistro = "IMP-2026-001", FechaFactura = new DateTime(2026, 1, 10), FechaLlegada = new DateTime(2026, 1, 20), FechaEmbarque = new DateTime(2026, 1, 15), IdPais = 1, IdMunicipio = 2, ValorImportacion = 5000000m, Activo = true },
            new Importaciones { IdImportacion = 2, NumeroRegistro = "IMP-2026-002", FechaFactura = new DateTime(2026, 2, 5), FechaLlegada = new DateTime(2026, 2, 18), FechaEmbarque = new DateTime(2026, 2, 10), IdPais = 2, IdMunicipio = 3, ValorImportacion = 3500000m, Activo = true },
            new Importaciones { IdImportacion = 3, NumeroRegistro = "IMP-2026-003", FechaFactura = new DateTime(2026, 3, 8), FechaLlegada = new DateTime(2026, 3, 22), FechaEmbarque = new DateTime(2026, 3, 12), IdPais = 3, IdMunicipio = 4, ValorImportacion = 9000000m, Activo = false },
            new Importaciones { IdImportacion = 4, NumeroRegistro = "IMP-2026-004", FechaFactura = new DateTime(2026, 4, 2), FechaLlegada = new DateTime(2026, 4, 15), FechaEmbarque = new DateTime(2026, 4, 8), IdPais = 4, IdMunicipio = 5, ValorImportacion = 1700000m, Activo = true },
            new Importaciones { IdImportacion = 5, NumeroRegistro = "IMP-2026-005", FechaFactura = new DateTime(2026, 5, 12), FechaLlegada = new DateTime(2026, 5, 25), FechaEmbarque = new DateTime(2026, 5, 18), IdPais = 5, IdMunicipio = 1, ValorImportacion = 45000000m, Activo = true }
        };
    }
}