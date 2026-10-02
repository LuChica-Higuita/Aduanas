namespace libreria_Aplicaciones.Entidades
{
    public class TasasCambio
    {
        public int IdTasaCambio { get; set; }
        public int Ano { get; set; }
        public int Semana { get; set; }
        public int IdMoneda { get; set; }
        public decimal Cambio { get; set; }
        public string Fuente { get; set; } = string.Empty;

        public Monedas? _Moneda { get; set; }
    }
}
