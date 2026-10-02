using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class CuentasPucs
    {
        public int IdCuentaPuc { get; set; }
        public string CodigoCuenta { get; set; } = string.Empty;
        public string NombreCuenta { get; set; } = string.Empty;
        public string TipoCuenta { get; set; } = string.Empty; // Activo, Pasivo, Patrimonio, Ingreso, Gasto
        public int Nivel { get; set; }
        public bool PermiteMovimiento { get; set; }
        public bool Activo { get; set; }

        public List<ConceptosGastosIngresos> ConceptosGastosIngresos { get; set; } = new();
    }
}
