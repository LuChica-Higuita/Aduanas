using System;
using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosEmpleado
    {
        public static List<Empleados> EmpleadosList = new List<Empleados>
        {
            new Empleados { IdEmpleado = 1, IdEnte = 4, Cargo = "Agente Aduanero", FechaIngreso = new DateTime(2020, 5, 10), SalarioBase = 3500000m, Activo = true },
            new Empleados { IdEmpleado = 2, IdEnte = 1, Cargo = "Analista Logístico", FechaIngreso = new DateTime(2019, 3, 15), SalarioBase = 4200000m, Activo = true },
            new Empleados { IdEmpleado = 3, IdEnte = 2, Cargo = "Coordinador de Exportaciones", FechaIngreso = new DateTime(2021, 7, 1), SalarioBase = 5000000m, Activo = true },
            new Empleados { IdEmpleado = 4, IdEnte = 3, Cargo = "Especialista en Importaciones", FechaIngreso = new DateTime(2018, 11, 20), SalarioBase = 4800000m, Activo = false },
            new Empleados { IdEmpleado = 5, IdEnte = 5, Cargo = "Gestor Comercial", FechaIngreso = new DateTime(2022, 1, 15), SalarioBase = 3000000m, Activo = true }
        };
    }
}