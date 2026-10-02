using System;
using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Importaciones
    {
        public int IdImportacion { get; set; }
        public string NumeroRegistro { get; set; } = string.Empty;
        public DateTime FechaFactura { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaEmbarque { get; set; }
        public int IdPais { get; set; }
        public int IdMunicipio { get; set; }
        public decimal ValorImportacion { get; set; }
        public bool Activo { get; set; }

        public Paises? _Pais { get; set; }
        public Municipios? _Municipio { get; set; }
        public List<DocumentosTransportes> DocumentosTransportes { get; set; } = new();
    }
}