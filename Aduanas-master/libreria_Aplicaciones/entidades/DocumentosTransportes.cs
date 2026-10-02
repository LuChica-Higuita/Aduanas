using System;

namespace libreria_Aplicaciones.Entidades
{
    public class DocumentosTransportes
    {
        public int IdDocumentoTransporte { get; set; }
        public string TipoDocumento { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public DateTime FechaEmision { get; set; }
        public int IdImportacion { get; set; }
        public int IdExportacion { get; set; }
        public bool Vigente { get; set; }

        public Importaciones? _Importacion { get; set; }
        public Exportaciones? _Exportacion { get; set; }
    }
}