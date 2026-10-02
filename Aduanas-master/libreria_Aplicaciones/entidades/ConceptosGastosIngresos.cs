namespace libreria_Aplicaciones.Entidades
{
    public class ConceptosGastosIngresos
    {
        public int IdConceptoGastoIngreso { get; set; }
        public string CodigoConcepto { get; set; } = string.Empty;
        public string NombreConcepto { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // "Gasto" o "Ingreso"
        public int IdCuentaPuc { get; set; }
        public bool Activo { get; set; }

        public CuentasPucs? _CuentaPuc { get; set; }
    }
}