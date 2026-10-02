using Microsoft.VisualStudio.TestTools.UnitTesting;
using libreria_Aplicaciones.Entidades;
using libreria_Aplicaciones.implementaciones;
using libreria_Aplicaciones.interfaces;

namespace mst_pruebas
{
    [TestClass]
    public class AduanasPruebas
    {
        private IConexion conexion;

        public AduanasPruebas()
        {
            this.conexion = new Conexion();
            // Asegúrate de que la clase DatosGenerales exista en la namespace adecuada
            // this.conexion.StringConexion = DatosGenerales.StringConexion();
        }

        [TestMethod]
        public void ValidarConexionBaseDatos()
        {
            Assert.IsNotNull(conexion, "La instancia de conexión no debe ser nula.");
        }
    }
}
