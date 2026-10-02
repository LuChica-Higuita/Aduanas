using System;

namespace libreria_Aplicaciones.Entidades
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public int IdEnte { get; set; }
        public string Cargo { get; set; } = string.Empty;
        public string Area { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }
        public decimal SalarioBase { get; set; }
        public bool Activo { get; set; }

        public Entes? _Ente { get; set; }
    }
}