using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Exportadores
    {
        public int IdExportador { get; set; }
        public int IdEnte { get; set; }
        public int IdMunicipio { get; set; }
        public string RepresentanteLegal { get; set; } = string.Empty;
        public string ActividadEconomica { get; set; } = string.Empty;
        public bool EsImportador { get; set; }
        public int IdImportador { get; set; }

        public Entes? _Ente { get; set; }
        public Municipios? _Municipio { get; set; }
        public Importadores? _ImportadorRef { get; set; }
        public List<NumerosDO> NumerosDOs { get; set; } = new();
    }
}