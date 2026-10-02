using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Municipios
    {
        public int IdMunicipio { get; set; }
        public string CodigoMunicipio { get; set; } = string.Empty;
        public string NombreMunicipio { get; set; } = string.Empty;
        public string Alcalde { get; set; } = string.Empty;
        public int Poblacion { get; set; }
        public int IdDepartamento { get; set; }

        public Departamentos? _Departamento { get; set; }
        public List<Sucursales> Sucursales { get; set; } = new();
        public List<Entes> Entes { get; set; } = new();
        public List<Importadores> Importadores { get; set; } = new();
        public List<Exportadores> Exportadores { get; set; } = new();
        public List<Importaciones> Importaciones { get; set; } = new();
        public List<Exportaciones> Exportaciones { get; set; } = new();
    }
}