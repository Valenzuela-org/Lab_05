using System;
using System.IO;
using System.Text;

class Program
{
    static string textFile="Inventario.txt";
    static string binaryFile="Inventario.dat";

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("---SISTEMA DE INVENTARIO---");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Leer inventario");
            Console.WriteLine("3. Buscar producto");
            Console.WriteLine("4. Guardar datos en archivo binario");
            Console.WriteLine("5. Leer datos desde archivo binario");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

            switch (opcion)
            {
                case 1:
                    RegistrarProducto();
                    break;
                case 2:
                    LeerInventario();
                    break;
                case 3:
                    BuscarProducto();
                    break;
                case 4:
                    GuardarDatosBinario();
                    break;
                case 5:
                    LeerDatosBinario();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
        while (opcion != 6);
    }
}