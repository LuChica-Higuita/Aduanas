using System;
using libreria_Aplicaciones.Datos;

namespace cnl_Aduanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE ADUANAS");
            Console.WriteLine();

            Console.WriteLine("LISTA DE PAÍSES:");
            foreach (var pais in DatosPais.PaisesList)
            {
                Console.WriteLine($"ID: {pais.IdPais} | Código: {pais.CodigoPais} | Nombre: {pais.NombrePais}");
            }

            Console.WriteLine();
            Console.WriteLine("LISTA DE PRODUCTOS:");
            foreach (var producto in DatosProducto.ProductosList)
            {
                Console.WriteLine($"ID: {producto.IdProducto} | Nombre: {producto.NombreProducto} | Precio: ${producto.PrecioUnitario}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}