using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Monedas
    {
        public int IdMoneda { get; set; }
        public string CodigoMoneda { get; set; } = string.Empty;
        public string NombreMoneda { get; set; } = string.Empty;
        public string Simbolo { get; set; } = string.Empty;
        public int Decimales { get; set; }
        public bool Activo { get; set; }

        public List<TasasCambio> TasasCambio { get; set; } = new();
    }
}