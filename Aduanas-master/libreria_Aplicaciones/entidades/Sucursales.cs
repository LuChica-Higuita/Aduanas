namespace libreria_Aplicaciones.Entidades
{
    public class Sucursales
    {
        public int IdSucursal { get; set; }
        public string Prefijo { get; set; } = string.Empty;
        public int IdMunicipio { get; set; }
        public string NombreSucursal { get; set; } = string.Empty;
        public string DireccionSucursal { get; set; } = string.Empty;
        public decimal BaseReteICA { get; set; }
        public bool Activo { get; set; }

        public Municipios? _Municipio { get; set; }
    }
}
