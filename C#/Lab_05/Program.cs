using system;
using system.io;
using system.text;

class Program
{
    static string textFile="inventario.txt";
    static string binaryFile="inventario.dat";
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("SISTEMA DE GESTIÓN DE INVENTARIO");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Leer inventario");
            Console.WriteLine("3. Buscar producto");
            Console.WriteLine("4. Guardar datos en archivo binario");
            Console.WriteLine("5. Leer datos desde archivo binario");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
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
                    GuardarEnArchivoBinario(binaryFile);
                    break;
                case 5:
                    LeerDesdeArchivoBinario(binaryFile);
                    break;
            }
        }
        while (opcion != 6);
    }
}