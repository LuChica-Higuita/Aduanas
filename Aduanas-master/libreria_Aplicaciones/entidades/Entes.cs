using System.Collections.Generic;

namespace libreria_Aplicaciones.Entidades
{
    public class Entes
    {
        public int IdEnte { get; set; }
        public string NombreEnte { get; set; } = string.Empty;
        public string IdentificacionEnte { get; set; } = string.Empty;
        public int IdPais { get; set; }
        public int IdDepartamento { get; set; }
        public int IdMunicipio { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public bool EsCliente { get; set; }
        public bool EsEmpleado { get; set; }
        public bool EsTercero { get; set; }
        public bool EsProveedor { get; set; }

        public Paises? _Pais { get; set; }
        public Departamentos? _Departamento { get; set; }
        public Municipios? _Municipio { get; set; }
        public List<Importadores> Importadores { get; set; } = new();
        public List<Exportadores> Exportadores { get; set; } = new();
        public List<Empleados> Empleados { get; set; } = new();
        public List<FacturasVentas> FacturasVentas { get; set; } = new();
    }
}
