using System;

namespace TecnoPuntoInventario
{
    public class Producto
    {
        // Campos privados
        private string codigo;
        private string nombre;
        private double precio;
        private int cantidad;

        // Propiedad Codigo
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        // Propiedad Nombre: valida que no esté vacío
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                }
                else
                {
                    nombre = value;
                }
            }
        }

        // Propiedad Precio: valida que sea mayor que 0
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: El precio debe ser mayor que 0.");
                }
                else
                {
                    precio = value;
                }
            }
        }

        // Propiedad Cantidad: valida que no sea negativa (0 sí es válido)
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: La cantidad no puede ser negativa.");
                }
                else
                {
                    cantidad = value;
                }
            }
        }

        // Propiedad de solo lectura (solo tiene get)
        public double ValorTotal
        {
            get { return precio * cantidad; }
        }

        // Constructor que recibe los datos e inicializa el objeto
        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Método para mostrar los datos del producto
        public void MostrarInfo()
        {
            
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: $" + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor Total: $" + ValorTotal);
            
        }
    }
}
