using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Departamentos
    {
        public int IdDepartamento { get; set; }
        public string CodigoDepartamento { get; set; } = string.Empty;
        public string NombreDepartamento { get; set; } = string.Empty;
        public string Capital { get; set; } = string.Empty;
        public int Poblacion { get; set; }
        public int IdPais { get; set; }

        public Paises? _Pais { get; set; }
        public List<Municipios> Municipios { get; set; } = new();
        public List<Entes> Entes { get; set; } = new();
    }
}
