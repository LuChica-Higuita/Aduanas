using libreria_Aplicaciones.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace libreria_Aplicaciones.interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

        DbSet<NumerosDO>? NumerosDOs { get; set; }
        DbSet<Empleados>? Empleados { get; set; }
        DbSet<FacturasVentas>? FacturasVentas { get; set; }
        DbSet<DetallesFacturasVentas>? DetallesFacturasVentas { get; set; }
        DbSet<ConceptosGastosIngresos>? ConceptosGastosIngresos { get; set; }
        DbSet<CuentasPucs>? CuentasPucs { get; set; }
        DbSet<MediosPago>? MediosPago { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
