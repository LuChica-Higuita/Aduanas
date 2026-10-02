using System;
using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosExportaciones
    {
        public static List<Exportaciones> ExportacionesList = new List<Exportaciones>
        {
            new Exportaciones { IdExportacion = 1, NumeroRegistro = "EXP-2026-001", FechaFactura = new DateTime(2026, 1, 12), FechaLlegada = new DateTime(2026, 1, 25), FechaEmbarque = new DateTime(2026, 1, 18), IdPais = 1, IdMunicipio = 3, ValorExportacion = 7000000m, Activo = true },
            new Exportaciones { IdExportacion = 2, NumeroRegistro = "EXP-2026-002", FechaFactura = new DateTime(2026, 2, 8), FechaLlegada = new DateTime(2026, 2, 20), FechaEmbarque = new DateTime(2026, 2, 14), IdPais = 2, IdMunicipio = 4, ValorExportacion = 4200000m, Activo = true },
            new Exportaciones { IdExportacion = 3, NumeroRegistro = "EXP-2026-003", FechaFactura = new DateTime(2026, 3, 10), FechaLlegada = new DateTime(2026, 3, 24), FechaEmbarque = new DateTime(2026, 3, 16), IdPais = 3, IdMunicipio = 5, ValorExportacion = 12000000m, Activo = false },
            new Exportaciones { IdExportacion = 4, NumeroRegistro = "EXP-2026-004", FechaFactura = new DateTime(2026, 4, 5), FechaLlegada = new DateTime(2026, 4, 18), FechaEmbarque = new DateTime(2026, 4, 12), IdPais = 4, IdMunicipio = 1, ValorExportacion = 2500000m, Activo = true },
            new Exportaciones { IdExportacion = 5, NumeroRegistro = "EXP-2026-005", FechaFactura = new DateTime(2026, 5, 15), FechaLlegada = new DateTime(2026, 5, 28), FechaEmbarque = new DateTime(2026, 5, 20), IdPais = 5, IdMunicipio = 2, ValorExportacion = 60000000m, Activo = true }
        };
    }
}