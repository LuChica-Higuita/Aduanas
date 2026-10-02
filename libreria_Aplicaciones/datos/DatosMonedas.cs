using System.Collections.Generic;
using libreria_Aplicaciones.Entidades;

namespace libreria_Aplicaciones.Datos
{
    public static class DatosMoneda
    {
        public static List<Monedas> MonedasList = new List<Monedas>
        {
            new Monedas { IdMoneda = 1, CodigoMoneda = "COP", NombreMoneda = "Peso Colombiano", Simbolo = "$", Decimales = 2, Activo = true },
            new Monedas { IdMoneda = 2, CodigoMoneda = "USD", NombreMoneda = "Dólar Estadounidense", Simbolo = "$", Decimales = 2, Activo = true },
            new Monedas { IdMoneda = 3, CodigoMoneda = "EUR", NombreMoneda = "Euro", Simbolo = "€", Decimales = 2, Activo = true },
            new Monedas { IdMoneda = 4, CodigoMoneda = "BRL", NombreMoneda = "Real Brasileño", Simbolo = "R$", Decimales = 2, Activo = true },
            new Monedas { IdMoneda = 5, CodigoMoneda = "CNY", NombreMoneda = "Yuan Chino", Simbolo = "¥", Decimales = 2, Activo = true }
        };
    }
}