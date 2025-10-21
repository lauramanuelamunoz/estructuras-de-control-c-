using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------
            //Crear los objetos

            //Auto coche = new Auto("Toyota", "Corolla", 2020);
            //Auto coche2 = new Auto("Kia", "Picanto", 2010);

            //coche.MostrarInfo();
            //coche2.MostrarInfo();
            //coche._fecha = 2027;
            //coche.MostrarInfo();

            //-----------------------------------------------------------------------------------
            //Console.WriteLine("Ingrese el nombre del aprendiz");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("ingrese la edad del aprendiz:");
            //int edad = int.Parse(Console.ReadLine());
            //Console.WriteLine("ingrese la direccion del aprendiz:");
            //string direccion = Console.ReadLine();

            //Aprendiz estudiantes = new Aprendiz(nombre, edad, direccion);

            //estudiantes.VereficarEdad(); //Llamar al metodo para verificar la edad

            Producto.ProductoCRUD productoCRUD = new Producto.ProductoCRUD();
            bool continuar = true;

            while (true)
            {
                Console.WriteLine("\nSeleccione una opcion");
                Console.WriteLine("1. Crear productos");
                Console.WriteLine("2. Listar productos");
                Console.WriteLine("3. Actualizar productos");
                Console.WriteLine("4. Eliminar productos");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        productoCRUD.CrearProducto();
                        break;
                    case 2:
                        productoCRUD.LeerProductos();
                        break;
                    case 3:
                        productoCRUD.Actualizarproductos();
                        break;
                    case 4:
                        productoCRUD.Eliminarproductos();
                        break;
                    case 5:
                        continuar = false;
                    break;
                default:
                        Console.WriteLine("Opción invalida");
                        break;
                }
            }
        }
    }
}
