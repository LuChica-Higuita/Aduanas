namespace libreria_Aplicaciones.Entidades
{
    public class MediosPago
    {
        public int IdMedioPago { get; set; }
        public string CodigoMedioPago { get; set; } = string.Empty;
        public string NombreMedioPago { get; set; } = string.Empty;
        public bool RequiereReferencia { get; set; }
        public bool Activo { get; set; }
    }
}
