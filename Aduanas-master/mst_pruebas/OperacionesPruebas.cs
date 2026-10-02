using Microsoft.VisualStudio.TestTools.UnitTesting;
using libreria_Aplicaciones.Datos;
using System.Linq;

namespace mst_pruebas
{
    [TestClass]
    public class OperacionesPruebas
    {
        [TestMethod]
        public void Validar_ListaEmpleados_ExistenciaYSalarios()
        {
            // Arrange & Act
            var empleados = DatosEmpleado.EmpleadosList;

            // Assert
            Assert.IsNotNull(empleados);
            Assert.AreEqual(5, empleados.Count, "Debe haber 5 empleados registrados.");
            Assert.IsTrue(empleados.All(e => e.SalarioBase > 0), "Todos los empleados deben tener un salario mayor a 0.");
        }

        [TestMethod]
        public void Validar_NumerosDO_FormatoYExportadores()
        {
            // Arrange & Act
            var listaDO = DatosNumerosDO.NumerosDOsList;

            // Assert
            Assert.IsNotNull(listaDO);
            Assert.IsTrue(listaDO.All(d => d.NumeroDO.StartsWith("DO-2026-")), "Los DO deben tener el formato DO-2026-XXX.");
            Assert.IsTrue(listaDO.All(d => d.IdImportador > 0 && d.IdExportador > 0), "Cada DO debe estar asociado a un importador y exportador.");
        }
    }
}