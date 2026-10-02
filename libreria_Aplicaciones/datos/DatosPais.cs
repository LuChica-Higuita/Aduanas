using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosPais
    {
        public static List<Paises> PaisesList = new List<Paises>
        {
            new Paises { IdPais = 1, CodigoPais = "COL", NombrePais = "Colombia", Continente = "América del Sur", IdiomaOficial = "Español", Activo = true },
            new Paises { IdPais = 2, CodigoPais = "USA", NombrePais = "Estados Unidos", Continente = "América del Norte", IdiomaOficial = "Inglés", Activo = true },
            new Paises { IdPais = 3, CodigoPais = "DEU", NombrePais = "Alemania", Continente = "Europa", IdiomaOficial = "Alemán", Activo = true },
            new Paises { IdPais = 4, CodigoPais = "JPN", NombrePais = "Japón", Continente = "Asia", IdiomaOficial = "Japonés", Activo = true },
            new Paises { IdPais = 5, CodigoPais = "BRA", NombrePais = "Brasil", Continente = "América del Sur", IdiomaOficial = "Portugués", Activo = true }
        };
    }
}
