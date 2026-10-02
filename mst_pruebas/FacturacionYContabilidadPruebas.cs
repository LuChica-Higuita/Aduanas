using Microsoft.VisualStudio.TestTools.UnitTesting;
using libreria_Aplicaciones.Datos;
using System.Linq;

namespace mst_pruebas
{
    [TestClass]
    public class FacturacionYContabilidadPruebas
    {
        [TestMethod]
        public void Validar_Subtotales_DetallesFacturasVentas()
        {
            // Arrange & Act
            var detalles = DatosDetalleFacturaVenta.DetallesFacturasVentasList;

            // Assert
            foreach (var detalle in detalles)
            {
                decimal subtotalCalculado = detalle.Cantidad * detalle.PrecioUnitario;
                Assert.AreEqual(subtotalCalculado, detalle.Subtotal, $"El subtotal del detalle {detalle.IdDetalleFacturaVenta} es incorrecto.");
            }
        }

        [TestMethod]
        public void Validar_CuentasPUC_Y_Conceptos()
        {
            // Arrange
            var cuentas = DatosCuentaPuc.CuentasPucsList;
            var conceptos = DatosConceptoGastoIngreso.ConceptosGastosIngresosList;

            // Assert
            Assert.AreEqual(5, cuentas.Count, "Deben existir 5 cuentas PUC registradas.");
            Assert.IsTrue(conceptos.All(c => c.Tipo == "Gasto" || c.Tipo == "Ingreso"), "Los conceptos solo pueden ser de tipo 'Gasto' o 'Ingreso'.");
        }

        [TestMethod]
        public void Validar_MediosPago_ListaActiva()
        {
            // Arrange & Act
            var medios = DatosMedioPago.MediosPagoList;

            // Assert
            Assert.IsNotNull(medios);
            Assert.IsTrue(medios.Any(m => m.NombreMedioPago == "Efectivo"));
            Assert.IsTrue(medios.All(m => m.Activo), "Todos los medios de pago configurados deben estar activos.");
        }
    }
}