using System;

namespace TecnoPuntoInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE INVENTARIO TECNOPUNTO ===\n");

            // --- PRODUCTO 1 ---
            Console.WriteLine("Ingrese los datos del Producto 1:");
            Console.Write("Código: ");
            string cod1 = Console.ReadLine();

            Console.Write("Nombre: ");
            string nom1 = Console.ReadLine();
            while (nom1 == "")
            {
                Console.Write("Error: El nombre no puede estar vacío. Ingréselo de nuevo: ");
                nom1 = Console.ReadLine();
            }

            Console.Write("Precio: ");
            double pre1 = Convert.ToDouble(Console.ReadLine());
            while (pre1 <= 0)
            {
                Console.Write("Error: El precio debe ser mayor que 0. Ingréselo de nuevo: ");
                pre1 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Cantidad: ");
            int cant1 = Convert.ToInt32(Console.ReadLine());
            while (cant1 < 0)
            {
                Console.Write("Error: La cantidad no puede ser negativa. Ingrésela de nuevo: ");
                cant1 = Convert.ToInt32(Console.ReadLine());
            }

            // Creamos el primer objeto
            Producto prod1 = new Producto(cod1, nom1, pre1, cant1);
            Console.WriteLine();

            // --- PRODUCTO 2 ---
            Console.WriteLine("Ingrese los datos del Producto 2:");
            Console.Write("Código: ");
            string cod2 = Console.ReadLine();

            Console.Write("Nombre: ");
            string nom2 = Console.ReadLine();
            while (nom2 == "")
            {
                Console.Write("Error: El nombre no puede estar vacío. Ingréselo de nuevo: ");
                nom2 = Console.ReadLine();
            }

            Console.Write("Precio: ");
            double pre2 = Convert.ToDouble(Console.ReadLine());
            while (pre2 <= 0)
            {
                Console.Write("Error: El precio debe ser mayor que 0. Ingréselo de nuevo: ");
                pre2 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Cantidad: ");
            int cant2 = Convert.ToInt32(Console.ReadLine());
            while (cant2 < 0)
            {
                Console.Write("Error: La cantidad no puede ser negativa. Ingrésela de nuevo: ");
                cant2 = Convert.ToInt32(Console.ReadLine());
            }

            // Creamos el segundo objeto
            Producto prod2 = new Producto(cod2, nom2, pre2, cant2);
            Console.WriteLine();

            // --- PRODUCTO 3 ---
            Console.WriteLine("Ingrese los datos del Producto 3:");
            Console.Write("Código: ");
            string cod3 = Console.ReadLine();

            Console.Write("Nombre: ");
            string nom3 = Console.ReadLine();
            while (nom3 == "")
            {
                Console.Write("Error: El nombre no puede estar vacío. Ingréselo de nuevo: ");
                nom3 = Console.ReadLine();
            }

            Console.Write("Precio: ");
            double pre3 = Convert.ToDouble(Console.ReadLine());
            while (pre3 <= 0)
            {
                Console.Write("Error: El precio debe ser mayor que 0. Ingréselo de nuevo: ");
                pre3 = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Cantidad: ");
            int cant3 = Convert.ToInt32(Console.ReadLine());
            while (cant3 < 0)
            {
                Console.Write("Error: La cantidad no puede ser negativa. Ingrésela de nuevo: ");
                cant3 = Convert.ToInt32(Console.ReadLine());
            }

            // Creamos el tercer objeto
            Producto prod3 = new Producto(cod3, nom3, pre3, cant3);
            Console.WriteLine();

            // --- MOSTRAR LOS 3 PRODUCTOS ---
            Console.WriteLine("  INVENTARIO REGISTRADO ");
            prod1.MostrarInfo();
            prod2.MostrarInfo();
            prod3.MostrarInfo();

            Console.ReadKey();
        }
    }
}