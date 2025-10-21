using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2
{
    internal class Producto
    {
        public int _id {  get; set; }  
        public string _nombre { get; set; } 
        public decimal _precio { get; set; }

        public Producto(int id, string nombre, decimal precio)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
        }
        public class ProductoCRUD
        {
            public List<Producto> productos { get; set;} = new List<Producto>();  //Lista de productos
            public int siguienteId = 1; //se agrega al primer producto 

           public void CrearProducto()
            {
                Console.WriteLine("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio de este producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Producto nuevoProducto = new Producto (siguienteId++, nombre, precio); //incremente el Id
                productos.Add(nuevoProducto);

            }
            public void LeerProductos()
            {

                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID {producto._id}, Nombre: {producto._nombre}, Precio: {producto._precio}");
                }
            }

            public void Actualizarproductos()
            {
                Console.WriteLine("Ingrese el ID del producto a actualizar");
                int id = int.Parse(Console.ReadLine());
                Producto producto = productos.Find(p => p._id == id);

                if (producto != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo precio");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    producto._nombre = nombre;
                    producto._precio = precio;
                    Console.WriteLine("Producto actualizado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }

            public void Eliminarproductos()
            {
                Console.WriteLine("Ingrese el ID del producto a eliminar");
                int id = int.Parse(Console.ReadLine());
                Producto producto = productos.Find(p => p._id == id);

                if (producto != null)
                {
                    productos.Remove(producto);
                    Console.WriteLine("Producto eliminado exitosamente");
                }
                else
                {
                    Console.WriteLine("Producto no encontrado");
                }
            }
        }
    }
}
