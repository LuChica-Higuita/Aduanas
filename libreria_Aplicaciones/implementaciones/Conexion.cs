using libreria_Aplicaciones.Entidades;
using libreria_Aplicaciones.interfaces;
using Microsoft.EntityFrameworkCore;

namespace libreria_Aplicaciones.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(this.StringConexion))
            {
                optionsBuilder.UseSqlServer(this.StringConexion, p => { });
            }
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<NumerosDO>? NumerosDOs { get; set; }
        public DbSet<Empleados>? Empleados { get; set; }
        public DbSet<FacturasVentas>? FacturasVentas { get; set; }
        public DbSet<DetallesFacturasVentas>? DetallesFacturasVentas { get; set; }
        public DbSet<ConceptosGastosIngresos>? ConceptosGastosIngresos { get; set; }
        public DbSet<CuentasPucs>? CuentasPucs { get; set; }
        public DbSet<MediosPago>? MediosPago { get; set; }
    }
}