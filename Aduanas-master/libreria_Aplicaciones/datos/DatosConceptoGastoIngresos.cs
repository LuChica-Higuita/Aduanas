using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosConceptoGastoIngreso
    {
        public static List<ConceptosGastosIngresos> ConceptosGastosIngresosList = new List<ConceptosGastosIngresos>
        {
            new ConceptosGastosIngresos { IdConceptoGastoIngreso = 1, CodigoConcepto = "CG1001", NombreConcepto = "Transporte Internacional", Tipo = "Gasto", Activo = true },
            new ConceptosGastosIngresos { IdConceptoGastoIngreso = 2, CodigoConcepto = "CG1002", NombreConcepto = "Impuestos Aduaneros", Tipo = "Gasto", Activo = true },
            new ConceptosGastosIngresos { IdConceptoGastoIngreso = 3, CodigoConcepto = "CG1003", NombreConcepto = "Venta de Productos", Tipo = "Ingreso", Activo = true },
            new ConceptosGastosIngresos { IdConceptoGastoIngreso = 4, CodigoConcepto = "CG1004", NombreConcepto = "Servicios Logísticos", Tipo = "Ingreso", Activo = false },
            new ConceptosGastosIngresos { IdConceptoGastoIngreso = 5, CodigoConcepto = "CG1005", NombreConcepto = "Almacenamiento", Tipo = "Gasto", Activo = true }
        };
    }
}
