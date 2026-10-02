using System;

namespace libreria_Aplicaciones.Entidades
{
    public class NumerosDO
    {
        public int IdNumeroDO { get; set; }
        public string NumeroDO { get; set; } = string.Empty;
        public int IdImportador { get; set; }
        public int IdExportador { get; set; }
        public DateTime FechaApertura { get; set; }
        public string Estado { get; set; } = string.Empty;
        public bool Activo { get; set; }

        public Importadores? _Importador { get; set; }
        public Exportadores? _Exportador { get; set; }
    }
}