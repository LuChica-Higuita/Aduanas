using libreria_Aplicaciones.Entidades;
using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Importadores
    {
        public int IdImportador { get; set; }
        public int IdEnte { get; set; }
        public int IdMunicipio { get; set; }
        public string RepresentanteLegal { get; set; } = string.Empty;
        public string ActividadEconomica { get; set; } = string.Empty;
        public bool Activo { get; set; }

        public Entes? _Ente { get; set; }
        public Municipios? _Municipio { get; set; }
        public List<Exportadores> Exportadores { get; set; } = new();
        public List<NumerosDO> NumerosDOs { get; set; } = new();
    }

}