using System;
using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosNumerosDO
    {
        public static List<NumerosDO> NumerosDOsList = new List<NumerosDO>
        {
            new NumerosDO { IdNumeroDO = 1, NumeroDO = "DO-2026-001", FechaApertura = new DateTime(2026, 1, 15), IdImportador = 1, IdExportador = 2, Activo = true },
            new NumerosDO { IdNumeroDO = 2, NumeroDO = "DO-2026-002", FechaApertura = new DateTime(2026, 2, 10), IdImportador = 2, IdExportador = 3, Activo = true },
            new NumerosDO { IdNumeroDO = 3, NumeroDO = "DO-2026-003", FechaApertura = new DateTime(2026, 3, 5), IdImportador = 3, IdExportador = 4, Activo = false },
            new NumerosDO { IdNumeroDO = 4, NumeroDO = "DO-2026-004", FechaApertura = new DateTime(2026, 4, 20), IdImportador = 4, IdExportador = 5, Activo = true },
            new NumerosDO { IdNumeroDO = 5, NumeroDO = "DO-2026-005", FechaApertura = new DateTime(2026, 5, 12), IdImportador = 5, IdExportador = 1, Activo = true }
        };
    }
}
