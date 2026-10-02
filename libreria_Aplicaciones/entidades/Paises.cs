using System.ComponentModel.DataAnnotations;

namespace libreria_Aplicaciones.Entidades
{
    public class Paises
    {
        [Key]
        public int IdPais { get; set; }

        public string CodigoPais { get; set; } = string.Empty;

        public string NombrePais { get; set; } = string.Empty;

        public string Continente { get; set; } = string.Empty;

        public string IdiomaOficial { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;
    }
}
